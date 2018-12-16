using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Validation;

namespace TP_Final
{
    public partial class DLG_AjoutModif : Form
    {
        ValidationProvider ValidationProvider;
        public OracleConnection Connexion;
        public bool ModeModification = false;
        public string NomCircuitEnModif;
        string IDCircuitEnModif;
        public DLG_AjoutModif()
        {
            InitializeComponent();
        }

        private void DLG_AjoutModif_Load(object sender, EventArgs e)
        {
            ValidationProvider = new ValidationProvider(this);
            ValidationProvider.AddControlToValidate(TBX_Nom, ValiderNom);
            ValidationProvider.AddControlToValidate(CBX_VilleDepart, ValiderCBX_VD);
            ValidationProvider.AddControlToValidate(CBX_VilleArrivee, ValiderCBX_VA);
            ValidationProvider.AddControlToValidate(TBX_Duree, ValiderDuree);
            ValidationProvider.AddControlToValidate(TBX_Prix, ValiderPrix);
            ValidationProvider.AddControlToValidate(TBX_ClientsMax, ValiderClients);

            try
            {
                //Remplir les ComboBox avec le nom des villes:
                string SQL = "select NomVille from Villes";
                OracleCommand OracleCMD = new OracleCommand(SQL, Connexion);
                OracleDataReader OracleRead = OracleCMD.ExecuteReader();
                while (OracleRead.Read())
                {
                    CBX_VilleArrivee.Items.Add(OracleRead.GetString(0));
                    CBX_VilleDepart.Items.Add(OracleRead.GetString(0));
                }
                OracleRead.Close();
            }
            catch (Exception SQL)
            {
                MessageBox.Show(SQL.Message);
            }

            if (ModeModification)
            {
                BTN_Ok.Text = "Modifier";
                try
                {
                    this.Text = "Modification d'un circuit";
                    string SQLModif = "select NomCircuit, VilleDepart, VilleArrivee, Duree, Prix, NombreClientsMax, NumCircuit from Circuits where NomCircuit = '"
                        + NomCircuitEnModif + "'";
                    OracleCommand OracleCMDModif = new OracleCommand(SQLModif, Connexion);
                    OracleDataReader OracleReadModif = OracleCMDModif.ExecuteReader();
                    OracleReadModif.Read();

                    //Remplissage des contrôles avec les données.
                    TBX_Nom.Text = OracleReadModif.GetString(0);
                    TBX_Duree.Text = OracleReadModif.GetDecimal(3).ToString();
                    TBX_Prix.Text = OracleReadModif.GetDecimal(4).ToString();
                    TBX_ClientsMax.Text = OracleReadModif.GetDecimal(5).ToString();
                    IDCircuitEnModif = OracleReadModif.GetDecimal(6).ToString();
                    //On garde les villes puisqu'elles sont sous forme de CodeVille.
                    string VilleD = OracleReadModif.GetString(1);
                    string VilleA = OracleReadModif.GetString(2);
                    OracleReadModif.Close();

                    string SQLVilleD = "select NomVille from Villes where CodeVille = '" + VilleD + "'";
                    string SQLVilleA = "select NomVille from Villes where CodeVille = '" + VilleA + "'";

                    //Ville de départ:
                    OracleCMDModif = new OracleCommand(SQLVilleD, Connexion);
                    OracleReadModif = OracleCMDModif.ExecuteReader();
                    OracleReadModif.Read();
                    VilleD = OracleReadModif.GetString(0);
                    OracleReadModif.Close();

                    for (int i = 0; i < CBX_VilleDepart.Items.Count; i++)
                    {
                        if (VilleD == CBX_VilleDepart.Items[i].ToString())
                            CBX_VilleDepart.SelectedIndex = i;
                    }

                    //Ville d'arrivée:
                    OracleCMDModif = new OracleCommand(SQLVilleA, Connexion);
                    OracleReadModif = OracleCMDModif.ExecuteReader();
                    OracleReadModif.Read();
                    VilleA = OracleReadModif.GetString(0);
                    OracleReadModif.Close();

                    for (int i = 0; i < CBX_VilleArrivee.Items.Count; i++)
                    {
                        if (VilleA == CBX_VilleArrivee.Items[i].ToString())
                            CBX_VilleArrivee.SelectedIndex = i;
                    }
                }
                catch (Exception SQLModif)
                {
                    MessageBox.Show(SQLModif.Message);
                }
            }
        }

