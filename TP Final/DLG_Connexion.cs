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
    public partial class DLG_Connexion : Form
    {
        public OracleConnection Connexion = new OracleConnection();
        public DLG_Connexion()
        {
            InitializeComponent();
        }

        private void BTN_Connexion_Click(object sender, EventArgs e)
        {
            try
            {
                string DSource = "(DESCRIPTION=" + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)"
                             + "(HOST=mercure.clg.qc.ca)(PORT=1521)))" + "(CONNECT_DATA=(SERVICE_NAME=ORCL.clg.qc.ca)));";
                string ChaineDeConnexion = "Data Source = " + DSource + "User Id = " + TBX_Nom.Text + "; password = " + TBX_MDP.Text;
                Connexion.ConnectionString = ChaineDeConnexion;
                Connexion.Open();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception SQL)
            {
                if (SQL.Message == "ORA-01017: invalid username/password; logon denied")
                    MessageBox.Show("La combinaison du nom d'usager et du mot de passe est invalide.", "Érreur");
                else
                    MessageBox.Show(SQL.Message, "Érreur");
            }
        }

        private void TBX_TextChanged(object sender, EventArgs e)
        {
            if (TBX_Nom.Text == "" || TBX_MDP.Text == "")
                BTN_Connexion.Enabled = false;
            else
                BTN_Connexion.Enabled = true;
        }
    }
}
