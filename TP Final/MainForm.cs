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
        bool Connecté = false;
        OracleConnection Connexion = new OracleConnection();
        public MainForm()
        {
            InitializeComponent();
        }

        #region Fonctions
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        void Deconnexion()
        {
            Connexion.Close();
            Connecté = false;
            UpdateControls();
        }
        void UpdateControls()
        {
            MI_Connexion_Connecter.Enabled = !Connecté;
            MI_Connexion_Deconnecter.Enabled = Connecté;
            DGV_Circuit.Enabled = Connecté;
            CBX_Tous.Enabled = Connecté;
            CBX_Meilleur.Enabled = Connecté;
            CBX_VilleDepart.Enabled = Connecté;
            CBX_Monument.Enabled = Connecté;
            CBX_Prix.Enabled = Connecté;
            TBX_VilleDepart.Enabled = Connecté;
            TBX_Prix.Enabled = Connecté;
            TBX_Monument.Enabled = Connecté;
            BTN_Rechercher.Enabled = Connecté;
            TSMI_Circuit.Enabled = Connecté;
            TSMI_Monument.Enabled = Connecté;
            FB_Circuit_Ajout.Enabled = Connecté;
            Initialise_DGV_Circuit();
        }
        void Initialise_DGV_Circuit()
        {
            bool PlusQue1Argument = false;
            string sVille = "VilleDepart like '%" + TBX_VilleDepart.Text + "%'";
            string sPrix = "Prix < " + TBX_Prix.Text;
            string sMonument = "Monument like '%" + TBX_Monument.Text + "%'";
            string GroupBy = " group by Circuits.NomCircuit, VilleDepart, VilleArrivee, Circuits.Prix";
            if (Connecté)
            {
                try
                {
                    DGV_Circuit.Rows.Clear();
                    string SQL = "select * from RechercheCircuit";
                    if (CBX_Meilleur.Checked)
                    {
                        SQL = "select * from MeilleurMonument";
                    }
                    else if (!CBX_Tous.Checked)
                    {
                        SQL += " where ";
                        if (CBX_Monument.Checked)
                        {
                            SQL += sMonument;
                            PlusQue1Argument = true;
                        }
                        if (CBX_VilleDepart.Checked)
                        {
                            if (PlusQue1Argument)
                                SQL += " and ";
                            SQL += sVille;
                            PlusQue1Argument = true;
                        }
                        if (CBX_Prix.Checked)
                        {
                            if (PlusQue1Argument)
                                SQL += " and ";
                            SQL += sPrix;
                        }
                        SQL += GroupBy;
                    }

                    OracleCommand OracleCMD = new OracleCommand(SQL, Connexion);
                    OracleDataReader OracleRead = OracleCMD.ExecuteReader();

                    while (OracleRead.Read())
                    {
                        DGV_Circuit.Rows.Add(OracleRead.GetString(0), OracleRead.GetString(1), OracleRead.GetString(2), OracleRead.GetDecimal(3), OracleRead.GetDecimal(4));
                    }
                    OracleRead.Close();
                }
                catch (Exception SQL)
                {
                    MessageBox.Show(SQL.Message);
                }
            }
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        #endregion

        #region Événements
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void FB_Circuit_Ajout_Click(object sender, EventArgs e)
        {
            DLG_AjoutModif DLG = new DLG_AjoutModif();
            DLG.Connexion = Connexion;
            DLG.ShowDialog();
        }
        private void FB_Circuit_Modif_Click(object sender, EventArgs e)
        {
            DLG_AjoutModif DLG = new DLG_AjoutModif();
            DLG.Connexion = Connexion;
            DLG.ModeModification = true;
            DLG.ShowDialog();
        }
        private void FB_Circuit_Show_Click(object sender, EventArgs e)
        {
            DLG_ListeMonuments DLG = new DLG_ListeMonuments();
            DLG.Show();
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
                CBX_Meilleur.Checked = false;
                CBX_VilleDepart.Checked = false;
                CBX_Prix.Checked = false;
                CBX_Monument.Checked = false;
                CBX_Tous.Checked = true;
            }
        }
        private void CBX_Meilleur_CheckedChanged(object sender, EventArgs e)
        {
            if (CBX_Meilleur.Checked)
            {
                CBX_Tous.Checked = false;
                CBX_VilleDepart.Checked = false;
                CBX_Prix.Checked = false;
                CBX_Monument.Checked = false;
                CBX_Meilleur.Checked = true;
            }
        }
        private void CBX_Other_CheckedChanged(object sender, EventArgs e)
        {
            if (CBX_VilleDepart.Checked || CBX_Prix.Checked || CBX_Monument.Checked)
            {
                CBX_Tous.Checked = false;
                CBX_Meilleur.Checked = false;
            }
        }
        private void MI_Connexion_Connecter_Click(object sender, EventArgs e)
        {
            DLG_Connexion DLG = new DLG_Connexion();
            if (DLG.ShowDialog() == DialogResult.OK)
            {
                Connexion = DLG.Connexion;
                Connecté = true;
                UpdateControls();
            }
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Deconnexion();
        }
        private void MI_Connexion_Deconnecter_Click(object sender, EventArgs e)
        {
            Deconnexion();
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        #endregion
    }
}