        private void AjouterCircuit()
        {
            try
            {
                //Pour changer les nom des villes en CodeVille:
                string SQLVilleD = "select CodeVille from Villes where NomVille = '" + CBX_VilleDepart.Text + "'";
                string SQLVilleA = "select CodeVille from Villes where NomVille = '" + CBX_VilleArrivee.Text + "'";

                //Villes de départ:
                OracleCommand OracleCMDVille = new OracleCommand(SQLVilleD, Connexion);
                OracleDataReader OracleRead = OracleCMDVille.ExecuteReader();
                OracleRead.Read();
                SQLVilleD = OracleRead.GetString(0);
                OracleRead.Close();

                //Ville d'arrivée:
                OracleCMDVille = new OracleCommand(SQLVilleA, Connexion);
                OracleRead = OracleCMDVille.ExecuteReader();
                OracleRead.Read();
                SQLVilleA = OracleRead.GetString(0);
                OracleRead.Close();

                //Pour insérer les données dans la BD:
                string SQL = "insert into Circuits (NumCircuit, VilleDepart, VilleArrivee, NomCircuit, Duree, Prix, NombreClientsMax) values "
                    + "(CircuitSeq.nextval, :VilleDepart, :VilleArrivee, :NomCircuit, :Duree, :Prix, :NombreClientsMax)";
                OracleParameter OraVilleD = new OracleParameter(":VilleDepart", OracleDbType.Char, 3);
                OracleParameter OraVilleA = new OracleParameter(":VilleArrivee", OracleDbType.Char, 3);
                OracleParameter OraNom = new OracleParameter(":NomCircuit", OracleDbType.Varchar2, 30);
                OracleParameter OraDuree = new OracleParameter(":Duree", OracleDbType.Decimal, 5);
                OracleParameter OraPrix = new OracleParameter(":Prix", OracleDbType.Decimal, 5);
                OracleParameter OraClientsMax = new OracleParameter(":NombreClientsMax", OracleDbType.Decimal, 3);

                //Affectation des valeurs au paramètres:
                OraVilleD.Value = SQLVilleD;
                OraVilleA.Value = SQLVilleA;
                OraNom.Value = TBX_Nom.Text;
                OraDuree.Value = TBX_Duree.Text;
                OraPrix.Value = TBX_Prix.Text;
                OraClientsMax.Value = TBX_ClientsMax.Text;

                //Création et exécution de la requête:
                OracleCommand OracleCMD = new OracleCommand(SQL, Connexion);
                OracleCMD.CommandType = CommandType.Text;
                OracleCMD.Parameters.Add(OraVilleD);
                OracleCMD.Parameters.Add(OraVilleA);
                OracleCMD.Parameters.Add(OraNom);
                OracleCMD.Parameters.Add(OraDuree);
                OracleCMD.Parameters.Add(OraPrix);
                OracleCMD.Parameters.Add(OraClientsMax);
                OracleCMD.ExecuteNonQuery();
            }
            catch (Exception SQL)
            {
                MessageBox.Show(SQL.Message);
            }
        }

        private void ModifierCircuit()
        {
            try
            {
                //Pour changer les nom des villes en CodeVille:
                string SQLVilleD = "select CodeVille from Villes where NomVille = '" + CBX_VilleDepart.Text + "'";
                string SQLVilleA = "select CodeVille from Villes where NomVille = '" + CBX_VilleArrivee.Text + "'";

                //Villes de départ:
                OracleCommand OracleCMDVille = new OracleCommand(SQLVilleD, Connexion);
                OracleDataReader OracleRead = OracleCMDVille.ExecuteReader();
                OracleRead.Read();
                SQLVilleD = OracleRead.GetString(0);
                OracleRead.Close();

                //Ville d'arrivée:
                OracleCMDVille = new OracleCommand(SQLVilleA, Connexion);
                OracleRead = OracleCMDVille.ExecuteReader();
                OracleRead.Read();
                SQLVilleA = OracleRead.GetString(0);
                OracleRead.Close();

                //Mise à jour de la table:
                string SQL = "update Circuits set NomCircuit = '" + TBX_Nom.Text + "', VilleDepart = '" + SQLVilleD + "', VilleArrivee = '" + SQLVilleA + "', Duree = " + TBX_Duree.Text
                   + ", Prix = " + TBX_Prix.Text + ", NombreClientsMax = " + TBX_ClientsMax.Text + " where NumCircuit = " + IDCircuitEnModif;
                OracleCommand OracleCMD = new OracleCommand(SQL, Connexion);
                OracleCMD.ExecuteNonQuery();
            }
            catch (Exception SQL)
            {
                MessageBox.Show(SQL.Message);
            }
        }
        private void Numbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BTN_Ok_Click(object sender, EventArgs e)
        {
            if (TBX_Nom.Text != "" && TBX_Prix.Text != "" && TBX_Duree.Text != "" && TBX_ClientsMax.Text != "" && CBX_VilleArrivee.Text != "" && CBX_VilleDepart.Text != "")
            {
                if (ModeModification)
                    ModifierCircuit();
                else
                    AjouterCircuit();
            }
        }

        private bool ValiderNom(ref string message)
        {
            message = "Nom vide";
            return TBX_Nom.Text != "";
        }
        private bool ValiderCBX_VD(ref string message)
        {
            message = "Aucune ville de départ choisi";
            return CBX_VilleDepart.Text != "";
        }
        private bool ValiderCBX_VA(ref string message)
        {
            message = "Aucune ville d'arrivée choisi";
            return CBX_VilleArrivee.Text != "";
        }
        private bool ValiderDuree(ref string message)
        {
            message = "Duree vide";
            return TBX_Duree.Text != "";
        }
        private bool ValiderPrix(ref string message)
        {
            message = "Prix vide";
            return TBX_Prix.Text != "";
        }
        private bool ValiderClients(ref string message)
        {
            message = "Nombre de clients vide";
            return TBX_ClientsMax.Text != "";
        }
    }
}