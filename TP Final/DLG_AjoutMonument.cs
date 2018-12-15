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
  
    public partial class DLG_AjoutMonument : Form
    {
        public OracleConnection Connexion;
        int Cotation = 0;
        public DLG_AjoutMonument()
        {
            InitializeComponent();
            PBX_Image.AllowDrop = true;
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
            string SQL = "insert into Monument (NumMonument, NomMonument, AnneeConstruction, Histoire, Image, Prix, NombreEtoiles) values " +
                "(MonumentSeq.nextval, :NomMonument, :AnneeConstruction, :Histoire, :Image, :Prix, :NombreEtoiles)";
            OracleParameter OraNom = new OracleParameter(":NomMonument", OracleDbType.Varchar2, 60);
            OracleParameter OraAnnee = new OracleParameter(":AnneeConstruction", OracleDbType.Int32, 4);
            OracleParameter OraHistoire = new OracleParameter(":Histoire", OracleDbType.Varchar2, 600);
            OracleParameter OraImage = new OracleParameter(":Image", OracleDbType.Varchar2, 30);
            OracleParameter OraPrix = new OracleParameter(":Prix", OracleDbType.Decimal, 5);
            OracleParameter OraNbEtoiles = new OracleParameter(":NombreEtoiles", OracleDbType.Int32, 1);

            OraNom.Value = TBX_Nom.Text;
            OraAnnee.Value = TBX_Annee.Text;
            OraHistoire.Value = RTBX_Histoire.Text;
            OraImage.Value = PBX_Image.ImageLocation; // A modifier
            OraPrix.Value = TBX_Prix.Text;
            OraNbEtoiles.Value = Cotation;

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

        private void RafraichirEtoiles()
        {
            if (Cotation >= 1)
                FB_Etoile_1.NeutralImage = Properties.Resources.Star_Neutral;
            else
                FB_Etoile_1.NeutralImage = Properties.Resources.Star_Disabled;
            if (Cotation >= 2)
                FB_Etoile_2.NeutralImage = Properties.Resources.Star_Neutral;
            else
                FB_Etoile_2.NeutralImage = Properties.Resources.Star_Disabled;
            if (Cotation >= 3)
                FB_Etoile_3.NeutralImage = Properties.Resources.Star_Neutral;
            else
                FB_Etoile_3.NeutralImage = Properties.Resources.Star_Disabled;
            if (Cotation >= 4)
                FB_Etoile_4.NeutralImage = Properties.Resources.Star_Neutral;
            else
                FB_Etoile_4.NeutralImage = Properties.Resources.Star_Disabled;
            if (Cotation == 5)
                FB_Etoile_5.NeutralImage = Properties.Resources.Star_Neutral;
            else
                FB_Etoile_5.NeutralImage = Properties.Resources.Star_Disabled;
            FB_Etoile_1.BackgroundImage = FB_Etoile_1.NeutralImage;
            FB_Etoile_2.BackgroundImage = FB_Etoile_2.NeutralImage;
            FB_Etoile_3.BackgroundImage = FB_Etoile_3.NeutralImage;
            FB_Etoile_4.BackgroundImage = FB_Etoile_4.NeutralImage;
            FB_Etoile_5.BackgroundImage = FB_Etoile_5.NeutralImage;
        }

        private void FB_Etoile_1_Click(object sender, EventArgs e)
        {
            Cotation = 1;
            RafraichirEtoiles();
        }

        private void FB_Etoile_2_Click(object sender, EventArgs e)
        {
            Cotation = 2;
            RafraichirEtoiles();
        }

        private void FB_Etoile_3_Click(object sender, EventArgs e)
        {
            Cotation = 3;
            RafraichirEtoiles();
        }

        private void FB_Etoile_4_Click(object sender, EventArgs e)
        {
            Cotation = 4;
            RafraichirEtoiles();
        }

        private void FB_Etoile_5_Click(object sender, EventArgs e)
        {
            Cotation = 5;
            RafraichirEtoiles();
        }

        private void PBX_Image_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void PBX_Image_DragDrop(object sender, DragEventArgs e)
        {
            int X = this.PointToClient(new Point(e.X, e.Y)).X;
            int Y = this.PointToClient(new Point(e.X, e.Y)).Y;
            if (X >= PBX_Image.Location.X && X <= PBX_Image.Location.X + PBX_Image.Width && Y >= PBX_Image.Location.Y && Y <= PBX_Image.Location.Y + PBX_Image.Height)
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                PBX_Image.BackgroundImage = Image.FromFile(files[0]);
            }
        }
    }
}
