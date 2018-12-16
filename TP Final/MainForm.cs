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
            DGV_Circuit.Rows.Clear();
            FB_Circuit_Ajout.Enabled = Connecté;
            FB_Circuit_Modif.Enabled = Connecté;
            FB_Circuit_Supp.Enabled = Connecté;
            FB_Info.Enabled = Connecté;
            FB_Gerer.Enabled = Connecté;
            FB_AjoutMonument.Enabled = Connecté;
            MI_Circuits_Ajout.Enabled = Connecté;
            MI_Circuits_Modif.Enabled = Connecté;
            MI_Circuit_Supp.Enabled = Connecté;
            BTN_TousMonuments.Enabled = Connecté;
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
            FB_Circuit_Ajout.Enabled = Connecté;
            BTN_TousMonuments.Enabled = Connecté;
            if (Connecté)
                Initialise_DGV_Circuit();
        }
        void Initialise_DGV_Circuit()
        {
            bool PlusQue1Argument = false;
            string sVille = "VilleDepart like '%" + TBX_VilleDepart.Text + "%'";
            string sPrix = "Prix < " + TBX_Prix.Text;
            string sMonument = "NomMonument like '%" + TBX_Monument.Text + "%'";
            string GroupBy = " group by NomCircuit, VilleDepart, VilleArrivee, Prix";
            if (Connecté)
            {
                try
                {
                    DGV_Circuit.Rows.Clear();
                    string SQL = "select NomCircuit, VilleDepart, VilleArrivee, Prix from RechercheCircuit";
                    if (CBX_Meilleur.Checked)
                    {
                        SQL = "select * from MeilleurCircuit";
                    }
                    else
                    {
                        if (CBX_Tous.Checked)
                            SQL = "select * from TousLesCircuits";
                        else
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
                        if (!CBX_Tous.Checked)
                            SQL += GroupBy;
                    }

                    OracleCommand OracleCMD = new OracleCommand(SQL, Connexion);
                    OracleDataReader OracleRead = OracleCMD.ExecuteReader();

                    while (OracleRead.Read())
                    {
                        DGV_Circuit.Rows.Add(OracleRead.GetString(0), OracleRead.GetString(1), OracleRead.GetString(2), OracleRead.GetDecimal(3));
                    }
                    OracleRead.Close();
                }
                catch (Exception SQL)
                {
                    MessageBox.Show(SQL.Message);
                }
            }
        }
        private void RafraichirBoutonRecherche()
        {
            BTN_Rechercher.Enabled = CBX_Tous.Checked || CBX_Meilleur.Checked || CBX_VilleDepart.Checked || CBX_Prix.Checked || CBX_Monument.Checked;
        }
        private void AjouterCircuit()
        {
            DLG_AjoutModif DLG = new DLG_AjoutModif();
            DLG.Connexion = Connexion;
            DLG.ShowDialog();
            Initialise_DGV_Circuit();
        }
        private void ModifierCircuit()
        {
            DLG_AjoutModif DLG = new DLG_AjoutModif();
            DLG.Connexion = Connexion;
            DLG.NomCircuitEnModif = DGV_Circuit.SelectedRows[0].Cells["NomCircuit"].Value.ToString();
            DLG.ModeModification = true;
            DLG.ShowDialog();
            Initialise_DGV_Circuit();
        }
        private void SupprimerCircuit()
        {
            if (MessageBox.Show("Êtes vous sûr de vouloir supprimer ce circuit?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    string SQL = "delete from Circuits where NomCircuit = '" + DGV_Circuit.SelectedRows[0].Cells["NomCircuit"].Value.ToString() + "'";
                    OracleCommand OracleCMD = new OracleCommand(SQL, Connexion);
                    OracleCMD.ExecuteNonQuery();
                    Initialise_DGV_Circuit();
                }
                catch (Exception SQL)
                {
                    MessageBox.Show(SQL.Message);
                }
            }
        }
        private void SauvegarderPreferences()
        {
            Properties.Settings.Default.MainForm_Pref = true;
            Properties.Settings.Default.MainForm_Position = Location;
            Properties.Settings.Default.MainForm_Taille = Size;
            Properties.Settings.Default.Save();
        }
        private void ChargerPreferences()
        {
            if (Properties.Settings.Default.MainForm_Pref)
            {
                Location = Properties.Settings.Default.MainForm_Position;
                Size = Properties.Settings.Default.MainForm_Taille;
            }
        }
        private void ListerMonuments()
        {
            DLG_ListeMonuments DLG = new DLG_ListeMonuments();
            DLG.Connexion = Connexion;
            DLG.NomCircuit = DGV_Circuit.SelectedRows[0].Cells["NomCircuit"].Value.ToString();
            DLG.Show();
        }
        private void GererMonuments()
        {
            DLG_GererMonuments DLG = new DLG_GererMonuments();
            DLG.Connexion = Connexion;
            DLG.NomCircuit = DGV_Circuit.SelectedRows[0].Cells["NomCircuit"].Value.ToString();
            DLG.Show();
        }

        private void AjouterMonument()
        {
            DLG_AjoutMonument DLG = new DLG_AjoutMonument();
            DLG.Connexion = Connexion;
            DLG.Show();
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        #endregion

        #region Événements
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void FB_Circuit_Ajout_Click(object sender, EventArgs e)
        {
            AjouterCircuit();
        }
        private void FB_Circuit_Modif_Click(object sender, EventArgs e)
        {
            ModifierCircuit();
        }
        private void FB_Circuit_Gerer_Click(object sender, EventArgs e)
        {
            ListerMonuments();
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
            RafraichirBoutonRecherche();
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
            RafraichirBoutonRecherche();
        }
        private void CBX_Other_CheckedChanged(object sender, EventArgs e)
        {
            if (CBX_VilleDepart.Checked || CBX_Prix.Checked || CBX_Monument.Checked)
            {
                CBX_Tous.Checked = false;
                CBX_Meilleur.Checked = false;
            }
            RafraichirBoutonRecherche();
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
            SauvegarderPreferences();
        }
        private void MI_Connexion_Deconnecter_Click(object sender, EventArgs e)
        {
            Deconnexion();
        }
        private void BTN_Rechercher_Click(object sender, EventArgs e)
        {
            Initialise_DGV_Circuit();
        }
        private void MI_Circuits_Ajout_Click(object sender, EventArgs e)
        {
            AjouterCircuit();
        }
        private void MI_Circuits_Modif_Click(object sender, EventArgs e)
        {
            ModifierCircuit();
        }
        private void FB_Circuit_Supp_Click(object sender, EventArgs e)
        {
            SupprimerCircuit();
        }
        private void DGV_Circuit_SelectionChanged(object sender, EventArgs e)
        {
            FB_Circuit_Modif.Enabled = DGV_Circuit.SelectedRows != null;
            FB_Info.Enabled = DGV_Circuit.SelectedRows != null;
            FB_Circuit_Supp.Enabled = DGV_Circuit.SelectedRows != null;
            FB_Info.Enabled = DGV_Circuit.SelectedRows != null;
            FB_Gerer.Enabled = DGV_Circuit.SelectedRows != null;
            FB_AjoutMonument.Enabled = DGV_Circuit.SelectedRows != null;
            MI_Circuits_Ajout.Enabled = DGV_Circuit.SelectedRows != null;
            MI_Circuits_Modif.Enabled = DGV_Circuit.SelectedRows != null;
            MI_Circuit_Supp.Enabled = DGV_Circuit.SelectedRows != null;
        }
        private void MI_Circuit_Supp_Click(object sender, EventArgs e)
        {
            SupprimerCircuit();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            ChargerPreferences();
        }
        private void FB_Gerer_Click(object sender, EventArgs e)
        {
            GererMonuments();
        }

        private void FB_AjoutMonument_Click(object sender, EventArgs e)
        {
            AjouterMonument();
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        #endregion

        private void BTN_TousMonuments_Click(object sender, EventArgs e)
        {
            VoirMonuments();
        }

        private void VoirMonuments()
        {
            DLG_InfoMonument DLG = new DLG_InfoMonument();
            DLG.Connexion = Connexion;
            DLG.Show();
        }
    }
}
