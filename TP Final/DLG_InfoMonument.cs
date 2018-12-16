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
    public partial class DLG_InfoMonument : Form
    {
        public OracleConnection Connexion;
        public DLG_InfoMonument()
        {
            InitializeComponent();
        }

        private void DLG_InfoMonument_Load(object sender, EventArgs e)
        {
            string Etoile = "★";
            try
            {
                string SQL = "select NomMonument, NombreEtoiles from Monuments order by NombreEtoiles desc";
                OracleCommand OracleCMD = new OracleCommand(SQL, Connexion);
                OracleDataReader OracleReader = OracleCMD.ExecuteReader();

                while (OracleReader.Read())
                {
                    string Cotation = "";
                    for (int i = 0; i < OracleReader.GetInt32(1); i++)
                        Cotation += Etoile;
                    DGV_Monuments.Rows.Add(OracleReader.GetString(0), Cotation);
                }
                OracleReader.Close();
            }
            catch (Exception SQL)
            {
                MessageBox.Show(SQL.Message);
            }
        }

        private void DGV_Monuments_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                string SQL = "select NomCircuit from RechercheCircuit where NomMonument = '" + DGV_Monuments.SelectedRows[0].Cells["Nom"].Value.ToString() + "' group by NomCircuit";
                OracleCommand OracleCMD = new OracleCommand(SQL, Connexion);
                OracleDataReader OracleReader = OracleCMD.ExecuteReader();
                LBX_Circuits.Items.Clear();
                while (OracleReader.Read())
                {
                    LBX_Circuits.Items.Add(OracleReader.GetString(0));
                }
                OracleReader.Close();
            }
            catch (Exception SQL)
            {
                MessageBox.Show(SQL.Message);
            }
        }

        private void LBX_Circuits_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LBX_Circuits.SelectedIndex >= 0)
            {
                try
                {
                    string IDC, IDM;

                    //ID du Circuit
                    string SQL = "select NumCircuit from Circuits where NomCircuit ='" + LBX_Circuits.SelectedItem.ToString() + "'";
                    OracleCommand OracleCMD = new OracleCommand(SQL, Connexion);
                    OracleDataReader OracleReader = OracleCMD.ExecuteReader();
                    OracleReader.Read();
                    IDC = OracleReader.GetInt32(0).ToString();
                    OracleReader.Close();

                    //ID du Monument
                    SQL = "select NumMonument from Monuments where NomMonument ='" + DGV_Monuments.SelectedRows[0].Cells["Nom"].Value.ToString() + "'";
                    OracleCMD = new OracleCommand(SQL, Connexion);
                    OracleReader = OracleCMD.ExecuteReader();
                    OracleReader.Read();
                    IDM = OracleReader.GetInt32(0).ToString();
                    OracleReader.Close();

                    //Position
                    SQL = "select Ordre from ListeMonuments where NumMonument = " + IDM + " and NumCircuit = " + IDC;
                    OracleCMD = new OracleCommand(SQL, Connexion);
                    OracleReader = OracleCMD.ExecuteReader();
                    OracleReader.Read();
                    TBX_Position.Text = OracleReader.GetInt32(0).ToString();
                    OracleReader.Close();
                }
                catch (Exception SQL)
                {
                    MessageBox.Show(SQL.Message);
                }
            }
        }
    }
}
