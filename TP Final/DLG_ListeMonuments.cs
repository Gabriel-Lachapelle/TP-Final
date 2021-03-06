﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using DB_Images_Utilities;

namespace TP_Final
{
    public partial class DLG_ListeMonuments : Form
    {
        public OracleConnection Connexion;
        DataSet DS = new DataSet();
        public string NomCircuit;
        DB_Images DB_Images;
        public DLG_ListeMonuments()
        {
            InitializeComponent();
            DB_Images = new DB_Images("Gabriel", "MotDePasse");
        }

        private void DLG_GererMonuments_Load(object sender, EventArgs e)
        {
            Charger();
            TBX_NomCircuit.Text = NomCircuit;
            try
            {
                string SQL = "select * from ListeMonument where NomCircuit = '" + NomCircuit + "' order by Ordre";
                OracleDataAdapter OracleAdapter = new OracleDataAdapter(SQL, Connexion);
                if (DS.Tables.Contains("Liste Monuments"))
                    DS.Tables["Liste Monuments"].Clear();
                OracleAdapter.Fill(DS, "Liste Monuments");
                OracleAdapter.Dispose();
                LierDetails();
                TBX_Ordre.Text = (this.BindingContext[DS, "Liste Monuments"].Position + 1).ToString();
                AfficherImage();
                ChangerEtatBouton();
            }
            catch (Exception SQL)
            {
                MessageBox.Show(SQL.Message);
            }
        }

        private void LierDetails()
        {
            GBX_Monuments.DataBindings.Add("name", DS, "Liste Monuments.Image");
            TBX_Nom.DataBindings.Add("text", DS, "Liste Monuments.NomMonument");
            TBX_Cout.DataBindings.Add("text", DS, "Liste Monuments.Prix");
            RTBX_Histoire.DataBindings.Add("text", DS, "Liste Monuments.Histoire");
        }

        private void ChangerEtatBouton()
        {
            if (DS.Tables.Contains("Liste Monuments"))
            {
                if (this.BindingContext[DS, "Liste Monuments"].Position == 0)
                    FB_Precedent.Enabled = false;
                else
                    FB_Precedent.Enabled = true;


                if (this.BindingContext[DS, "Liste Monuments"].Position + 1 == this.BindingContext[DS, "Liste Monuments"].Count)
                    FB_Prochain.Enabled = false;
                else
                    FB_Prochain.Enabled = true;
            }
            else
            {
                FB_Precedent.Enabled = false;
                FB_Prochain.Enabled = false;
            }
        }

        private void FB_Prochain_Click(object sender, EventArgs e)
        {
            this.BindingContext[DS, "Liste Monuments"].Position++;
            TBX_Ordre.Text = (this.BindingContext[DS, "Liste Monuments"].Position + 1).ToString();
            AfficherImage();
            ChangerEtatBouton();
        }

        private void FB_Precedent_Click(object sender, EventArgs e)
        {
            this.BindingContext[DS, "Liste Monuments"].Position--;
            TBX_Ordre.Text = (this.BindingContext[DS, "Liste Monuments"].Position + 1).ToString();
            AfficherImage();
            ChangerEtatBouton();
        }

        private void AfficherImage()
        {
            PBX_Image.BackgroundImage = DB_Images.Find(GBX_Monuments.Name);
        }

        private void Sauvegarder()
        {
            Properties.Settings.Default.DLG_ListeMonuments_Pref = true;
            Properties.Settings.Default.DLG_ListeMonuments_Position = Location;
            Properties.Settings.Default.DLG_ListeMonuments_Taille = Size;
        }
        private void Charger()
        {
            if (Properties.Settings.Default.DLG_ListeMonuments_Pref)
            {
                Location = Properties.Settings.Default.DLG_ListeMonuments_Position;
                Size = Properties.Settings.Default.DLG_ListeMonuments_Taille;
            }
        }

        private void DLG_ListeMonuments_FormClosing(object sender, FormClosingEventArgs e)
        {
            Sauvegarder();
        }
    }
}
