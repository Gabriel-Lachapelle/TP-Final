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
            this.label1 = new System.Windows.Forms.Label();
            this.CBX_Meilleur = new System.Windows.Forms.CheckBox();
            this.CBX_Tous = new System.Windows.Forms.CheckBox();
            this.CBX_Monument = new System.Windows.Forms.CheckBox();
            this.TBX_Monument = new System.Windows.Forms.TextBox();
            this.CBX_Prix = new System.Windows.Forms.CheckBox();
            this.TBX_Prix = new System.Windows.Forms.TextBox();
            this.TBX_VilleDepart = new System.Windows.Forms.TextBox();
            this.CBX_VilleDepart = new System.Windows.Forms.CheckBox();
            this.FB_Circuit_Show = new Calculator.FlashButton();
            this.BTN_Rechercher = new System.Windows.Forms.Button();
            this.LBL_Recherche = new System.Windows.Forms.Label();
            this.DGV_Circuit = new System.Windows.Forms.DataGridView();
            this.NomCircuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VilleDepart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VilleArrivee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrixCircuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cotation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FB_Circuit_Modif = new Calculator.FlashButton();
            this.FB_Circuit_Ajout = new Calculator.FlashButton();
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
            this.label2 = new System.Windows.Forms.Label();
            this.GBX_Circuits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Circuit)).BeginInit();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBX_Circuits
            // 
            this.GBX_Circuits.Controls.Add(this.label2);
            this.GBX_Circuits.Controls.Add(this.label1);
            this.GBX_Circuits.Controls.Add(this.CBX_Meilleur);
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
            this.GBX_Circuits.Location = new System.Drawing.Point(16, 33);
            this.GBX_Circuits.Margin = new System.Windows.Forms.Padding(4);
            this.GBX_Circuits.Name = "GBX_Circuits";
            this.GBX_Circuits.Padding = new System.Windows.Forms.Padding(4);
            this.GBX_Circuits.Size = new System.Drawing.Size(609, 384);
            this.GBX_Circuits.TabIndex = 1;
            this.GBX_Circuits.TabStop = false;
            this.GBX_Circuits.Text = "Circuits";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "-> À intégrer";
            // 
            // CBX_Meilleur
            // 
            this.CBX_Meilleur.AutoSize = true;
            this.CBX_Meilleur.Enabled = false;
            this.CBX_Meilleur.Location = new System.Drawing.Point(8, 261);
            this.CBX_Meilleur.Margin = new System.Windows.Forms.Padding(5);
            this.CBX_Meilleur.Name = "CBX_Meilleur";
            this.CBX_Meilleur.Size = new System.Drawing.Size(113, 20);
            this.CBX_Meilleur.TabIndex = 18;
            this.CBX_Meilleur.Text = "Meilleur Circuit";
            this.CBX_Meilleur.UseVisualStyleBackColor = true;
            this.CBX_Meilleur.CheckedChanged += new System.EventHandler(this.CBX_Meilleur_CheckedChanged);
            // 
            // CBX_Tous
            // 
            this.CBX_Tous.AutoSize = true;
            this.CBX_Tous.Checked = true;
            this.CBX_Tous.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBX_Tous.Enabled = false;
            this.CBX_Tous.Location = new System.Drawing.Point(8, 231);
            this.CBX_Tous.Margin = new System.Windows.Forms.Padding(5);
            this.CBX_Tous.Name = "CBX_Tous";
            this.CBX_Tous.Size = new System.Drawing.Size(123, 20);
            this.CBX_Tous.TabIndex = 17;
            this.CBX_Tous.Text = "Tous les circuits";
            this.CBX_Tous.UseVisualStyleBackColor = true;
            this.CBX_Tous.CheckedChanged += new System.EventHandler(this.CBX_Tous_CheckedChanged);
            // 
            // CBX_Monument
            // 
            this.CBX_Monument.AutoSize = true;
            this.CBX_Monument.Enabled = false;
            this.CBX_Monument.Location = new System.Drawing.Point(8, 351);
            this.CBX_Monument.Margin = new System.Windows.Forms.Padding(5);
            this.CBX_Monument.Name = "CBX_Monument";
            this.CBX_Monument.Size = new System.Drawing.Size(89, 20);
            this.CBX_Monument.TabIndex = 16;
            this.CBX_Monument.Text = "Monument";
            this.CBX_Monument.UseVisualStyleBackColor = true;
            this.CBX_Monument.CheckedChanged += new System.EventHandler(this.CBX_Other_CheckedChanged);
            // 
            // TBX_Monument
            // 
            this.TBX_Monument.Enabled = false;
            this.TBX_Monument.Location = new System.Drawing.Point(132, 349);
            this.TBX_Monument.Margin = new System.Windows.Forms.Padding(4);
            this.TBX_Monument.Name = "TBX_Monument";
            this.TBX_Monument.Size = new System.Drawing.Size(200, 22);
            this.TBX_Monument.TabIndex = 12;
            // 
            // CBX_Prix
            // 
            this.CBX_Prix.AutoSize = true;
            this.CBX_Prix.Enabled = false;
            this.CBX_Prix.Location = new System.Drawing.Point(8, 321);
            this.CBX_Prix.Margin = new System.Windows.Forms.Padding(5);
            this.CBX_Prix.Name = "CBX_Prix";
            this.CBX_Prix.Size = new System.Drawing.Size(110, 20);
            this.CBX_Prix.TabIndex = 15;
            this.CBX_Prix.Text = "Prix inférieur à";
            this.CBX_Prix.UseVisualStyleBackColor = true;
            this.CBX_Prix.CheckedChanged += new System.EventHandler(this.CBX_Other_CheckedChanged);
            // 
            // TBX_Prix
            // 
            this.TBX_Prix.Enabled = false;
            this.TBX_Prix.Location = new System.Drawing.Point(132, 319);
            this.TBX_Prix.Margin = new System.Windows.Forms.Padding(4);
            this.TBX_Prix.Name = "TBX_Prix";
            this.TBX_Prix.Size = new System.Drawing.Size(200, 22);
            this.TBX_Prix.TabIndex = 11;
            // 
            // TBX_VilleDepart
            // 
            this.TBX_VilleDepart.Enabled = false;
            this.TBX_VilleDepart.Location = new System.Drawing.Point(132, 289);
            this.TBX_VilleDepart.Margin = new System.Windows.Forms.Padding(4);
            this.TBX_VilleDepart.Name = "TBX_VilleDepart";
            this.TBX_VilleDepart.Size = new System.Drawing.Size(200, 22);
            this.TBX_VilleDepart.TabIndex = 10;
            // 
            // CBX_VilleDepart
            // 
            this.CBX_VilleDepart.AutoSize = true;
            this.CBX_VilleDepart.Enabled = false;
            this.CBX_VilleDepart.Location = new System.Drawing.Point(8, 291);
            this.CBX_VilleDepart.Margin = new System.Windows.Forms.Padding(5);
            this.CBX_VilleDepart.Name = "CBX_VilleDepart";
            this.CBX_VilleDepart.Size = new System.Drawing.Size(114, 20);
            this.CBX_VilleDepart.TabIndex = 14;
            this.CBX_VilleDepart.Text = "Ville de départ";
            this.CBX_VilleDepart.UseVisualStyleBackColor = true;
            this.CBX_VilleDepart.CheckedChanged += new System.EventHandler(this.CBX_Other_CheckedChanged);
            // 
            // FB_Circuit_Show
            // 
            this.FB_Circuit_Show.BackgroundImage = global::TP_Final.Properties.Resources.Show_Neutral;
            this.FB_Circuit_Show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FB_Circuit_Show.ClickedImage = global::TP_Final.Properties.Resources.Show_Clicked;
            this.FB_Circuit_Show.DisabledImage = global::TP_Final.Properties.Resources.Show_Disabled;
            this.FB_Circuit_Show.Enabled = false;
            this.FB_Circuit_Show.Image = ((System.Drawing.Image)(resources.GetObject("FB_Circuit_Show.Image")));
            this.FB_Circuit_Show.Location = new System.Drawing.Point(559, 119);
            this.FB_Circuit_Show.Margin = new System.Windows.Forms.Padding(4);
            this.FB_Circuit_Show.Name = "FB_Circuit_Show";
            this.FB_Circuit_Show.NeutralImage = global::TP_Final.Properties.Resources.Show_Neutral;
            this.FB_Circuit_Show.OverImage = global::TP_Final.Properties.Resources.Show_Hover;
            this.FB_Circuit_Show.Size = new System.Drawing.Size(40, 40);
            this.FB_Circuit_Show.TabIndex = 13;
            this.FB_Circuit_Show.Text = "Afficher les monuments du circuit";
            this.FB_Circuit_Show.UseVisualStyleBackColor = true;
            this.FB_Circuit_Show.Click += new System.EventHandler(this.FB_Circuit_Show_Click);
            // 
            // BTN_Rechercher
            // 
            this.BTN_Rechercher.Enabled = false;
            this.BTN_Rechercher.Location = new System.Drawing.Point(512, 343);
            this.BTN_Rechercher.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Rechercher.Name = "BTN_Rechercher";
            this.BTN_Rechercher.Size = new System.Drawing.Size(87, 28);
            this.BTN_Rechercher.TabIndex = 9;
            this.BTN_Rechercher.Text = "Rechercher";
            this.BTN_Rechercher.UseVisualStyleBackColor = true;
            // 
            // LBL_Recherche
            // 
            this.LBL_Recherche.AutoSize = true;
            this.LBL_Recherche.Location = new System.Drawing.Point(8, 210);
            this.LBL_Recherche.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Recherche.Name = "LBL_Recherche";
            this.LBL_Recherche.Size = new System.Drawing.Size(77, 16);
            this.LBL_Recherche.TabIndex = 4;
            this.LBL_Recherche.Text = "Recherche:";
            // 
            // DGV_Circuit
            // 
            this.DGV_Circuit.AllowUserToAddRows = false;
            this.DGV_Circuit.AllowUserToDeleteRows = false;
            this.DGV_Circuit.AllowUserToResizeRows = false;
            this.DGV_Circuit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Circuit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomCircuit,
            this.VilleDepart,
            this.VilleArrivee,
            this.PrixCircuit,
            this.Cotation});
            this.DGV_Circuit.Enabled = false;
            this.DGV_Circuit.Location = new System.Drawing.Point(8, 23);
            this.DGV_Circuit.Margin = new System.Windows.Forms.Padding(4);
            this.DGV_Circuit.MultiSelect = false;
            this.DGV_Circuit.Name = "DGV_Circuit";
            this.DGV_Circuit.ReadOnly = true;
            this.DGV_Circuit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Circuit.ShowEditingIcon = false;
            this.DGV_Circuit.Size = new System.Drawing.Size(543, 180);
            this.DGV_Circuit.TabIndex = 3;
            // 
            // NomCircuit
            // 
            this.NomCircuit.HeaderText = "Nom du circuit";
            this.NomCircuit.Name = "NomCircuit";
            this.NomCircuit.ReadOnly = true;
            // 
            // VilleDepart
            // 
            this.VilleDepart.HeaderText = "Ville de départ";
            this.VilleDepart.Name = "VilleDepart";
            this.VilleDepart.ReadOnly = true;
            // 
            // VilleArrivee
            // 
            this.VilleArrivee.HeaderText = "Ville d\'arrivée";
            this.VilleArrivee.Name = "VilleArrivee";
            this.VilleArrivee.ReadOnly = true;
            // 
            // PrixCircuit
            // 
            this.PrixCircuit.HeaderText = "Prix";
            this.PrixCircuit.Name = "PrixCircuit";
            this.PrixCircuit.ReadOnly = true;
            // 
            // Cotation
            // 
            this.Cotation.HeaderText = "Cotation";
            this.Cotation.Name = "Cotation";
            this.Cotation.ReadOnly = true;
            // 
            // FB_Circuit_Modif
            // 
            this.FB_Circuit_Modif.BackgroundImage = global::TP_Final.Properties.Resources.Edit_Neutral;
            this.FB_Circuit_Modif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FB_Circuit_Modif.ClickedImage = global::TP_Final.Properties.Resources.Edit_Clicked;
            this.FB_Circuit_Modif.DisabledImage = global::TP_Final.Properties.Resources.Edit_Disabled;
            this.FB_Circuit_Modif.Enabled = false;
            this.FB_Circuit_Modif.Image = ((System.Drawing.Image)(resources.GetObject("FB_Circuit_Modif.Image")));
            this.FB_Circuit_Modif.Location = new System.Drawing.Point(559, 71);
            this.FB_Circuit_Modif.Margin = new System.Windows.Forms.Padding(4);
            this.FB_Circuit_Modif.Name = "FB_Circuit_Modif";
            this.FB_Circuit_Modif.NeutralImage = global::TP_Final.Properties.Resources.Edit_Neutral;
            this.FB_Circuit_Modif.OverImage = global::TP_Final.Properties.Resources.Edit_Hover;
            this.FB_Circuit_Modif.Size = new System.Drawing.Size(40, 40);
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
            this.FB_Circuit_Ajout.Location = new System.Drawing.Point(560, 23);
            this.FB_Circuit_Ajout.Margin = new System.Windows.Forms.Padding(4);
            this.FB_Circuit_Ajout.Name = "FB_Circuit_Ajout";
            this.FB_Circuit_Ajout.NeutralImage = global::TP_Final.Properties.Resources.Add_Neutral;
            this.FB_Circuit_Ajout.OverImage = global::TP_Final.Properties.Resources.Add_Hover;
            this.FB_Circuit_Ajout.Size = new System.Drawing.Size(40, 40);
            this.FB_Circuit_Ajout.TabIndex = 0;
            this.FB_Circuit_Ajout.Text = "Ajouter un circuit";
            this.FB_Circuit_Ajout.UseVisualStyleBackColor = true;
            this.FB_Circuit_Ajout.Click += new System.EventHandler(this.FB_Circuit_Ajout_Click);
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
            this.MenuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.MenuStrip.Size = new System.Drawing.Size(641, 24);
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
            this.MI_Connexion_Connecter.Size = new System.Drawing.Size(155, 22);
            this.MI_Connexion_Connecter.Text = "Se connecter";
            this.MI_Connexion_Connecter.Click += new System.EventHandler(this.MI_Connexion_Connecter_Click);
            // 
            // MI_Connexion_Deconnecter
            // 
            this.MI_Connexion_Deconnecter.Enabled = false;
            this.MI_Connexion_Deconnecter.Name = "MI_Connexion_Deconnecter";
            this.MI_Connexion_Deconnecter.Size = new System.Drawing.Size(155, 22);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(138, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "-> À intégrer";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 425);
            this.Controls.Add(this.GBX_Circuits);
            this.Controls.Add(this.MenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.GBX_Circuits.ResumeLayout(false);
            this.GBX_Circuits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Circuit)).EndInit();
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
        private System.Windows.Forms.CheckBox CBX_Tous;
        private System.Windows.Forms.CheckBox CBX_Monument;
        private System.Windows.Forms.CheckBox CBX_Prix;
        private System.Windows.Forms.CheckBox CBX_VilleDepart;
        private Calculator.FlashButton FB_Circuit_Show;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CBX_Meilleur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cotation;
        private System.Windows.Forms.Label label2;
    }
}

