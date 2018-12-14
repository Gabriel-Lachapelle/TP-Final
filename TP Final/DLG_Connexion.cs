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
        private void SauvegarderPreferences()
        {
            Properties.Settings.Default.PreferencesSauvegardees = true;
            if (CBX_Souvenir.Checked)
            {
                Properties.Settings.Default.NomUsager = TBX_Nom.Text;
                Properties.Settings.Default.MotDePasse = TBX_MDP.Text;
            }
            else
            {
                Properties.Settings.Default.NomUsager = "";
                Properties.Settings.Default.MotDePasse = "";
            }
            Properties.Settings.Default.Taille_DLG_Connexion = Size;
            Properties.Settings.Default.Position_DLG_Connexion = Location;
            Properties.Settings.Default.Save();
        }
        private void ChargerPreferences()
        {
            if (Properties.Settings.Default.PreferencesSauvegardees)
            {
                CBX_Souvenir.Checked = Properties.Settings.Default.NomUsager != "";
                TBX_Nom.Text = Properties.Settings.Default.NomUsager;
                TBX_MDP.Text = Properties.Settings.Default.MotDePasse;
                Location = Properties.Settings.Default.Position_DLG_Connexion;
                Size = Properties.Settings.Default.Taille_DLG_Connexion;
            }
        }
     
        private void TBX_TextChanged(object sender, EventArgs e)
        {
            if (TBX_Nom.Text == "" || TBX_MDP.Text == "")
                BTN_Connexion.Enabled = false;
            else
                BTN_Connexion.Enabled = true;
        }

        private void DLG_Connexion_Load(object sender, EventArgs e)
        {
            ChargerPreferences();
        }

        private void DLG_Connexion_FormClosing(object sender, FormClosingEventArgs e)
        {
            SauvegarderPreferences();
        }
    }
}
