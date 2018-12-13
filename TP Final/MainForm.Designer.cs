namespace TP_Final
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.GBX_Circuits = new System.Windows.Forms.GroupBox();
            this.CBX_Tous = new System.Windows.Forms.CheckBox();
            this.CBX_Monument = new System.Windows.Forms.CheckBox();
            this.TBX_Monument = new System.Windows.Forms.TextBox();
            this.CBX_Prix = new System.Windows.Forms.CheckBox();
            this.TBX_Prix = new System.Windows.Forms.TextBox();
            this.TBX_VilleDepart = new System.Windows.Forms.TextBox();
            this.CBX_VilleDepart = new System.Windows.Forms.CheckBox();
            this.BTN_Rechercher = new System.Windows.Forms.Button();
            this.LBL_Recherche = new System.Windows.Forms.Label();
            this.DGV_Circuit = new System.Windows.Forms.DataGridView();
            this.NomCircuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VilleDepart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VilleArrivee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrixCircuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GBX_Monuments = new System.Windows.Forms.GroupBox();
            this.RB_Meilleur = new System.Windows.Forms.RadioButton();
            this.RB_Cotation = new System.Windows.Forms.RadioButton();
            this.LBL_Ordre = new System.Windows.Forms.Label();
            this.DGV_Monument = new System.Windows.Forms.DataGridView();
            this.NomMonument = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrixMonument = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreEtoiles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.TSMI_Connexion = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Connexion_Connecter = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Connexion_Deconnecter = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Circuit = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Circuits_Ajout = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Circuits_Modif = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Circuits_AfficherMonuments = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Monument = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Monument_Ordre = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Monument_Cotation = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Monument_Meilleur = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Aide = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_APropos = new System.Windows.Forms.ToolStripMenuItem();
            this.FB_Monument_Supp = new Calculator.FlashButton();
            this.FB_Monument_Ajout = new Calculator.FlashButton();
            this.FB_Circuit_Show = new Calculator.FlashButton();
            this.FB_Circuit_Modif = new Calculator.FlashButton();
            this.FB_Circuit_Ajout = new Calculator.FlashButton();
            this.GBX_Circuits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Circuit)).BeginInit();
            this.GBX_Monuments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Monument)).BeginInit();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBX_Circuits
            // 
            this.GBX_Circuits.Controls.Add(this.CBX_Tous);
            this.GBX_Circuits.Controls.Add(this.CBX_Monument);
            this.GBX_Circuits.Controls.Add(this.TBX_Monument);
            this.GBX_Circuits.Controls.Add(this.CBX_Prix);
            this.GBX_Circuits.Controls.Add(this.TBX_Prix);
            this.GBX_Circuits.Controls.Add(this.TBX_VilleDepart);
            this.GBX_Circuits.Controls.Add(this.CBX_VilleDepart);
            this.GBX_Circuits.Controls.Add(this.FB_Circuit_Show);
            this.GBX_Circuits.Controls.Add(this.BTN_Rechercher);
            this.GBX_Circuits.Controls.Add(this.LBL_Recherche);
            this.GBX_Circuits.Controls.Add(this.DGV_Circuit);
            this.GBX_Circuits.Controls.Add(this.FB_Circuit_Modif);
            this.GBX_Circuits.Controls.Add(this.FB_Circuit_Ajout);
            this.GBX_Circuits.Location = new System.Drawing.Point(12, 27);
            this.GBX_Circuits.Name = "GBX_Circuits";
            this.GBX_Circuits.Size = new System.Drawing.Size(501, 292);
            this.GBX_Circuits.TabIndex = 1;
            this.GBX_Circuits.TabStop = false;
            this.GBX_Circuits.Text = "Circuits";
            // 
            // CBX_Tous
            // 
            this.CBX_Tous.AutoSize = true;
            this.CBX_Tous.Enabled = false;
            this.CBX_Tous.Location = new System.Drawing.Point(10, 188);
            this.CBX_Tous.Name = "CBX_Tous";
            this.CBX_Tous.Size = new System.Drawing.Size(102, 17);
            this.CBX_Tous.TabIndex = 17;
            this.CBX_Tous.Text = "Tous les circuits";
            this.CBX_Tous.UseVisualStyleBackColor = true;
            this.CBX_Tous.CheckedChanged += new System.EventHandler(this.CBX_Tous_CheckedChanged);
            // 
            // CBX_Monument
            // 
            this.CBX_Monument.AutoSize = true;
            this.CBX_Monument.Enabled = false;
            this.CBX_Monument.Location = new System.Drawing.Point(10, 257);
            this.CBX_Monument.Name = "CBX_Monument";
            this.CBX_Monument.Size = new System.Drawing.Size(76, 17);
            this.CBX_Monument.TabIndex = 16;
            this.CBX_Monument.Text = "Monument";
            this.CBX_Monument.UseVisualStyleBackColor = true;
            this.CBX_Monument.CheckedChanged += new System.EventHandler(this.CBX_Other_CheckedChanged);
            // 
            // TBX_Monument
            // 
            this.TBX_Monument.Enabled = false;
            this.TBX_Monument.Location = new System.Drawing.Point(109, 255);
            this.TBX_Monument.Name = "TBX_Monument";
            this.TBX_Monument.Size = new System.Drawing.Size(151, 20);
            this.TBX_Monument.TabIndex = 12;
            // 
            // CBX_Prix
            // 
            this.CBX_Prix.AutoSize = true;
            this.CBX_Prix.Enabled = false;
            this.CBX_Prix.Location = new System.Drawing.Point(10, 234);
            this.CBX_Prix.Name = "CBX_Prix";
            this.CBX_Prix.Size = new System.Drawing.Size(92, 17);
            this.CBX_Prix.TabIndex = 15;
            this.CBX_Prix.Text = "Prix inférieur à";
            this.CBX_Prix.UseVisualStyleBackColor = true;
            this.CBX_Prix.CheckedChanged += new System.EventHandler(this.CBX_Other_CheckedChanged);
            // 
            // TBX_Prix
            // 
            this.TBX_Prix.Enabled = false;
            this.TBX_Prix.Location = new System.Drawing.Point(109, 232);
            this.TBX_Prix.Name = "TBX_Prix";
            this.TBX_Prix.Size = new System.Drawing.Size(151, 20);
            this.TBX_Prix.TabIndex = 11;
            // 
            // TBX_VilleDepart
            // 
            this.TBX_VilleDepart.Enabled = false;
            this.TBX_VilleDepart.Location = new System.Drawing.Point(109, 209);
            this.TBX_VilleDepart.Name = "TBX_VilleDepart";
            this.TBX_VilleDepart.Size = new System.Drawing.Size(151, 20);
            this.TBX_VilleDepart.TabIndex = 10;
            // 
            // CBX_VilleDepart
            // 
            this.CBX_VilleDepart.AutoSize = true;
            this.CBX_VilleDepart.Enabled = false;
            this.CBX_VilleDepart.Location = new System.Drawing.Point(10, 211);
            this.CBX_VilleDepart.Name = "CBX_VilleDepart";
            this.CBX_VilleDepart.Size = new System.Drawing.Size(93, 17);
            this.CBX_VilleDepart.TabIndex = 14;
            this.CBX_VilleDepart.Text = "Ville de départ";
            this.CBX_VilleDepart.UseVisualStyleBackColor = true;
            this.CBX_VilleDepart.CheckedChanged += new System.EventHandler(this.CBX_Other_CheckedChanged);
            // 
            // BTN_Rechercher
            // 
            this.BTN_Rechercher.Enabled = false;
            this.BTN_Rechercher.Location = new System.Drawing.Point(416, 253);
            this.BTN_Rechercher.Name = "BTN_Rechercher";
            this.BTN_Rechercher.Size = new System.Drawing.Size(75, 23);
            this.BTN_Rechercher.TabIndex = 9;
            this.BTN_Rechercher.Text = "Rechercher";
            this.BTN_Rechercher.UseVisualStyleBackColor = true;
            // 
            // LBL_Recherche
            // 
            this.LBL_Recherche.AutoSize = true;
            this.LBL_Recherche.Location = new System.Drawing.Point(7, 172);
            this.LBL_Recherche.Name = "LBL_Recherche";
            this.LBL_Recherche.Size = new System.Drawing.Size(63, 13);
            this.LBL_Recherche.TabIndex = 4;
            this.LBL_Recherche.Text = "Recherche:";
            // 
            // DGV_Circuit
            // 
            this.DGV_Circuit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Circuit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomCircuit,
            this.VilleDepart,
            this.VilleArrivee,
            this.PrixCircuit});
            this.DGV_Circuit.Enabled = false;
            this.DGV_Circuit.Location = new System.Drawing.Point(6, 19);
            this.DGV_Circuit.Name = "DGV_Circuit";
            this.DGV_Circuit.Size = new System.Drawing.Size(443, 146);
            this.DGV_Circuit.TabIndex = 3;
            // 
            // NomCircuit
            // 
            this.NomCircuit.HeaderText = "Nom du circuit";
            this.NomCircuit.Name = "NomCircuit";
            // 
            // VilleDepart
            // 
            this.VilleDepart.HeaderText = "Ville de départ";
            this.VilleDepart.Name = "VilleDepart";
            // 
            // VilleArrivee
            // 
            this.VilleArrivee.HeaderText = "Ville d\'arrivée";
            this.VilleArrivee.Name = "VilleArrivee";
            // 
            // PrixCircuit
            // 
            this.PrixCircuit.HeaderText = "Prix";
            this.PrixCircuit.Name = "PrixCircuit";
            // 
            // GBX_Monuments
            // 
            this.GBX_Monuments.Controls.Add(this.RB_Meilleur);
            this.GBX_Monuments.Controls.Add(this.RB_Cotation);
            this.GBX_Monuments.Controls.Add(this.LBL_Ordre);
            this.GBX_Monuments.Controls.Add(this.DGV_Monument);
            this.GBX_Monuments.Controls.Add(this.FB_Monument_Supp);
            this.GBX_Monuments.Controls.Add(this.FB_Monument_Ajout);
            this.GBX_Monuments.Location = new System.Drawing.Point(12, 325);
            this.GBX_Monuments.Name = "GBX_Monuments";
            this.GBX_Monuments.Size = new System.Drawing.Size(501, 178);
            this.GBX_Monuments.TabIndex = 2;
            this.GBX_Monuments.TabStop = false;
            this.GBX_Monuments.Text = "Monuments";
            // 
            // RB_Meilleur
            // 
            this.RB_Meilleur.AutoSize = true;
            this.RB_Meilleur.Enabled = false;
            this.RB_Meilleur.Location = new System.Drawing.Point(357, 152);
            this.RB_Meilleur.Name = "RB_Meilleur";
            this.RB_Meilleur.Size = new System.Drawing.Size(93, 17);
            this.RB_Meilleur.TabIndex = 7;
            this.RB_Meilleur.TabStop = true;
            this.RB_Meilleur.Text = "Meilleur Circuit";
            this.RB_Meilleur.UseVisualStyleBackColor = true;
            // 
            // RB_Cotation
            // 
            this.RB_Cotation.AutoSize = true;
            this.RB_Cotation.Enabled = false;
            this.RB_Cotation.Location = new System.Drawing.Point(357, 129);
            this.RB_Cotation.Name = "RB_Cotation";
            this.RB_Cotation.Size = new System.Drawing.Size(104, 17);
            this.RB_Cotation.TabIndex = 6;
            this.RB_Cotation.TabStop = true;
            this.RB_Cotation.Text = "Selon la cotation";
            this.RB_Cotation.UseVisualStyleBackColor = true;
            // 
            // LBL_Ordre
            // 
            this.LBL_Ordre.AutoSize = true;
            this.LBL_Ordre.Location = new System.Drawing.Point(354, 113);
            this.LBL_Ordre.Name = "LBL_Ordre";
            this.LBL_Ordre.Size = new System.Drawing.Size(54, 13);
            this.LBL_Ordre.TabIndex = 5;
            this.LBL_Ordre.Text = "Ordonner:";
            // 
            // DGV_Monument
            // 
            this.DGV_Monument.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Monument.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomMonument,
            this.PrixMonument,
            this.NombreEtoiles});
            this.DGV_Monument.Enabled = false;
            this.DGV_Monument.Location = new System.Drawing.Point(6, 19);
            this.DGV_Monument.Name = "DGV_Monument";
            this.DGV_Monument.Size = new System.Drawing.Size(345, 150);
            this.DGV_Monument.TabIndex = 2;
            // 
            // NomMonument
            // 
            this.NomMonument.HeaderText = "Nom du monument";
            this.NomMonument.Name = "NomMonument";
            // 
            // PrixMonument
            // 
            this.PrixMonument.HeaderText = "Prix";
            this.PrixMonument.Name = "PrixMonument";
            // 
            // NombreEtoiles
            // 
            this.NombreEtoiles.HeaderText = "Cotation";
            this.NombreEtoiles.Name = "NombreEtoiles";
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Connexion,
            this.TSMI_Circuit,
            this.TSMI_Monument,
            this.TSMI_Aide,
            this.TSMI_APropos});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(525, 24);
            this.MenuStrip.TabIndex = 3;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // TSMI_Connexion
            // 
            this.TSMI_Connexion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MI_Connexion_Connecter,
            this.MI_Connexion_Deconnecter});
            this.TSMI_Connexion.Name = "TSMI_Connexion";
            this.TSMI_Connexion.Size = new System.Drawing.Size(76, 20);
            this.TSMI_Connexion.Text = "Connexion";
            // 
            // MI_Connexion_Connecter
            // 
            this.MI_Connexion_Connecter.Name = "MI_Connexion_Connecter";
            this.MI_Connexion_Connecter.Size = new System.Drawing.Size(180, 22);
            this.MI_Connexion_Connecter.Text = "Se connecter";
            this.MI_Connexion_Connecter.Click += new System.EventHandler(this.MI_Connexion_Connecter_Click);
            // 
            // MI_Connexion_Deconnecter
            // 
            this.MI_Connexion_Deconnecter.Enabled = false;
            this.MI_Connexion_Deconnecter.Name = "MI_Connexion_Deconnecter";
            this.MI_Connexion_Deconnecter.Size = new System.Drawing.Size(180, 22);
            this.MI_Connexion_Deconnecter.Text = "Se déconnecter";
            this.MI_Connexion_Deconnecter.Click += new System.EventHandler(this.MI_Connexion_Deconnecter_Click);
            // 
            // TSMI_Circuit
            // 
            this.TSMI_Circuit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MI_Circuits_Ajout,
            this.MI_Circuits_Modif,
            this.MI_Circuits_AfficherMonuments});
            this.TSMI_Circuit.Enabled = false;
            this.TSMI_Circuit.Name = "TSMI_Circuit";
            this.TSMI_Circuit.Size = new System.Drawing.Size(59, 20);
            this.TSMI_Circuit.Text = "Circuits";
            // 
            // MI_Circuits_Ajout
            // 
            this.MI_Circuits_Ajout.Name = "MI_Circuits_Ajout";
            this.MI_Circuits_Ajout.Size = new System.Drawing.Size(201, 22);
            this.MI_Circuits_Ajout.Text = "Ajouter";
            // 
            // MI_Circuits_Modif
            // 
            this.MI_Circuits_Modif.Name = "MI_Circuits_Modif";
            this.MI_Circuits_Modif.Size = new System.Drawing.Size(201, 22);
            this.MI_Circuits_Modif.Text = "Modifier";
            // 
            // MI_Circuits_AfficherMonuments
            // 
            this.MI_Circuits_AfficherMonuments.Name = "MI_Circuits_AfficherMonuments";
            this.MI_Circuits_AfficherMonuments.Size = new System.Drawing.Size(201, 22);
            this.MI_Circuits_AfficherMonuments.Text = "Afficher les monuments";
            // 
            // TSMI_Monument
            // 
            this.TSMI_Monument.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MI_Monument_Ordre});
            this.TSMI_Monument.Enabled = false;
            this.TSMI_Monument.Name = "TSMI_Monument";
            this.TSMI_Monument.Size = new System.Drawing.Size(84, 20);
            this.TSMI_Monument.Text = "Monuments";
            // 
            // MI_Monument_Ordre
            // 
            this.MI_Monument_Ordre.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MI_Monument_Cotation,
            this.MI_Monument_Meilleur});
            this.MI_Monument_Ordre.Name = "MI_Monument_Ordre";
            this.MI_Monument_Ordre.Size = new System.Drawing.Size(159, 22);
            this.MI_Monument_Ordre.Text = "Ordonner selon:";
            // 
            // MI_Monument_Cotation
            // 
            this.MI_Monument_Cotation.Name = "MI_Monument_Cotation";
            this.MI_Monument_Cotation.Size = new System.Drawing.Size(120, 22);
            this.MI_Monument_Cotation.Text = "Cotation";
            // 
            // MI_Monument_Meilleur
            // 
            this.MI_Monument_Meilleur.Name = "MI_Monument_Meilleur";
            this.MI_Monument_Meilleur.Size = new System.Drawing.Size(120, 22);
            this.MI_Monument_Meilleur.Text = "Meilleur";
            // 
            // TSMI_Aide
            // 
            this.TSMI_Aide.Name = "TSMI_Aide";
            this.TSMI_Aide.Size = new System.Drawing.Size(43, 20);
            this.TSMI_Aide.Text = "Aide";
            // 
            // TSMI_APropos
            // 
            this.TSMI_APropos.Name = "TSMI_APropos";
            this.TSMI_APropos.Size = new System.Drawing.Size(67, 20);
            this.TSMI_APropos.Text = "À propos";
            // 
            // FB_Monument_Supp
            // 
            this.FB_Monument_Supp.BackgroundImage = global::TP_Final.Properties.Resources.Delete_Neutral;
            this.FB_Monument_Supp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FB_Monument_Supp.ClickedImage = global::TP_Final.Properties.Resources.Delete_Clicked;
            this.FB_Monument_Supp.DisabledImage = global::TP_Final.Properties.Resources.Delete_Disabled;
            this.FB_Monument_Supp.Enabled = false;
            this.FB_Monument_Supp.Image = ((System.Drawing.Image)(resources.GetObject("FB_Monument_Supp.Image")));
            this.FB_Monument_Supp.Location = new System.Drawing.Point(357, 61);
            this.FB_Monument_Supp.Name = "FB_Monument_Supp";
            this.FB_Monument_Supp.NeutralImage = global::TP_Final.Properties.Resources.Delete_Neutral;
            this.FB_Monument_Supp.OverImage = global::TP_Final.Properties.Resources.Delete_Hover;
            this.FB_Monument_Supp.Size = new System.Drawing.Size(36, 36);
            this.FB_Monument_Supp.TabIndex = 1;
            this.FB_Monument_Supp.Text = "Supprimer un monument";
            this.FB_Monument_Supp.UseVisualStyleBackColor = true;
            this.FB_Monument_Supp.Click += new System.EventHandler(this.FB_Monument_Supp_Click);
            // 
            // FB_Monument_Ajout
            // 
            this.FB_Monument_Ajout.BackgroundImage = global::TP_Final.Properties.Resources.Add_Neutral;
            this.FB_Monument_Ajout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FB_Monument_Ajout.ClickedImage = global::TP_Final.Properties.Resources.Add_Clicked;
            this.FB_Monument_Ajout.DisabledImage = global::TP_Final.Properties.Resources.Add_Disabled;
            this.FB_Monument_Ajout.Enabled = false;
            this.FB_Monument_Ajout.Image = ((System.Drawing.Image)(resources.GetObject("FB_Monument_Ajout.Image")));
            this.FB_Monument_Ajout.Location = new System.Drawing.Point(357, 19);
            this.FB_Monument_Ajout.Name = "FB_Monument_Ajout";
            this.FB_Monument_Ajout.NeutralImage = global::TP_Final.Properties.Resources.Add_Neutral;
            this.FB_Monument_Ajout.OverImage = global::TP_Final.Properties.Resources.Add_Hover;
            this.FB_Monument_Ajout.Size = new System.Drawing.Size(36, 36);
            this.FB_Monument_Ajout.TabIndex = 0;
            this.FB_Monument_Ajout.Text = "Ajouter un monument";
            this.FB_Monument_Ajout.UseVisualStyleBackColor = true;
            this.FB_Monument_Ajout.Click += new System.EventHandler(this.FB_Monument_Ajout_Click);
            // 
            // FB_Circuit_Show
            // 
            this.FB_Circuit_Show.BackgroundImage = global::TP_Final.Properties.Resources.Show_Neutral;
            this.FB_Circuit_Show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FB_Circuit_Show.ClickedImage = global::TP_Final.Properties.Resources.Show_Clicked;
            this.FB_Circuit_Show.DisabledImage = global::TP_Final.Properties.Resources.Show_Disabled;
            this.FB_Circuit_Show.Enabled = false;
            this.FB_Circuit_Show.Image = ((System.Drawing.Image)(resources.GetObject("FB_Circuit_Show.Image")));
            this.FB_Circuit_Show.Location = new System.Drawing.Point(455, 129);
            this.FB_Circuit_Show.Name = "FB_Circuit_Show";
            this.FB_Circuit_Show.NeutralImage = global::TP_Final.Properties.Resources.Show_Neutral;
            this.FB_Circuit_Show.OverImage = global::TP_Final.Properties.Resources.Show_Hover;
            this.FB_Circuit_Show.Size = new System.Drawing.Size(36, 36);
            this.FB_Circuit_Show.TabIndex = 13;
            this.FB_Circuit_Show.Text = "Afficher les monuments du circuit";
            this.FB_Circuit_Show.UseVisualStyleBackColor = true;
            this.FB_Circuit_Show.Click += new System.EventHandler(this.FB_Circuit_Show_Click);
            // 
            // FB_Circuit_Modif
            // 
            this.FB_Circuit_Modif.BackgroundImage = global::TP_Final.Properties.Resources.Edit_Neutral;
            this.FB_Circuit_Modif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FB_Circuit_Modif.ClickedImage = global::TP_Final.Properties.Resources.Edit_Clicked;
            this.FB_Circuit_Modif.DisabledImage = global::TP_Final.Properties.Resources.Edit_Disabled;
            this.FB_Circuit_Modif.Enabled = false;
            this.FB_Circuit_Modif.Image = ((System.Drawing.Image)(resources.GetObject("FB_Circuit_Modif.Image")));
            this.FB_Circuit_Modif.Location = new System.Drawing.Point(455, 76);
            this.FB_Circuit_Modif.Name = "FB_Circuit_Modif";
            this.FB_Circuit_Modif.NeutralImage = global::TP_Final.Properties.Resources.Edit_Neutral;
            this.FB_Circuit_Modif.OverImage = global::TP_Final.Properties.Resources.Edit_Hover;
            this.FB_Circuit_Modif.Size = new System.Drawing.Size(36, 36);
            this.FB_Circuit_Modif.TabIndex = 1;
            this.FB_Circuit_Modif.Text = "Modifier le prix du circuit";
            this.FB_Circuit_Modif.UseVisualStyleBackColor = true;
            this.FB_Circuit_Modif.Click += new System.EventHandler(this.FB_Circuit_Modif_Click);
            // 
            // FB_Circuit_Ajout
            // 
            this.FB_Circuit_Ajout.BackgroundImage = global::TP_Final.Properties.Resources.Add_Neutral;
            this.FB_Circuit_Ajout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FB_Circuit_Ajout.ClickedImage = global::TP_Final.Properties.Resources.Add_Clicked;
            this.FB_Circuit_Ajout.DisabledImage = global::TP_Final.Properties.Resources.Add_Disabled;
            this.FB_Circuit_Ajout.Enabled = false;
            this.FB_Circuit_Ajout.Image = ((System.Drawing.Image)(resources.GetObject("FB_Circuit_Ajout.Image")));
            this.FB_Circuit_Ajout.Location = new System.Drawing.Point(455, 19);
            this.FB_Circuit_Ajout.Name = "FB_Circuit_Ajout";
            this.FB_Circuit_Ajout.NeutralImage = global::TP_Final.Properties.Resources.Add_Neutral;
            this.FB_Circuit_Ajout.OverImage = global::TP_Final.Properties.Resources.Add_Hover;
            this.FB_Circuit_Ajout.Size = new System.Drawing.Size(36, 36);
            this.FB_Circuit_Ajout.TabIndex = 0;
            this.FB_Circuit_Ajout.Text = "Ajouter un circuit";
            this.FB_Circuit_Ajout.UseVisualStyleBackColor = true;
            this.FB_Circuit_Ajout.Click += new System.EventHandler(this.FB_Circuit_Ajout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 530);
            this.Controls.Add(this.GBX_Monuments);
            this.Controls.Add(this.GBX_Circuits);
            this.Controls.Add(this.MenuStrip);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.GBX_Circuits.ResumeLayout(false);
            this.GBX_Circuits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Circuit)).EndInit();
            this.GBX_Monuments.ResumeLayout(false);
            this.GBX_Monuments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Monument)).EndInit();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Calculator.FlashButton FB_Circuit_Ajout;
        private System.Windows.Forms.GroupBox GBX_Circuits;
        private System.Windows.Forms.TextBox TBX_Monument;
        private System.Windows.Forms.TextBox TBX_Prix;
        private System.Windows.Forms.TextBox TBX_VilleDepart;
        private System.Windows.Forms.Button BTN_Rechercher;
        private System.Windows.Forms.Label LBL_Recherche;
        private System.Windows.Forms.DataGridView DGV_Circuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomCircuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn VilleDepart;
        private System.Windows.Forms.DataGridViewTextBoxColumn VilleArrivee;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrixCircuit;
        private Calculator.FlashButton FB_Circuit_Modif;
        private System.Windows.Forms.GroupBox GBX_Monuments;
        private System.Windows.Forms.RadioButton RB_Cotation;
        private System.Windows.Forms.Label LBL_Ordre;
        private System.Windows.Forms.DataGridView DGV_Monument;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomMonument;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrixMonument;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEtoiles;
        private Calculator.FlashButton FB_Monument_Supp;
        private Calculator.FlashButton FB_Monument_Ajout;
        private System.Windows.Forms.CheckBox CBX_Tous;
        private System.Windows.Forms.CheckBox CBX_Monument;
        private System.Windows.Forms.CheckBox CBX_Prix;
        private System.Windows.Forms.CheckBox CBX_VilleDepart;
        private Calculator.FlashButton FB_Circuit_Show;
        private System.Windows.Forms.RadioButton RB_Meilleur;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Connexion;
        private System.Windows.Forms.ToolStripMenuItem MI_Connexion_Connecter;
        private System.Windows.Forms.ToolStripMenuItem MI_Connexion_Deconnecter;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Circuit;
        private System.Windows.Forms.ToolStripMenuItem MI_Circuits_Ajout;
        private System.Windows.Forms.ToolStripMenuItem MI_Circuits_Modif;
        private System.Windows.Forms.ToolStripMenuItem MI_Circuits_AfficherMonuments;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Monument;
        private System.Windows.Forms.ToolStripMenuItem MI_Monument_Ordre;
        private System.Windows.Forms.ToolStripMenuItem MI_Monument_Cotation;
        private System.Windows.Forms.ToolStripMenuItem MI_Monument_Meilleur;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Aide;
        private System.Windows.Forms.ToolStripMenuItem TSMI_APropos;
    }
}

