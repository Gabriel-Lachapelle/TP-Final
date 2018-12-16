using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Final
{
    public partial class DLG_Aide : Form
    {
        public DLG_Aide()
        {
            InitializeComponent();

            RTBX_Aide.Clear();
            RTBX_Aide.SelectedText = "Ici sera présenté les fonctionnalités de l'application:\n\n";
            RTBX_Aide.SelectedText = "Pour la fenêtre principale de l'application, vous avez plusieurs options envers les circuits:\n\n";
            RTBX_Aide.SelectedText = "- Ajouter un circuit:\n";
            RTBX_Aide.SelectionIndent = 10;
            RTBX_Aide.SelectedText = "Il vous sera demandé de remplir les information du circuit tel que: Nom, Prix, Durée, etc.\nNotez que pour ajouter des monuments à un circuit il vous faudra utiliser l'engrenage qui sera expliqué plus bas.\n\n";
            RTBX_Aide.SelectionIndent = 0;
            RTBX_Aide.SelectedText = "- Modifier un circuit:\n";
            RTBX_Aide.SelectionIndent = 10;
            RTBX_Aide.SelectedText = "Vous pouvez changer tous les détails liés au circuit seléctionné.\nNotez encore une fois que pour modifier les monuments du circuit cela ce fait par le même contrôle que mentionné plus tôt.\n\n";
            RTBX_Aide.SelectionIndent = 0;
            RTBX_Aide.SelectedText = "- Supprimer un circuit:\n";
            RTBX_Aide.SelectionIndent = 10;
            RTBX_Aide.SelectedText = "Supprimer le circuit sélectionné.\n\n";
            RTBX_Aide.SelectionIndent = 0;
            RTBX_Aide.SelectedText = "- Information du circuit:\n";
            RTBX_Aide.SelectionIndent = 10;
            RTBX_Aide.SelectedText = "Cette option vous permet de voir les monuments en détails du circuit sélectionné.ils sont aussi arrangés en ordre de passage.\n\n";
            RTBX_Aide.SelectionIndent = 0;
            RTBX_Aide.SelectedText = "-Gerer les monuments du circuit:\n";
            RTBX_Aide.SelectionIndent = 10;
            RTBX_Aide.SelectedText = "Cette option permet d'ajouter ou de retirer les monuments du circuit sélectionné.étant donné qu'un Monument ne peut être vu qu'une seule fois par circuit, il n'est pas possible d'avoir des doublons. De plus, l'ordre de passage est l'ordre de la liste.\n\n";
            RTBX_Aide.SelectionIndent = 0;
            RTBX_Aide.SelectedText = "- Ajouter un monument:\n";
            RTBX_Aide.SelectionIndent = 10;
            RTBX_Aide.SelectedText = "Vous pouvez par cette option ajouter un monument, il vous sera demandé d'entrer les détails de celui-ci, de le coter (1 à 5 étoiles) ainsi que de donner une image représentative.\n\n";
            RTBX_Aide.SelectionIndent = 0;
            RTBX_Aide.SelectedText = "- Recherche des circuits:\n";
            RTBX_Aide.SelectionIndent = 10;
            RTBX_Aide.SelectedText = "La recherche des circuits vous donne plusieurs options pour trouver le cicuit.\nTous les circuits affiche tous les circuits selon leur cotation (La somme des étoiles des monuments qui en font parti)\nMeilleur circuit affiche en ordre les circuits les mieux cotés selon des monuments de 3 étoiles et plus ayant le monument sélectionné.\nLes autres options sont assez claires par leur nom, sacher que vous pouvez combiner les 3 dernières options.\n\n";
            RTBX_Aide.SelectionIndent = 0;
            RTBX_Aide.SelectedText = "- Voir tous les monuments:\n";
            RTBX_Aide.SelectionIndent = 10;
            RTBX_Aide.SelectedText = "Ce bouton vous affichera tous les monuments et vous donnera la possibilité de voir dans quels circuits il apparaît ainsi que l'ordre dans lequel il est visité.";
        }

        private void Sauvegarder()
        {
            Properties.Settings.Default.DLG_Aide_Pref = true;
            Properties.Settings.Default.DLG_Aide_Position = Location;
            Properties.Settings.Default.DLG_Aide_Taille = Size;
            Properties.Settings.Default.Save();
        }
        private void Charger()
        {
            if (Properties.Settings.Default.DLG_Aide_Pref)
            {
                Location = Properties.Settings.Default.DLG_Aide_Position;
                Size = Properties.Settings.Default.DLG_Aide_Taille;
            }
        }

        private void DLG_Aide_Load(object sender, EventArgs e)
        {
            Charger();
        }

        private void DLG_Aide_FormClosing(object sender, FormClosingEventArgs e)
        {
            Sauvegarder();
        }
    }
}
