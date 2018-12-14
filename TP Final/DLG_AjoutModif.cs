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

namespace TP_Final
{
    public partial class DLG_AjoutModif : Form
    {
        public OracleConnection Connexion;
        public bool ModeModification = false;
        public DLG_AjoutModif()
        {
            InitializeComponent();
        }

        private void DLG_AjoutModif_Load(object sender, EventArgs e)
        {
            if (ModeModification)
            {
                this.Text = "Modification d'un circuit";
                //Remplir les contrôles avec les informations du circuit.
            }

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
        private void Numbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BTN_Ok_Click(object sender, EventArgs e)
        {
            AjouterCircuit();
        }
    }
}
