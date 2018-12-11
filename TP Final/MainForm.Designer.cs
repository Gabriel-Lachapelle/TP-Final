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
            this.TBX_Monument = new System.Windows.Forms.TextBox();
            this.TBX_Prix = new System.Windows.Forms.TextBox();
            this.TBX_VilleDepart = new System.Windows.Forms.TextBox();
            this.BTN_Rechercher = new System.Windows.Forms.Button();
            this.LBL_Recherche = new System.Windows.Forms.Label();
            this.DGV_Circuit = new System.Windows.Forms.DataGridView();
            this.NomCircuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VilleDepart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VilleArrivee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrixCircuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GBX_Monuments = new System.Windows.Forms.GroupBox();
            this.RB_Cotation = new System.Windows.Forms.RadioButton();
            this.LBL_Ordre = new System.Windows.Forms.Label();
            this.DGV_Monument = new System.Windows.Forms.DataGridView();
            this.NomMonument = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrixMonument = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreEtoiles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RB_Meilleur = new System.Windows.Forms.RadioButton();
            this.CBX_VilleDepart = new System.Windows.Forms.CheckBox();
            this.CBX_Prix = new System.Windows.Forms.CheckBox();
            this.CBX_Monument = new System.Windows.Forms.CheckBox();
            this.CBX_Tous = new System.Windows.Forms.CheckBox();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.FB_Monument_Supp = new Calculator.FlashButton();
            this.FB_Monument_Ajout = new Calculator.FlashButton();
            this.FB_Circuit_Show = new Calculator.FlashButton();
            this.FB_Circuit_Modif = new Calculator.FlashButton();
            this.FB_Circuit_Ajout = new Calculator.FlashButton();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.circuitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monumentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.àProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seConnecterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seDéconnecterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordonnerSelonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cotationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meilleurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            // TBX_Monument
            // 
            this.TBX_Monument.Location = new System.Drawing.Point(105, 255);
            this.TBX_Monument.Name = "TBX_Monument";
            this.TBX_Monument.Size = new System.Drawing.Size(151, 20);
            this.TBX_Monument.TabIndex = 12;
            // 
            // TBX_Prix
            // 
            this.TBX_Prix.Location = new System.Drawing.Point(105, 232);
            this.TBX_Prix.Name = "TBX_Prix";
            this.TBX_Prix.Size = new System.Drawing.Size(151, 20);
            this.TBX_Prix.TabIndex = 11;
            // 
            // TBX_VilleDepart
            // 
            this.TBX_VilleDepart.Location = new System.Drawing.Point(105, 209);
            this.TBX_VilleDepart.Name = "TBX_VilleDepart";
            this.TBX_VilleDepart.Size = new System.Drawing.Size(151, 20);
            this.TBX_VilleDepart.TabIndex = 10;
            // 
            // BTN_Rechercher
            // 
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
            // RB_Cotation
            // 
            this.RB_Cotation.AutoSize = true;
            this.RB_Cotation.Location = new System.Drawing.Point(356, 129);
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
            this.LBL_Ordre.Location = new System.Drawing.Point(353, 113);
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
            this.DGV_Monument.Location = new System.Drawing.Point(6, 19);
            this.DGV_Monument.Name = "DGV_Monument";
            this.DGV_Monument.Size = new System.Drawing.Size(341, 150);
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
            // RB_Meilleur
            // 
            this.RB_Meilleur.AutoSize = true;
            this.RB_Meilleur.Location = new System.Drawing.Point(356, 152);
            this.RB_Meilleur.Name = "RB_Meilleur";
            this.RB_Meilleur.Size = new System.Drawing.Size(93, 17);
            this.RB_Meilleur.TabIndex = 7;
            this.RB_Meilleur.TabStop = true;
            this.RB_Meilleur.Text = "Meilleur Circuit";
            this.RB_Meilleur.UseVisualStyleBackColor = true;
            // 
            // CBX_VilleDepart
            // 
            this.CBX_VilleDepart.AutoSize = true;
            this.CBX_VilleDepart.Location = new System.Drawing.Point(6, 211);
            this.CBX_VilleDepart.Name = "CBX_VilleDepart";
            this.CBX_VilleDepart.Size = new System.Drawing.Size(93, 17);
            this.CBX_VilleDepart.TabIndex = 14;
            this.CBX_VilleDepart.Text = "Ville de départ";
            this.CBX_VilleDepart.UseVisualStyleBackColor = true;
            // 
            // CBX_Prix
            // 
            this.CBX_Prix.AutoSize = true;
            this.CBX_Prix.Location = new System.Drawing.Point(6, 234);
            this.CBX_Prix.Name = "CBX_Prix";
            this.CBX_Prix.Size = new System.Drawing.Size(92, 17);
            this.CBX_Prix.TabIndex = 15;
            this.CBX_Prix.Text = "Prix inférieur à";
            this.CBX_Prix.UseVisualStyleBackColor = true;
            // 
            // CBX_Monument
            // 
            this.CBX_Monument.AutoSize = true;
            this.CBX_Monument.Location = new System.Drawing.Point(6, 257);
            this.CBX_Monument.Name = "CBX_Monument";
            this.CBX_Monument.Size = new System.Drawing.Size(76, 17);
            this.CBX_Monument.TabIndex = 16;
            this.CBX_Monument.Text = "Monument";
            this.CBX_Monument.UseVisualStyleBackColor = true;
            // 
            // CBX_Tous
            // 
            this.CBX_Tous.AutoSize = true;
            this.CBX_Tous.Location = new System.Drawing.Point(6, 188);
            this.CBX_Tous.Name = "CBX_Tous";
            this.CBX_Tous.Size = new System.Drawing.Size(102, 17);
            this.CBX_Tous.TabIndex = 17;
            this.CBX_Tous.Text = "Tous les circuits";
            this.CBX_Tous.UseVisualStyleBackColor = true;
            // 
            // FB_Monument_Supp
            // 
            this.FB_Monument_Supp.BackgroundImage = global::TP_Final.Properties.Resources.Delete_Neutral;
            this.FB_Monument_Supp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FB_Monument_Supp.ClickedImage = null;
            this.FB_Monument_Supp.DisabledImage = null;
            this.FB_Monument_Supp.Image = ((System.Drawing.Image)(resources.GetObject("FB_Monument_Supp.Image")));
            this.FB_Monument_Supp.Location = new System.Drawing.Point(356, 61);
            this.FB_Monument_Supp.Name = "FB_Monument_Supp";
            this.FB_Monument_Supp.NeutralImage = null;
            this.FB_Monument_Supp.OverImage = null;
            this.FB_Monument_Supp.Size = new System.Drawing.Size(36, 36);
            this.FB_Monument_Supp.TabIndex = 1;
            this.FB_Monument_Supp.UseVisualStyleBackColor = true;
            // 
            // FB_Monument_Ajout
            // 
            this.FB_Monument_Ajout.BackgroundImage = global::TP_Final.Properties.Resources.Add_Neutral;
            this.FB_Monument_Ajout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FB_Monument_Ajout.ClickedImage = null;
            this.FB_Monument_Ajout.DisabledImage = null;
            this.FB_Monument_Ajout.Image = ((System.Drawing.Image)(resources.GetObject("FB_Monument_Ajout.Image")));
            this.FB_Monument_Ajout.Location = new System.Drawing.Point(356, 19);
            this.FB_Monument_Ajout.Name = "FB_Monument_Ajout";
            this.FB_Monument_Ajout.NeutralImage = null;
            this.FB_Monument_Ajout.OverImage = null;
            this.FB_Monument_Ajout.Size = new System.Drawing.Size(36, 36);
            this.FB_Monument_Ajout.TabIndex = 0;
            this.FB_Monument_Ajout.UseVisualStyleBackColor = true;
            // 
            // FB_Circuit_Show
            // 
            this.FB_Circuit_Show.BackgroundImage = global::TP_Final.Properties.Resources.Show_Neutral;
            this.FB_Circuit_Show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FB_Circuit_Show.ClickedImage = null;
            this.FB_Circuit_Show.DisabledImage = null;
            this.FB_Circuit_Show.Image = ((System.Drawing.Image)(resources.GetObject("FB_Circuit_Show.Image")));
            this.FB_Circuit_Show.Location = new System.Drawing.Point(455, 129);
            this.FB_Circuit_Show.Name = "FB_Circuit_Show";
            this.FB_Circuit_Show.NeutralImage = null;
            this.FB_Circuit_Show.OverImage = null;
            this.FB_Circuit_Show.Size = new System.Drawing.Size(36, 36);
            this.FB_Circuit_Show.TabIndex = 13;
            this.FB_Circuit_Show.UseVisualStyleBackColor = true;
            // 
            // FB_Circuit_Modif
            // 
            this.FB_Circuit_Modif.BackgroundImage = global::TP_Final.Properties.Resources.Edit_Neutral;
            this.FB_Circuit_Modif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FB_Circuit_Modif.ClickedImage = null;
            this.FB_Circuit_Modif.DisabledImage = null;
            this.FB_Circuit_Modif.Image = ((System.Drawing.Image)(resources.GetObject("FB_Circuit_Modif.Image")));
            this.FB_Circuit_Modif.Location = new System.Drawing.Point(455, 76);
            this.FB_Circuit_Modif.Name = "FB_Circuit_Modif";
            this.FB_Circuit_Modif.NeutralImage = null;
            this.FB_Circuit_Modif.OverImage = null;
            this.FB_Circuit_Modif.Size = new System.Drawing.Size(36, 36);
            this.FB_Circuit_Modif.TabIndex = 1;
            this.FB_Circuit_Modif.UseVisualStyleBackColor = true;
            // 
            // FB_Circuit_Ajout
            // 
            this.FB_Circuit_Ajout.BackgroundImage = global::TP_Final.Properties.Resources.Add_Neutral;
            this.FB_Circuit_Ajout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FB_Circuit_Ajout.ClickedImage = null;
            this.FB_Circuit_Ajout.DisabledImage = null;
            this.FB_Circuit_Ajout.Image = ((System.Drawing.Image)(resources.GetObject("FB_Circuit_Ajout.Image")));
            this.FB_Circuit_Ajout.Location = new System.Drawing.Point(455, 19);
            this.FB_Circuit_Ajout.Name = "FB_Circuit_Ajout";
            this.FB_Circuit_Ajout.NeutralImage = null;
            this.FB_Circuit_Ajout.OverImage = null;
            this.FB_Circuit_Ajout.Size = new System.Drawing.Size(36, 36);
            this.FB_Circuit_Ajout.TabIndex = 0;
            this.FB_Circuit_Ajout.UseVisualStyleBackColor = true;
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connexionToolStripMenuItem,
            this.circuitsToolStripMenuItem,
            this.monumentsToolStripMenuItem,
            this.aideToolStripMenuItem,
            this.àProposToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(525, 24);
            this.MenuStrip.TabIndex = 3;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // circuitsToolStripMenuItem
            // 
            this.circuitsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.modifierToolStripMenuItem,
            this.afficherToolStripMenuItem});
            this.circuitsToolStripMenuItem.Name = "circuitsToolStripMenuItem";
            this.circuitsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.circuitsToolStripMenuItem.Text = "Circuits";
            // 
            // monumentsToolStripMenuItem
            // 
            this.monumentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordonnerSelonToolStripMenuItem});
            this.monumentsToolStripMenuItem.Name = "monumentsToolStripMenuItem";
            this.monumentsToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.monumentsToolStripMenuItem.Text = "Monuments";
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // àProposToolStripMenuItem
            // 
            this.àProposToolStripMenuItem.Name = "àProposToolStripMenuItem";
            this.àProposToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.àProposToolStripMenuItem.Text = "À propos";
            // 
            // connexionToolStripMenuItem
            // 
            this.connexionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seConnecterToolStripMenuItem,
            this.seDéconnecterToolStripMenuItem});
            this.connexionToolStripMenuItem.Name = "connexionToolStripMenuItem";
            this.connexionToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.connexionToolStripMenuItem.Text = "Connexion";
            // 
            // seConnecterToolStripMenuItem
            // 
            this.seConnecterToolStripMenuItem.Name = "seConnecterToolStripMenuItem";
            this.seConnecterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.seConnecterToolStripMenuItem.Text = "Se connecter";
            // 
            // seDéconnecterToolStripMenuItem
            // 
            this.seDéconnecterToolStripMenuItem.Name = "seDéconnecterToolStripMenuItem";
            this.seDéconnecterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.seDéconnecterToolStripMenuItem.Text = "Se déconnecter";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.modifierToolStripMenuItem.Text = "Modifier";
            // 
            // afficherToolStripMenuItem
            // 
            this.afficherToolStripMenuItem.Name = "afficherToolStripMenuItem";
            this.afficherToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.afficherToolStripMenuItem.Text = "Afficher les monuments";
            // 
            // ordonnerSelonToolStripMenuItem
            // 
            this.ordonnerSelonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cotationToolStripMenuItem,
            this.meilleurToolStripMenuItem});
            this.ordonnerSelonToolStripMenuItem.Name = "ordonnerSelonToolStripMenuItem";
            this.ordonnerSelonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ordonnerSelonToolStripMenuItem.Text = "Ordonner selon:";
            // 
            // cotationToolStripMenuItem
            // 
            this.cotationToolStripMenuItem.Name = "cotationToolStripMenuItem";
            this.cotationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cotationToolStripMenuItem.Text = "Cotation";
            // 
            // meilleurToolStripMenuItem
            // 
            this.meilleurToolStripMenuItem.Name = "meilleurToolStripMenuItem";
            this.meilleurToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.meilleurToolStripMenuItem.Text = "Meilleur";
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
            this.Text = "MainForm";
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
        private System.Windows.Forms.ToolStripMenuItem connexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seConnecterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seDéconnecterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circuitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monumentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordonnerSelonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cotationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meilleurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem àProposToolStripMenuItem;
    }
}

