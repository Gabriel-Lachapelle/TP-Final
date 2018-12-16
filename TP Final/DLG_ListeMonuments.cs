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

        private void FB_Prochain_Click(object sender, EventArgs e)
        {
            this.BindingContext[DS, "Liste Monuments"].Position++;
            TBX_Ordre.Text = (this.BindingContext[DS, "Liste Monuments"].Position + 1).ToString();
            AfficherImage();
        }

        private void FB_Precedent_Click(object sender, EventArgs e)
        {
            this.BindingContext[DS, "Liste Monuments"].Position--;
            TBX_Ordre.Text = (this.BindingContext[DS, "Liste Monuments"].Position + 1).ToString();
            AfficherImage();
        }

        private void AfficherImage()
        {
            PBX_Image.BackgroundImage = DB_Images.Find(GBX_Monuments.Name);
        }
    }
}
