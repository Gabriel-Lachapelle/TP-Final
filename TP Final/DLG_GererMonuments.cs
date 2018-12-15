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
    public partial class DLG_GererMonuments : Form
    {
        public string NomCircuit;
        public OracleConnection Connexion;
        int IDCircuit;
        public DLG_GererMonuments()
        {
            InitializeComponent();
        }

        private void DLG_GererMonuments_Load(object sender, EventArgs e)
        {
            TBX_NomCircuit.Text = NomCircuit;
            try
            {
                string SQL = "select * from MonumentsCircuit where NomCircuit = '" + NomCircuit + "' order by Ordre";
                OracleCommand OracleCMD = new OracleCommand(SQL, Connexion);
                OracleDataReader OracleRead = OracleCMD.ExecuteReader();

                while (OracleRead.Read())
                {
                    LBX_MonumentsCircuit.Items.Add(OracleRead.GetString(0));
                }
                OracleRead.Close();

                SQL = "select NomMonument from Monuments";
                OracleCMD = new OracleCommand(SQL, Connexion);
                OracleRead = OracleCMD.ExecuteReader();

                while (OracleRead.Read())
                {
                    if (!LBX_MonumentsCircuit.Items.Contains(OracleRead.GetString(0)))
                    {
                        LBX_TousMonuments.Items.Add(OracleRead.GetString(0));
                    }
                }
                OracleRead.Close();

                SQL = "select NumCircuit from Circuits where NomCircuit = '" + NomCircuit + "'";
                OracleCMD = new OracleCommand(SQL, Connexion);
                OracleRead = OracleCMD.ExecuteReader();
                OracleRead.Read();
                IDCircuit = OracleRead.GetInt32(0);
                OracleRead.Close();
            }
            catch (Exception SQL)
            {
                MessageBox.Show(SQL.Message);
            }
        }

        private void LBX_TousMonuments_SelectedIndexChanged(object sender, EventArgs e)
        {
            FB_Ajouter.Enabled = LBX_TousMonuments.SelectedIndex >= 0;
        }

        private void LBX_MonumentsCircuit_SelectedIndexChanged(object sender, EventArgs e)
        {
            FB_Retirer.Enabled = LBX_MonumentsCircuit.SelectedIndex >= 0;
        }

        private void FB_Retirer_Click(object sender, EventArgs e)
        {
            try
            {
                //Obtenir le NumeroMonument du Monument choisi:
                int NumMonument;
                string SQL = "select NumMonument from Monuments where NomMonument ='" + LBX_MonumentsCircuit.SelectedItem.ToString() + "'";
                OracleCommand OracleCMD = new OracleCommand(SQL, Connexion);
                OracleDataReader OracleReader = OracleCMD.ExecuteReader();
                OracleReader.Read();
                NumMonument = OracleReader.GetInt32(0);
                OracleReader.Close();

                //Supprimer ce monument de la liste:
                SQL = "delete from ListeMonuments where NumCircuit = " + IDCircuit + " and NumMonument = " + NumMonument;
                OracleCMD = new OracleCommand(SQL, Connexion);
                OracleCMD.ExecuteNonQuery();
            }
            catch (Exception SQL)
            {
                MessageBox.Show(SQL.Message);
            }
            LBX_TousMonuments.Items.Add(LBX_MonumentsCircuit.SelectedItem.ToString());
            LBX_MonumentsCircuit.Items.RemoveAt(LBX_MonumentsCircuit.SelectedIndex);
        }

        private void FB_Ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                //Obtenir le NumeroMonument du Monument choisi:
                int NumMonument;
                string SQL = "select NumMonument from Monuments where NomMonument ='" + LBX_TousMonuments.SelectedItem.ToString() + "'";
                OracleCommand OracleCMD = new OracleCommand(SQL, Connexion);
                OracleDataReader OracleReader = OracleCMD.ExecuteReader();
                OracleReader.Read();
                NumMonument = OracleReader.GetInt32(0);
                OracleReader.Close();

                int Index = LBX_MonumentsCircuit.Items.Count + 1;

                //Ajouter le monument à la liste:
                SQL = "insert into ListeMonuments values (" + IDCircuit + ", " + NumMonument + ", " + Index + ")";
                OracleCMD = new OracleCommand(SQL, Connexion);
                OracleCMD.ExecuteNonQuery();
            }
            catch (Exception SQL)
            {
                MessageBox.Show(SQL.Message);
            }
            LBX_MonumentsCircuit.Items.Add(LBX_TousMonuments.SelectedItem.ToString());
            LBX_TousMonuments.Items.RemoveAt(LBX_TousMonuments.SelectedIndex);
        }

        private void BTN_Retour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
