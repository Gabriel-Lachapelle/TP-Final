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
        }

        private void AjouterCircuit()
        {
            try
            {
                string SQL = "insert into Ciruits (NumCircuit, VilleDepart, VilleArrivee, NomCircuit, Duree, Prix, NombreClientsMax) values "
                    + "(Sequence.nextval, :VilleDepart, :VilleArrivee, :NomCircuit, :Duree, :Prix, :NombreClientsMax)"; //Modifier le nom de la séquence. =========================
                OracleParameter OraVilleD = new OracleParameter(":VilleDepart", OracleDbType.Char, 3);
                OracleParameter OraVilleA = new OracleParameter(":VilleArrivee", OracleDbType.Char, 3);
                OracleParameter OraNom = new OracleParameter(":NomCircuit", OracleDbType.Varchar2, 30);
                OracleParameter OraDuree = new OracleParameter(":Duree", OracleDbType.Decimal, 5);
                OracleParameter OraPrix = new OracleParameter(":Prix", OracleDbType.Decimal, 5);
                OracleParameter OraClientsMax = new OracleParameter(":NombreClientsMax", OracleDbType.Decimal, 3);

                OraVilleD.Value = CBX_VilleDepart.Text;
                OraVilleA.Value = CBX_VilleArrivee.Text;
                OraNom.Value = TBX_Nom.Text;
                OraDuree.Value = TBX_Duree.Text;
                OraPrix.Value = TBX_Prix.Text;
                OraClientsMax.Value = TBX_ClientsMax.Text;

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
    }
}
