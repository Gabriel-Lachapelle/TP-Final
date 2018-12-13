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
    public partial class MainForm : Form
    {
        OracleConnection Connexion = new OracleConnection();
        public MainForm()
        {
            InitializeComponent();
        }

        private void FB_Circuit_Ajout_Click(object sender, EventArgs e)
        {

        }

        private void FB_Circuit_Modif_Click(object sender, EventArgs e)
        {

        }

        private void FB_Circuit_Show_Click(object sender, EventArgs e)
        {

        }

        private void FB_Monument_Ajout_Click(object sender, EventArgs e)
        {

        }

        private void FB_Monument_Supp_Click(object sender, EventArgs e)
        {

        }

        private void CBX_Tous_CheckedChanged(object sender, EventArgs e)
        {
            if (CBX_Tous.Checked)
            {
                CBX_VilleDepart.Checked = false;
                CBX_Prix.Checked = false;
                CBX_Monument.Checked = false;
                CBX_Tous.Checked = true;
            }
        }

        private void CBX_Other_CheckedChanged(object sender, EventArgs e)
        {
            if (CBX_VilleDepart.Checked || CBX_Prix.Checked || CBX_Monument.Checked)
                CBX_Tous.Checked = false;
        }

        private void MI_Connexion_Connecter_Click(object sender, EventArgs e)
        {
            DLG_Connexion DLG = new DLG_Connexion();
            if (DLG.ShowDialog() == DialogResult.OK)
            {
                Connexion = DLG.Connexion;
                MI_Connexion_Connecter.Enabled = false;
                MI_Connexion_Deconnecter.Enabled = true;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Connexion.Close();
        }

        private void MI_Connexion_Deconnecter_Click(object sender, EventArgs e)
        {
            Connexion.Close();
            MI_Connexion_Connecter.Enabled = true;
            MI_Connexion_Deconnecter.Enabled = false;
        }
    }
}
