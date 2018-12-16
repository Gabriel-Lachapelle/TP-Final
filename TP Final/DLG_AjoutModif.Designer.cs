namespace TP_Final
{
    partial class DLG_AjoutModif
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LBL_VilleDepart = new System.Windows.Forms.Label();
            this.LBL_VilleArrivee = new System.Windows.Forms.Label();
            this.LBL_Nom = new System.Windows.Forms.Label();
            this.LBL_Duree = new System.Windows.Forms.Label();
            this.LBL_Prix = new System.Windows.Forms.Label();
            this.LBL_ClientsMax = new System.Windows.Forms.Label();
            this.CBX_VilleDepart = new System.Windows.Forms.ComboBox();
            this.CBX_VilleArrivee = new System.Windows.Forms.ComboBox();
            this.GBX_Infos = new System.Windows.Forms.GroupBox();
            this.TBX_Duree = new System.Windows.Forms.TextBox();
            this.TBX_Prix = new System.Windows.Forms.TextBox();
            this.TBX_ClientsMax = new System.Windows.Forms.TextBox();
            this.TBX_Nom = new System.Windows.Forms.TextBox();
            this.BTN_Ok = new System.Windows.Forms.Button();
            this.BTN_Annuler = new System.Windows.Forms.Button();
            this.GBX_Infos.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBL_VilleDepart
            // 
            this.LBL_VilleDepart.AutoSize = true;
            this.LBL_VilleDepart.Location = new System.Drawing.Point(20, 64);
            this.LBL_VilleDepart.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.LBL_VilleDepart.Name = "LBL_VilleDepart";
            this.LBL_VilleDepart.Size = new System.Drawing.Size(95, 16);
            this.LBL_VilleDepart.TabIndex = 0;
            this.LBL_VilleDepart.Text = "Ville de départ";
            // 
            // LBL_VilleArrivee
            // 
            this.LBL_VilleArrivee.AutoSize = true;
            this.LBL_VilleArrivee.Location = new System.Drawing.Point(20, 100);
            this.LBL_VilleArrivee.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.LBL_VilleArrivee.Name = "LBL_VilleArrivee";
            this.LBL_VilleArrivee.Size = new System.Drawing.Size(90, 16);
            this.LBL_VilleArrivee.TabIndex = 1;
            this.LBL_VilleArrivee.Text = "Ville d\'arrivée";
            // 
            // LBL_Nom
            // 
            this.LBL_Nom.AutoSize = true;
            this.LBL_Nom.Location = new System.Drawing.Point(20, 28);
            this.LBL_Nom.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.LBL_Nom.Name = "LBL_Nom";
            this.LBL_Nom.Size = new System.Drawing.Size(92, 16);
            this.LBL_Nom.TabIndex = 2;
            this.LBL_Nom.Text = "Nom du circuit";
            // 
            // LBL_Duree
            // 
            this.LBL_Duree.AutoSize = true;
            this.LBL_Duree.Location = new System.Drawing.Point(20, 136);
            this.LBL_Duree.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.LBL_Duree.Name = "LBL_Duree";
            this.LBL_Duree.Size = new System.Drawing.Size(89, 16);
            this.LBL_Duree.TabIndex = 3;
            this.LBL_Duree.Text = "Durée (Jours)";
            // 
            // LBL_Prix
            // 
            this.LBL_Prix.AutoSize = true;
            this.LBL_Prix.Location = new System.Drawing.Point(20, 172);
            this.LBL_Prix.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.LBL_Prix.Name = "LBL_Prix";
            this.LBL_Prix.Size = new System.Drawing.Size(30, 16);
            this.LBL_Prix.TabIndex = 4;
            this.LBL_Prix.Text = "Prix";
            // 
            // LBL_ClientsMax
            // 
            this.LBL_ClientsMax.AutoSize = true;
            this.LBL_ClientsMax.Location = new System.Drawing.Point(20, 199);
            this.LBL_ClientsMax.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.LBL_ClientsMax.Name = "LBL_ClientsMax";
            this.LBL_ClientsMax.Size = new System.Drawing.Size(145, 16);
            this.LBL_ClientsMax.TabIndex = 5;
            this.LBL_ClientsMax.Text = "Nombre de clients max";
            // 
            // CBX_VilleDepart
            // 
            this.CBX_VilleDepart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CBX_VilleDepart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBX_VilleDepart.FormattingEnabled = true;
            this.CBX_VilleDepart.Location = new System.Drawing.Point(173, 61);
            this.CBX_VilleDepart.Name = "CBX_VilleDepart";
            this.CBX_VilleDepart.Size = new System.Drawing.Size(136, 24);
            this.CBX_VilleDepart.TabIndex = 6;
            // 
            // CBX_VilleArrivee
            // 
            this.CBX_VilleArrivee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CBX_VilleArrivee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBX_VilleArrivee.FormattingEnabled = true;
            this.CBX_VilleArrivee.Location = new System.Drawing.Point(173, 97);
            this.CBX_VilleArrivee.Name = "CBX_VilleArrivee";
            this.CBX_VilleArrivee.Size = new System.Drawing.Size(136, 24);
            this.CBX_VilleArrivee.TabIndex = 7;
            // 
            // GBX_Infos
            // 
            this.GBX_Infos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBX_Infos.Controls.Add(this.TBX_Duree);
            this.GBX_Infos.Controls.Add(this.CBX_VilleArrivee);
            this.GBX_Infos.Controls.Add(this.TBX_Prix);
            this.GBX_Infos.Controls.Add(this.TBX_ClientsMax);
            this.GBX_Infos.Controls.Add(this.TBX_Nom);
            this.GBX_Infos.Controls.Add(this.LBL_Nom);
            this.GBX_Infos.Controls.Add(this.CBX_VilleDepart);
            this.GBX_Infos.Controls.Add(this.LBL_VilleDepart);
            this.GBX_Infos.Controls.Add(this.LBL_ClientsMax);
            this.GBX_Infos.Controls.Add(this.LBL_VilleArrivee);
            this.GBX_Infos.Controls.Add(this.LBL_Prix);
            this.GBX_Infos.Controls.Add(this.LBL_Duree);
            this.GBX_Infos.Location = new System.Drawing.Point(12, 12);
            this.GBX_Infos.Name = "GBX_Infos";
            this.GBX_Infos.Size = new System.Drawing.Size(335, 230);
            this.GBX_Infos.TabIndex = 8;
            this.GBX_Infos.TabStop = false;
            this.GBX_Infos.Text = "Informations du circuit";
            // 
            // TBX_Duree
            // 
            this.TBX_Duree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBX_Duree.Location = new System.Drawing.Point(219, 130);
            this.TBX_Duree.MaxLength = 4;
            this.TBX_Duree.Name = "TBX_Duree";
            this.TBX_Duree.Size = new System.Drawing.Size(90, 22);
            this.TBX_Duree.TabIndex = 9;
            this.TBX_Duree.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numbers_KeyPress);
            // 
            // TBX_Prix
            // 
            this.TBX_Prix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBX_Prix.Location = new System.Drawing.Point(219, 166);
            this.TBX_Prix.MaxLength = 4;
            this.TBX_Prix.Name = "TBX_Prix";
            this.TBX_Prix.Size = new System.Drawing.Size(90, 22);
            this.TBX_Prix.TabIndex = 8;
            this.TBX_Prix.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numbers_KeyPress);
            // 
            // TBX_ClientsMax
            // 
            this.TBX_ClientsMax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBX_ClientsMax.Location = new System.Drawing.Point(219, 194);
            this.TBX_ClientsMax.MaxLength = 3;
            this.TBX_ClientsMax.Name = "TBX_ClientsMax";
            this.TBX_ClientsMax.Size = new System.Drawing.Size(90, 22);
            this.TBX_ClientsMax.TabIndex = 7;
            this.TBX_ClientsMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numbers_KeyPress);
            // 
            // TBX_Nom
            // 
            this.TBX_Nom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBX_Nom.Location = new System.Drawing.Point(173, 25);
            this.TBX_Nom.Name = "TBX_Nom";
            this.TBX_Nom.Size = new System.Drawing.Size(136, 22);
            this.TBX_Nom.TabIndex = 4;
            // 
            // BTN_Ok
            // 
            this.BTN_Ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_Ok.Location = new System.Drawing.Point(272, 248);
            this.BTN_Ok.Name = "BTN_Ok";
            this.BTN_Ok.Size = new System.Drawing.Size(75, 23);
            this.BTN_Ok.TabIndex = 9;
            this.BTN_Ok.Text = "Ajouter";
            this.BTN_Ok.UseVisualStyleBackColor = true;
            this.BTN_Ok.Click += new System.EventHandler(this.BTN_Ok_Click);
            // 
            // BTN_Annuler
            // 
            this.BTN_Annuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Annuler.Location = new System.Drawing.Point(191, 248);
            this.BTN_Annuler.Name = "BTN_Annuler";
            this.BTN_Annuler.Size = new System.Drawing.Size(75, 23);
            this.BTN_Annuler.TabIndex = 10;
            this.BTN_Annuler.Text = "Annuler";
            this.BTN_Annuler.UseVisualStyleBackColor = true;
            // 
            // DLG_AjoutModif
            // 
            this.AcceptButton = this.BTN_Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTN_Annuler;
            this.ClientSize = new System.Drawing.Size(358, 281);
            this.Controls.Add(this.BTN_Annuler);
            this.Controls.Add(this.BTN_Ok);
            this.Controls.Add(this.GBX_Infos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 320);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(320, 320);
            this.Name = "DLG_AjoutModif";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajout d\'un circuit";
            this.Load += new System.EventHandler(this.DLG_AjoutModif_Load);
            this.GBX_Infos.ResumeLayout(false);
            this.GBX_Infos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LBL_VilleDepart;
        private System.Windows.Forms.Label LBL_VilleArrivee;
        private System.Windows.Forms.Label LBL_Nom;
        private System.Windows.Forms.Label LBL_Duree;
        private System.Windows.Forms.Label LBL_Prix;
        private System.Windows.Forms.Label LBL_ClientsMax;
        private System.Windows.Forms.ComboBox CBX_VilleDepart;
        private System.Windows.Forms.ComboBox CBX_VilleArrivee;
        private System.Windows.Forms.GroupBox GBX_Infos;
        private System.Windows.Forms.TextBox TBX_Duree;
        private System.Windows.Forms.TextBox TBX_Prix;
        private System.Windows.Forms.TextBox TBX_ClientsMax;
        private System.Windows.Forms.TextBox TBX_Nom;
        private System.Windows.Forms.Button BTN_Ok;
        private System.Windows.Forms.Button BTN_Annuler;
    }
}