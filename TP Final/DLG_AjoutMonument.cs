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
using System.IO;
using Validation;
using DB_Images_Utilities;

namespace TP_Final
{

    public partial class DLG_AjoutMonument : Form
    {
        ValidationProvider ValidationProvider;
        public OracleConnection Connexion;
        DB_Images DB_Images;
        string GUID;
        public DLG_AjoutMonument()
        {
            InitializeComponent();
            DB_Images = new DB_Images("Gabriel", "MotDePasse");
        }

        private void DLG_AjoutMonument_Load(object sender, EventArgs e)
        {
            Charger();
            ValidationProvider = new ValidationProvider(this);
            ValidationProvider.AddControlToValidate(TBX_Nom, ValiderNom);
            ValidationProvider.AddControlToValidate(TBX_Prix, ValiderPrix);
            ValidationProvider.AddControlToValidate(TBX_Annee, ValiderAnnee);
            ValidationProvider.AddControlToValidate(RTBX_Histoire, ValiderHistoire);
            ValidationProvider.AddControlToValidate(PBX_Image, ValiderImage);
            ValidationProvider.AddControlToValidate(Stars, ValiderEtoiles);
        }

        private bool ValiderNom(ref string message)
        {
            message = "Le nom est vide";
            return TBX_Nom.Text != "";
        }

        private bool ValiderPrix(ref string message)
        {
            message = "Le prix est vide";
            return TBX_Prix.Text != "";
        }
        private bool ValiderAnnee(ref string message)
        {
            if (TBX_Annee.Text == "")
                message = "L'année de construction est vide";
            else
            {
                message = "L'année ne peut pas supérieure à " + DateTime.Now.Year.ToString();
                int Date = DateTime.Now.Year;
                if (TBX_Annee.Text != "")
                    Date = Convert.ToInt32(TBX_Annee.Text);
                return Date <= DateTime.Now.Year;
            }
            return TBX_Annee.Text != "";
        }
        private bool ValiderHistoire(ref string message)
        {
            message = "L'histoire du monument est vide";
            return RTBX_Histoire.Text != "";
        }
        private bool ValiderImage(ref string message)
        {
            message = "Aucune image choisie";
            return PBX_Image.BackgroundImage != null;
        }
        private bool ValiderEtoiles(ref string message)
        {
            message = "Veuillez noter le monument";
            return Stars.Value != 0;
        }

        private void Numbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AjouterMonument()
        {
            try
            {
                AjouterPhoto();
                string SQL = "insert into Monuments values (MonumentSeq.nextval, :NomMonument, :AnneeConstruction, :Histoire, :Image, :Prix, :NombreEtoiles)";
                OracleParameter OraNom = new OracleParameter(":NomMonument", OracleDbType.Varchar2, 60);
                OracleParameter OraAnnee = new OracleParameter(":AnneeConstruction", OracleDbType.Int32, 4);
                OracleParameter OraHistoire = new OracleParameter(":Histoire", OracleDbType.Varchar2, 600);
                OracleParameter OraImage = new OracleParameter(":Image", OracleDbType.Varchar2, 80);
                OracleParameter OraPrix = new OracleParameter(":Prix", OracleDbType.Decimal, 5);
                OracleParameter OraNbEtoiles = new OracleParameter(":NombreEtoiles", OracleDbType.Int32, 1);

                OraNom.Value = TBX_Nom.Text;
                OraAnnee.Value = TBX_Annee.Text;
                OraHistoire.Value = RTBX_Histoire.Text;
                OraImage.Value = GUID;
                OraPrix.Value = TBX_Prix.Text;
                OraNbEtoiles.Value = Stars.Value;

                OracleCommand OracleCMD = new OracleCommand(SQL, Connexion);
                OracleCMD.CommandType = CommandType.Text;
                OracleCMD.Parameters.Add(OraNom);
                OracleCMD.Parameters.Add(OraAnnee);
                OracleCMD.Parameters.Add(OraHistoire);
                OracleCMD.Parameters.Add(OraImage);
                OracleCMD.Parameters.Add(OraPrix);
                OracleCMD.Parameters.Add(OraNbEtoiles);
                OracleCMD.ExecuteNonQuery();
            }
            catch (Exception SQL)
            {
                MessageBox.Show(SQL.Message);
            }
        }

        private void AjouterPhoto()
        {
            if (PBX_Image.BackgroundImage != null)
            {
                Image Image = PBX_Image.BackgroundImage;
                GUID = DB_Images.Add(Image);
            }
        }

        private void BTN_Ajouter_Click(object sender, EventArgs e)
        {
            if (TBX_Nom.Text != "" && TBX_Annee.Text != "" && TBX_Prix.Text != "" && RTBX_Histoire.Text != "" && Stars.Value > 0 && PBX_Image.BackgroundImage != null)
            {
                AjouterMonument();
                this.Close();
            }
        }

        private void BTN_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Stars_ValueChanged(object sender, EventArgs e)
        {
            ValidationProvider.UpdateError(Stars);
        }

        private void Sauvegarder()
        {
            Properties.Settings.Default.DLG_AjoutMonuments_Pref = true;
            Properties.Settings.Default.DLG_AjoutMonuments_Position = Location;
            Properties.Settings.Default.DLG_AjoutMonuments_Taille = Size;
        }
        private void Charger()
        {
            if (Properties.Settings.Default.DLG_AjoutMonuments_Pref)
            {
                Location = Properties.Settings.Default.DLG_AjoutMonuments_Position;
                Size = Properties.Settings.Default.DLG_AjoutMonuments_Taille;
            }
        }

        private void DLG_AjoutMonument_FormClosing(object sender, FormClosingEventArgs e)
        {
            Sauvegarder();
        }
    }
}