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
        private Validation.ValidationProvider ValidationProvider;

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
                    MessageBox.Show("La combinaison du nom d'usager et du mot de passe est invalide.", "Erreur");
                else
                    MessageBox.Show(SQL.Message, "Erreur");
            }
        }
        private void SauvegarderPreferences()
        {
            Properties.Settings.Default.DLG_Connexion_Pref = true;
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
            Properties.Settings.Default.DLG_Connexion_Taille = Size;
            Properties.Settings.Default.DLG_Connexion_Position = Location;
            Properties.Settings.Default.Save();
        }
        private void ChargerPreferences()
        {
            if (Properties.Settings.Default.DLG_Connexion_Pref)
            {
                CBX_Souvenir.Checked = Properties.Settings.Default.NomUsager != "";
                TBX_Nom.Text = Properties.Settings.Default.NomUsager;
                TBX_MDP.Text = Properties.Settings.Default.MotDePasse;
                Location = Properties.Settings.Default.DLG_Connexion_Position;
                Size = Properties.Settings.Default.DLG_Connexion_Taille;
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

            ValidationProvider = new Validation.ValidationProvider(this);
            ValidationProvider.AddControlToValidate(TBX_Nom, TBX_Nom_Validate);
            ValidationProvider.AddControlToValidate(TBX_MDP, TBX_MDP_Validate);
        }

        private bool TBX_Nom_Validate(ref string Message)
        {
            Message = "Le nom ne doit pas être vide";

            return TBX_Nom.Text != "";
        }

        private bool TBX_MDP_Validate(ref string Message)
        {
            Message = "Le mot de passe ne doit pas être vide";

            return TBX_MDP.Text != "";
        }
    }
}
