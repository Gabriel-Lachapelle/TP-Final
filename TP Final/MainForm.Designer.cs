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
            this.GBX_Recherche = new System.Windows.Forms.GroupBox();
            this.COMBX_Monument = new System.Windows.Forms.ComboBox();
            this.COMBX_VilleDepart = new System.Windows.Forms.ComboBox();
            this.CBX_MeilleurCircuit = new System.Windows.Forms.ComboBox();
            this.BTN_TousMonuments = new System.Windows.Forms.Button();
            this.CBX_Meilleur = new System.Windows.Forms.CheckBox();
            this.CBX_Tous = new System.Windows.Forms.CheckBox();
            this.CBX_Monument = new System.Windows.Forms.CheckBox();
            this.CBX_Prix = new System.Windows.Forms.CheckBox();
            this.TBX_Prix = new System.Windows.Forms.TextBox();
            this.CBX_VilleDepart = new System.Windows.Forms.CheckBox();
            this.BTN_Rechercher = new System.Windows.Forms.Button();
            this.DGV_Circuit = new System.Windows.Forms.DataGridView();
            this.NomCircuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VilleDepart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VilleArrivee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrixCircuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.TSMI_Connexion = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Connexion_Connecter = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Connexion_Deconnecter = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Circuit = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Circuits_Ajout = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Circuits_Modif = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Circuit_Supp = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Circuits_Afficher = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Circuits_GererMonuments = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Monuments = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Monuments_Ajouter = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Monuments_Voir = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Aide = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_APropos = new System.Windows.Forms.ToolStripMenuItem();
            this.FB_AjoutMonument = new Calculator.FlashButton();
            this.FB_Gerer = new Calculator.FlashButton();
            this.FB_Circuit_Supp = new Calculator.FlashButton();
            this.FB_Circuit_Ajout = new Calculator.FlashButton();
            this.FB_Circuit_Modif = new Calculator.FlashButton();
            this.FB_Info = new Calculator.FlashButton();
            this.GBX_Recherche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Circuit)).BeginInit();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBX_Recherche
            // 
            this.GBX_Recherche.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBX_Recherche.Controls.Add(this.COMBX_Monument);
            this.GBX_Recherche.Controls.Add(this.COMBX_VilleDepart);
            this.GBX_Recherche.Controls.Add(this.CBX_MeilleurCircuit);
            this.GBX_Recherche.Controls.Add(this.BTN_TousMonuments);
            this.GBX_Recherche.Controls.Add(this.CBX_Meilleur);
            this.GBX_Recherche.Controls.Add(this.CBX_Tous);
            this.GBX_Recherche.Controls.Add(this.CBX_Monument);
            this.GBX_Recherche.Controls.Add(this.CBX_Prix);
            this.GBX_Recherche.Controls.Add(this.TBX_Prix);
            this.GBX_Recherche.Controls.Add(this.CBX_VilleDepart);
            this.GBX_Recherche.Controls.Add(this.BTN_Rechercher);
            this.GBX_Recherche.Location = new System.Drawing.Point(13, 318);
            this.GBX_Recherche.Margin = new System.Windows.Forms.Padding(4);
            this.GBX_Recherche.Name = "GBX_Recherche";
            this.GBX_Recherche.Padding = new System.Windows.Forms.Padding(4);
            this.GBX_Recherche.Size = new System.Drawing.Size(494, 175);
            this.GBX_Recherche.TabIndex = 1;
            this.GBX_Recherche.TabStop = false;
            this.GBX_Recherche.Text = "Recherche";
            // 
            // COMBX_Monument
            // 
            this.COMBX_Monument.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.COMBX_Monument.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMBX_Monument.Enabled = false;
            this.COMBX_Monument.FormattingEnabled = true;
            this.COMBX_Monument.Location = new System.Drawing.Point(136, 140);
            this.COMBX_Monument.MaximumSize = new System.Drawing.Size(250, 0);
            this.COMBX_Monument.Name = "COMBX_Monument";
            this.COMBX_Monument.Size = new System.Drawing.Size(141, 24);
            this.COMBX_Monument.TabIndex = 19;
            this.COMBX_Monument.SelectedIndexChanged += new System.EventHandler(this.COMBX_Monument_SelectedIndexChanged);
            // 
            // COMBX_VilleDepart
            // 
            this.COMBX_VilleDepart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.COMBX_VilleDepart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMBX_VilleDepart.Enabled = false;
            this.COMBX_VilleDepart.FormattingEnabled = true;
            this.COMBX_VilleDepart.Location = new System.Drawing.Point(136, 82);
            this.COMBX_VilleDepart.MaximumSize = new System.Drawing.Size(250, 0);
            this.COMBX_VilleDepart.Name = "COMBX_VilleDepart";
            this.COMBX_VilleDepart.Size = new System.Drawing.Size(141, 24);
            this.COMBX_VilleDepart.TabIndex = 18;
            this.COMBX_VilleDepart.SelectedIndexChanged += new System.EventHandler(this.COMBX_VilleDepart_SelectedIndexChanged);
            // 
            // CBX_MeilleurCircuit
            // 
            this.CBX_MeilleurCircuit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CBX_MeilleurCircuit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBX_MeilleurCircuit.Enabled = false;
            this.CBX_MeilleurCircuit.FormattingEnabled = true;
            this.CBX_MeilleurCircuit.Location = new System.Drawing.Point(136, 52);
            this.CBX_MeilleurCircuit.MaximumSize = new System.Drawing.Size(250, 0);
            this.CBX_MeilleurCircuit.Name = "CBX_MeilleurCircuit";
            this.CBX_MeilleurCircuit.Size = new System.Drawing.Size(141, 24);
            this.CBX_MeilleurCircuit.TabIndex = 12;
            this.CBX_MeilleurCircuit.SelectedIndexChanged += new System.EventHandler(this.CBX_MeilleurCircuit_SelectedIndexChanged);
            // 
            // BTN_TousMonuments
            // 
            this.BTN_TousMonuments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_TousMonuments.Enabled = false;
            this.BTN_TousMonuments.Location = new System.Drawing.Point(320, 19);
            this.BTN_TousMonuments.Name = "BTN_TousMonuments";
            this.BTN_TousMonuments.Size = new System.Drawing.Size(167, 23);
            this.BTN_TousMonuments.TabIndex = 16;
            this.BTN_TousMonuments.Text = "Voir tous les monuments";
            this.BTN_TousMonuments.UseVisualStyleBackColor = true;
            this.BTN_TousMonuments.Click += new System.EventHandler(this.BTN_TousMonuments_Click);
            // 
            // CBX_Meilleur
            // 
            this.CBX_Meilleur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CBX_Meilleur.AutoSize = true;
            this.CBX_Meilleur.Enabled = false;
            this.CBX_Meilleur.Location = new System.Drawing.Point(9, 54);
            this.CBX_Meilleur.Margin = new System.Windows.Forms.Padding(5);
            this.CBX_Meilleur.Name = "CBX_Meilleur";
            this.CBX_Meilleur.Size = new System.Drawing.Size(113, 20);
            this.CBX_Meilleur.TabIndex = 8;
            this.CBX_Meilleur.Text = "Meilleur Circuit\r\n";
            this.CBX_Meilleur.UseVisualStyleBackColor = true;
            this.CBX_Meilleur.CheckedChanged += new System.EventHandler(this.CBX_Meilleur_CheckedChanged);
            // 
            // CBX_Tous
            // 
            this.CBX_Tous.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CBX_Tous.AutoSize = true;
            this.CBX_Tous.Checked = true;
            this.CBX_Tous.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBX_Tous.Enabled = false;
            this.CBX_Tous.Location = new System.Drawing.Point(9, 24);
            this.CBX_Tous.Margin = new System.Windows.Forms.Padding(5);
            this.CBX_Tous.Name = "CBX_Tous";
            this.CBX_Tous.Size = new System.Drawing.Size(123, 20);
            this.CBX_Tous.TabIndex = 7;
            this.CBX_Tous.Text = "Tous les circuits";
            this.CBX_Tous.UseVisualStyleBackColor = true;
            this.CBX_Tous.CheckedChanged += new System.EventHandler(this.CBX_Tous_CheckedChanged);
            // 
            // CBX_Monument
            // 
            this.CBX_Monument.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CBX_Monument.AutoSize = true;
            this.CBX_Monument.Enabled = false;
            this.CBX_Monument.Location = new System.Drawing.Point(9, 144);
            this.CBX_Monument.Margin = new System.Windows.Forms.Padding(5);
            this.CBX_Monument.Name = "CBX_Monument";
            this.CBX_Monument.Size = new System.Drawing.Size(89, 20);
            this.CBX_Monument.TabIndex = 11;
            this.CBX_Monument.Text = "Monument";
            this.CBX_Monument.UseVisualStyleBackColor = true;
            this.CBX_Monument.CheckedChanged += new System.EventHandler(this.CBX_Other_CheckedChanged);
            // 
            // CBX_Prix
            // 
            this.CBX_Prix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CBX_Prix.AutoSize = true;
            this.CBX_Prix.Enabled = false;
            this.CBX_Prix.Location = new System.Drawing.Point(9, 114);
            this.CBX_Prix.Margin = new System.Windows.Forms.Padding(5);
            this.CBX_Prix.Name = "CBX_Prix";
            this.CBX_Prix.Size = new System.Drawing.Size(110, 20);
            this.CBX_Prix.TabIndex = 10;
            this.CBX_Prix.Text = "Prix inférieur à";
            this.CBX_Prix.UseVisualStyleBackColor = true;
            this.CBX_Prix.CheckedChanged += new System.EventHandler(this.CBX_Other_CheckedChanged);
            // 
            // TBX_Prix
            // 
            this.TBX_Prix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBX_Prix.Enabled = false;
            this.TBX_Prix.Location = new System.Drawing.Point(136, 112);
            this.TBX_Prix.Margin = new System.Windows.Forms.Padding(4);
            this.TBX_Prix.MaximumSize = new System.Drawing.Size(250, 22);
            this.TBX_Prix.MinimumSize = new System.Drawing.Size(135, 22);
            this.TBX_Prix.Name = "TBX_Prix";
            this.TBX_Prix.Size = new System.Drawing.Size(141, 22);
            this.TBX_Prix.TabIndex = 14;
            this.TBX_Prix.TextChanged += new System.EventHandler(this.TBX_Prix_TextChanged);
            // 
            // CBX_VilleDepart
            // 
            this.CBX_VilleDepart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CBX_VilleDepart.AutoSize = true;
            this.CBX_VilleDepart.Enabled = false;
            this.CBX_VilleDepart.Location = new System.Drawing.Point(9, 84);
            this.CBX_VilleDepart.Margin = new System.Windows.Forms.Padding(5);
            this.CBX_VilleDepart.Name = "CBX_VilleDepart";
            this.CBX_VilleDepart.Size = new System.Drawing.Size(114, 20);
            this.CBX_VilleDepart.TabIndex = 9;
            this.CBX_VilleDepart.Text = "Ville de départ";
            this.CBX_VilleDepart.UseVisualStyleBackColor = true;
            this.CBX_VilleDepart.CheckedChanged += new System.EventHandler(this.CBX_Other_CheckedChanged);
            // 
            // BTN_Rechercher
            // 
            this.BTN_Rechercher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Rechercher.Enabled = false;
            this.BTN_Rechercher.Location = new System.Drawing.Point(401, 143);
            this.BTN_Rechercher.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Rechercher.Name = "BTN_Rechercher";
            this.BTN_Rechercher.Size = new System.Drawing.Size(86, 24);
            this.BTN_Rechercher.TabIndex = 17;
            this.BTN_Rechercher.Text = "Rechercher";
            this.BTN_Rechercher.UseVisualStyleBackColor = true;
            this.BTN_Rechercher.Click += new System.EventHandler(this.BTN_Rechercher_Click);
            // 
            // DGV_Circuit
            // 
            this.DGV_Circuit.AllowUserToAddRows = false;
            this.DGV_Circuit.AllowUserToDeleteRows = false;
            this.DGV_Circuit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Circuit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGV_Circuit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Circuit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomCircuit,
            this.VilleDepart,
            this.VilleArrivee,
            this.PrixCircuit});
            this.DGV_Circuit.Enabled = false;
            this.DGV_Circuit.Location = new System.Drawing.Point(13, 28);
            this.DGV_Circuit.Margin = new System.Windows.Forms.Padding(4);
            this.DGV_Circuit.MultiSelect = false;
            this.DGV_Circuit.Name = "DGV_Circuit";
            this.DGV_Circuit.ReadOnly = true;
            this.DGV_Circuit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Circuit.ShowEditingIcon = false;
            this.DGV_Circuit.Size = new System.Drawing.Size(446, 282);
            this.DGV_Circuit.TabIndex = 20;
            this.DGV_Circuit.SelectionChanged += new System.EventHandler(this.DGV_Circuit_SelectionChanged);
            // 
            // NomCircuit
            // 
            this.NomCircuit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomCircuit.FillWeight = 150F;
            this.NomCircuit.HeaderText = "Nom du circuit";
            this.NomCircuit.MinimumWidth = 138;
            this.NomCircuit.Name = "NomCircuit";
            this.NomCircuit.ReadOnly = true;
            // 
            // VilleDepart
            // 
            this.VilleDepart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VilleDepart.FillWeight = 50F;
            this.VilleDepart.HeaderText = "Ville de départ";
            this.VilleDepart.Name = "VilleDepart";
            this.VilleDepart.ReadOnly = true;
            // 
            // VilleArrivee
            // 
            this.VilleArrivee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VilleArrivee.FillWeight = 50F;
            this.VilleArrivee.HeaderText = "Ville d\'arrivée";
            this.VilleArrivee.Name = "VilleArrivee";
            this.VilleArrivee.ReadOnly = true;
            // 
            // PrixCircuit
            // 
            this.PrixCircuit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PrixCircuit.FillWeight = 40F;
            this.PrixCircuit.HeaderText = "Prix";
            this.PrixCircuit.Name = "PrixCircuit";
            this.PrixCircuit.ReadOnly = true;
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Connexion,
            this.TSMI_Circuit,
            this.TSMI_Monuments,
            this.TSMI_Aide,
            this.TSMI_APropos});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.MenuStrip.Size = new System.Drawing.Size(520, 24);
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
            this.MI_Connexion_Connecter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.MI_Connexion_Connecter.Size = new System.Drawing.Size(193, 22);
            this.MI_Connexion_Connecter.Text = "Se connecter";
            this.MI_Connexion_Connecter.Click += new System.EventHandler(this.MI_Connexion_Connecter_Click);
            // 
            // MI_Connexion_Deconnecter
            // 
            this.MI_Connexion_Deconnecter.Enabled = false;
            this.MI_Connexion_Deconnecter.Name = "MI_Connexion_Deconnecter";
            this.MI_Connexion_Deconnecter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.MI_Connexion_Deconnecter.Size = new System.Drawing.Size(193, 22);
            this.MI_Connexion_Deconnecter.Text = "Se déconnecter";
            this.MI_Connexion_Deconnecter.Click += new System.EventHandler(this.MI_Connexion_Deconnecter_Click);
            // 
            // TSMI_Circuit
            // 
            this.TSMI_Circuit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MI_Circuits_Ajout,
            this.MI_Circuits_Modif,
            this.MI_Circuit_Supp,
            this.MI_Circuits_Afficher,
            this.MI_Circuits_GererMonuments});
            this.TSMI_Circuit.Enabled = false;
            this.TSMI_Circuit.Name = "TSMI_Circuit";
            this.TSMI_Circuit.Size = new System.Drawing.Size(59, 20);
            this.TSMI_Circuit.Text = "Circuits";
            // 
            // MI_Circuits_Ajout
            // 
            this.MI_Circuits_Ajout.Name = "MI_Circuits_Ajout";
            this.MI_Circuits_Ajout.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.MI_Circuits_Ajout.Size = new System.Drawing.Size(242, 22);
            this.MI_Circuits_Ajout.Text = "Ajouter";
            this.MI_Circuits_Ajout.Click += new System.EventHandler(this.MI_Circuits_Ajout_Click);
            // 
            // MI_Circuits_Modif
            // 
            this.MI_Circuits_Modif.Name = "MI_Circuits_Modif";
            this.MI_Circuits_Modif.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.MI_Circuits_Modif.Size = new System.Drawing.Size(242, 22);
            this.MI_Circuits_Modif.Text = "Modifier";
            this.MI_Circuits_Modif.Click += new System.EventHandler(this.MI_Circuits_Modif_Click);
            // 
            // MI_Circuit_Supp
            // 
            this.MI_Circuit_Supp.Name = "MI_Circuit_Supp";
            this.MI_Circuit_Supp.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.MI_Circuit_Supp.Size = new System.Drawing.Size(242, 22);
            this.MI_Circuit_Supp.Text = "Supprimer";
            this.MI_Circuit_Supp.Click += new System.EventHandler(this.MI_Circuit_Supp_Click);
            // 
            // MI_Circuits_Afficher
            // 
            this.MI_Circuits_Afficher.Name = "MI_Circuits_Afficher";
            this.MI_Circuits_Afficher.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.MI_Circuits_Afficher.Size = new System.Drawing.Size(242, 22);
            this.MI_Circuits_Afficher.Text = "Afficher les monuments";
            this.MI_Circuits_Afficher.Click += new System.EventHandler(this.MI_Circuits_Afficher_Click);
            // 
            // MI_Circuits_GererMonuments
            // 
            this.MI_Circuits_GererMonuments.Name = "MI_Circuits_GererMonuments";
            this.MI_Circuits_GererMonuments.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.G)));
            this.MI_Circuits_GererMonuments.Size = new System.Drawing.Size(242, 22);
            this.MI_Circuits_GererMonuments.Text = "Gérer les monuments";
            this.MI_Circuits_GererMonuments.Click += new System.EventHandler(this.MI_Circuits_GererMonuments_Click);
            // 
            // TSMI_Monuments
            // 
            this.TSMI_Monuments.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MI_Monuments_Ajouter,
            this.MI_Monuments_Voir});
            this.TSMI_Monuments.Enabled = false;
            this.TSMI_Monuments.Name = "TSMI_Monuments";
            this.TSMI_Monuments.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.TSMI_Monuments.Size = new System.Drawing.Size(84, 20);
            this.TSMI_Monuments.Text = "Monuments";
            // 
            // MI_Monuments_Ajouter
            // 
            this.MI_Monuments_Ajouter.Name = "MI_Monuments_Ajouter";
            this.MI_Monuments_Ajouter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.MI_Monuments_Ajouter.Size = new System.Drawing.Size(246, 22);
            this.MI_Monuments_Ajouter.Text = "Ajouter un monument";
            this.MI_Monuments_Ajouter.Click += new System.EventHandler(this.MI_Monuments_Ajouter_Click);
            // 
            // MI_Monuments_Voir
            // 
            this.MI_Monuments_Voir.Name = "MI_Monuments_Voir";
            this.MI_Monuments_Voir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.MI_Monuments_Voir.Size = new System.Drawing.Size(246, 22);
            this.MI_Monuments_Voir.Text = "Voir tous les monuments";
            this.MI_Monuments_Voir.Click += new System.EventHandler(this.MI_Monuments_Voir_Click);
            // 
            // TSMI_Aide
            // 
            this.TSMI_Aide.Name = "TSMI_Aide";
            this.TSMI_Aide.Size = new System.Drawing.Size(43, 20);
            this.TSMI_Aide.Text = "Aide";
            this.TSMI_Aide.Click += new System.EventHandler(this.TSMI_Aide_Click);
            // 
            // TSMI_APropos
            // 
            this.TSMI_APropos.Name = "TSMI_APropos";
            this.TSMI_APropos.Size = new System.Drawing.Size(67, 20);
            this.TSMI_APropos.Text = "À propos";
            this.TSMI_APropos.Click += new System.EventHandler(this.TSMI_APropos_Click);
            // 
            // FB_AjoutMonument
            // 
            this.FB_AjoutMonument.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FB_AjoutMonument.BackgroundImage = global::TP_Final.Properties.Resources.Monument_Neutral;
            this.FB_AjoutMonument.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FB_AjoutMonument.ClickedImage = global::TP_Final.Properties.Resources.Monument_Clicked;
            this.FB_AjoutMonument.DisabledImage = global::TP_Final.Properties.Resources.Monument_Disabled;
            this.FB_AjoutMonument.Enabled = false;
            this.FB_AjoutMonument.Image = ((System.Drawing.Image)(resources.GetObject("FB_AjoutMonument.Image")));
            this.FB_AjoutMonument.Location = new System.Drawing.Point(467, 268);
            this.FB_AjoutMonument.Margin = new System.Windows.Forms.Padding(4);
            this.FB_AjoutMonument.Name = "FB_AjoutMonument";
            this.FB_AjoutMonument.NeutralImage = global::TP_Final.Properties.Resources.Monument_Neutral;
            this.FB_AjoutMonument.OverImage = global::TP_Final.Properties.Resources.Monument_Hover;
            this.FB_AjoutMonument.Size = new System.Drawing.Size(40, 40);
            this.FB_AjoutMonument.TabIndex = 6;
            this.FB_AjoutMonument.TabStop = false;
            this.ToolTip.SetToolTip(this.FB_AjoutMonument, "Ajouter un monument");
            this.FB_AjoutMonument.UseVisualStyleBackColor = true;
            this.FB_AjoutMonument.Click += new System.EventHandler(this.FB_AjoutMonument_Click);
            // 
            // FB_Gerer
            // 
            this.FB_Gerer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FB_Gerer.BackgroundImage = global::TP_Final.Properties.Resources.Settings_Neutral;
            this.FB_Gerer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FB_Gerer.ClickedImage = global::TP_Final.Properties.Resources.Settings_Clicked;
            this.FB_Gerer.DisabledImage = global::TP_Final.Properties.Resources.Settings_Disabled;
            this.FB_Gerer.Enabled = false;
            this.FB_Gerer.Image = ((System.Drawing.Image)(resources.GetObject("FB_Gerer.Image")));
            this.FB_Gerer.Location = new System.Drawing.Point(467, 220);
            this.FB_Gerer.Margin = new System.Windows.Forms.Padding(4);
            this.FB_Gerer.Name = "FB_Gerer";
            this.FB_Gerer.NeutralImage = global::TP_Final.Properties.Resources.Settings_Neutral;
            this.FB_Gerer.OverImage = global::TP_Final.Properties.Resources.Settings_Hover;
            this.FB_Gerer.Size = new System.Drawing.Size(40, 40);
            this.FB_Gerer.TabIndex = 5;
            this.FB_Gerer.TabStop = false;
            this.FB_Gerer.Text = "Gérer les monuments du circuit";
            this.ToolTip.SetToolTip(this.FB_Gerer, "Gérer les monuments de ce circuit");
            this.FB_Gerer.UseVisualStyleBackColor = true;
            this.FB_Gerer.Click += new System.EventHandler(this.FB_Gerer_Click);
            // 
            // FB_Circuit_Supp
            // 
            this.FB_Circuit_Supp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FB_Circuit_Supp.BackgroundImage = global::TP_Final.Properties.Resources.Delete_Neutral;
            this.FB_Circuit_Supp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FB_Circuit_Supp.ClickedImage = global::TP_Final.Properties.Resources.Delete_Clicked;
            this.FB_Circuit_Supp.DisabledImage = global::TP_Final.Properties.Resources.Delete_Disabled;
            this.FB_Circuit_Supp.Enabled = false;
            this.FB_Circuit_Supp.Image = ((System.Drawing.Image)(resources.GetObject("FB_Circuit_Supp.Image")));
            this.FB_Circuit_Supp.Location = new System.Drawing.Point(467, 124);
            this.FB_Circuit_Supp.Margin = new System.Windows.Forms.Padding(4);
            this.FB_Circuit_Supp.Name = "FB_Circuit_Supp";
            this.FB_Circuit_Supp.NeutralImage = global::TP_Final.Properties.Resources.Delete_Neutral;
            this.FB_Circuit_Supp.OverImage = global::TP_Final.Properties.Resources.Delete_Hover;
            this.FB_Circuit_Supp.Size = new System.Drawing.Size(40, 40);
            this.FB_Circuit_Supp.TabIndex = 3;
            this.FB_Circuit_Supp.TabStop = false;
            this.FB_Circuit_Supp.Text = "Afficher les monuments du circuit";
            this.ToolTip.SetToolTip(this.FB_Circuit_Supp, "Supprimer le circuit sélectionné");
            this.FB_Circuit_Supp.UseVisualStyleBackColor = true;
            this.FB_Circuit_Supp.Click += new System.EventHandler(this.FB_Circuit_Supp_Click);
            // 
            // FB_Circuit_Ajout
            // 
            this.FB_Circuit_Ajout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FB_Circuit_Ajout.BackgroundImage = global::TP_Final.Properties.Resources.Add_Neutral;
            this.FB_Circuit_Ajout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FB_Circuit_Ajout.ClickedImage = global::TP_Final.Properties.Resources.Add_Clicked;
            this.FB_Circuit_Ajout.DisabledImage = global::TP_Final.Properties.Resources.Add_Disabled;
            this.FB_Circuit_Ajout.Enabled = false;
            this.FB_Circuit_Ajout.Image = ((System.Drawing.Image)(resources.GetObject("FB_Circuit_Ajout.Image")));
            this.FB_Circuit_Ajout.Location = new System.Drawing.Point(467, 28);
            this.FB_Circuit_Ajout.Margin = new System.Windows.Forms.Padding(4);
            this.FB_Circuit_Ajout.Name = "FB_Circuit_Ajout";
            this.FB_Circuit_Ajout.NeutralImage = global::TP_Final.Properties.Resources.Add_Neutral;
            this.FB_Circuit_Ajout.OverImage = global::TP_Final.Properties.Resources.Add_Hover;
            this.FB_Circuit_Ajout.Size = new System.Drawing.Size(40, 40);
            this.FB_Circuit_Ajout.TabIndex = 1;
            this.FB_Circuit_Ajout.TabStop = false;
            this.FB_Circuit_Ajout.Text = "Ajouter un circuit";
            this.ToolTip.SetToolTip(this.FB_Circuit_Ajout, "Ajouter un circuit");
            this.FB_Circuit_Ajout.UseVisualStyleBackColor = true;
            this.FB_Circuit_Ajout.Click += new System.EventHandler(this.FB_Circuit_Ajout_Click);
            // 
            // FB_Circuit_Modif
            // 
            this.FB_Circuit_Modif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FB_Circuit_Modif.BackgroundImage = global::TP_Final.Properties.Resources.Edit_Neutral;
            this.FB_Circuit_Modif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FB_Circuit_Modif.ClickedImage = global::TP_Final.Properties.Resources.Edit_Clicked;
            this.FB_Circuit_Modif.DisabledImage = global::TP_Final.Properties.Resources.Edit_Disabled;
            this.FB_Circuit_Modif.Enabled = false;
            this.FB_Circuit_Modif.Image = ((System.Drawing.Image)(resources.GetObject("FB_Circuit_Modif.Image")));
            this.FB_Circuit_Modif.Location = new System.Drawing.Point(469, 76);
            this.FB_Circuit_Modif.Margin = new System.Windows.Forms.Padding(4);
            this.FB_Circuit_Modif.Name = "FB_Circuit_Modif";
            this.FB_Circuit_Modif.NeutralImage = global::TP_Final.Properties.Resources.Edit_Neutral;
            this.FB_Circuit_Modif.OverImage = global::TP_Final.Properties.Resources.Edit_Hover;
            this.FB_Circuit_Modif.Size = new System.Drawing.Size(40, 40);
            this.FB_Circuit_Modif.TabIndex = 2;
            this.FB_Circuit_Modif.TabStop = false;
            this.FB_Circuit_Modif.Text = "Modifier le prix du circuit";
            this.ToolTip.SetToolTip(this.FB_Circuit_Modif, "Modifier le circuit sélectionné");
            this.FB_Circuit_Modif.UseVisualStyleBackColor = true;
            this.FB_Circuit_Modif.Click += new System.EventHandler(this.FB_Circuit_Modif_Click);
            // 
            // FB_Info
            // 
            this.FB_Info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FB_Info.BackgroundImage = global::TP_Final.Properties.Resources.Details_Neutral;
            this.FB_Info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FB_Info.ClickedImage = global::TP_Final.Properties.Resources.Details_Clicked;
            this.FB_Info.DisabledImage = global::TP_Final.Properties.Resources.Details_Disabled;
            this.FB_Info.Enabled = false;
            this.FB_Info.Image = ((System.Drawing.Image)(resources.GetObject("FB_Info.Image")));
            this.FB_Info.Location = new System.Drawing.Point(467, 172);
            this.FB_Info.Margin = new System.Windows.Forms.Padding(4);
            this.FB_Info.Name = "FB_Info";
            this.FB_Info.NeutralImage = global::TP_Final.Properties.Resources.Details_Neutral;
            this.FB_Info.OverImage = global::TP_Final.Properties.Resources.Details_Hover;
            this.FB_Info.Size = new System.Drawing.Size(40, 40);
            this.FB_Info.TabIndex = 4;
            this.FB_Info.TabStop = false;
            this.FB_Info.Text = "Afficher les monuments du circuit";
            this.ToolTip.SetToolTip(this.FB_Info, "Voir les monuments de ce circuit");
            this.FB_Info.UseVisualStyleBackColor = true;
            this.FB_Info.Click += new System.EventHandler(this.FB_Circuit_Gerer_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 506);
            this.Controls.Add(this.FB_AjoutMonument);
            this.Controls.Add(this.FB_Gerer);
            this.Controls.Add(this.FB_Circuit_Supp);
            this.Controls.Add(this.GBX_Recherche);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.DGV_Circuit);
            this.Controls.Add(this.FB_Circuit_Ajout);
            this.Controls.Add(this.FB_Circuit_Modif);
            this.Controls.Add(this.FB_Info);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(530, 545);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.GBX_Recherche.ResumeLayout(false);
            this.GBX_Recherche.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Circuit)).EndInit();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Calculator.FlashButton FB_Circuit_Ajout;
        private System.Windows.Forms.GroupBox GBX_Recherche;
        private System.Windows.Forms.TextBox TBX_Prix;
        private System.Windows.Forms.Button BTN_Rechercher;
        private System.Windows.Forms.DataGridView DGV_Circuit;
        private Calculator.FlashButton FB_Circuit_Modif;
        private System.Windows.Forms.CheckBox CBX_Tous;
        private System.Windows.Forms.CheckBox CBX_Monument;
        private System.Windows.Forms.CheckBox CBX_Prix;
        private System.Windows.Forms.CheckBox CBX_VilleDepart;
        private Calculator.FlashButton FB_Info;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Connexion;
        private System.Windows.Forms.ToolStripMenuItem MI_Connexion_Connecter;
        private System.Windows.Forms.ToolStripMenuItem MI_Connexion_Deconnecter;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Circuit;
        private System.Windows.Forms.ToolStripMenuItem MI_Circuits_Ajout;
        private System.Windows.Forms.ToolStripMenuItem MI_Circuits_Modif;
        private System.Windows.Forms.ToolStripMenuItem MI_Circuits_GererMonuments;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Aide;
        private System.Windows.Forms.ToolStripMenuItem TSMI_APropos;
        private System.Windows.Forms.CheckBox CBX_Meilleur;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomCircuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn VilleDepart;
        private System.Windows.Forms.DataGridViewTextBoxColumn VilleArrivee;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrixCircuit;
        private Calculator.FlashButton FB_Circuit_Supp;
        private System.Windows.Forms.ToolStripMenuItem MI_Circuit_Supp;
        private Calculator.FlashButton FB_Gerer;
        private Calculator.FlashButton FB_AjoutMonument;
        private System.Windows.Forms.Button BTN_TousMonuments;
        private System.Windows.Forms.ToolStripMenuItem MI_Circuits_Afficher;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Monuments;
        private System.Windows.Forms.ToolStripMenuItem MI_Monuments_Ajouter;
        private System.Windows.Forms.ToolStripMenuItem MI_Monuments_Voir;
        private System.Windows.Forms.ComboBox CBX_MeilleurCircuit;
        private System.Windows.Forms.ComboBox COMBX_VilleDepart;
        private System.Windows.Forms.ComboBox COMBX_Monument;
    }
}

