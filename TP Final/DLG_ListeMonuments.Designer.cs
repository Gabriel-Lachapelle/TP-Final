namespace TP_Final
{
    partial class DLG_ListeMonuments
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DLG_ListeMonuments));
            this.GBX_Monuments = new System.Windows.Forms.GroupBox();
            this.LBL_Histoire = new System.Windows.Forms.Label();
            this.LBL_Cout = new System.Windows.Forms.Label();
            this.LBL_Nom = new System.Windows.Forms.Label();
            this.RTBX_Histoire = new System.Windows.Forms.RichTextBox();
            this.TBX_Cout = new System.Windows.Forms.TextBox();
            this.TBX_Nom = new System.Windows.Forms.TextBox();
            this.TBX_NomCircuit = new System.Windows.Forms.TextBox();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.FB_Precedent = new Calculator.FlashButton();
            this.FB_Prochain = new Calculator.FlashButton();
            this.PBX_Image = new System.Windows.Forms.PictureBox();
            this.GBX_Monuments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // GBX_Monuments
            // 
            this.GBX_Monuments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBX_Monuments.Controls.Add(this.FB_Precedent);
            this.GBX_Monuments.Controls.Add(this.FB_Prochain);
            this.GBX_Monuments.Controls.Add(this.LBL_Histoire);
            this.GBX_Monuments.Controls.Add(this.LBL_Cout);
            this.GBX_Monuments.Controls.Add(this.LBL_Nom);
            this.GBX_Monuments.Controls.Add(this.RTBX_Histoire);
            this.GBX_Monuments.Controls.Add(this.TBX_Cout);
            this.GBX_Monuments.Controls.Add(this.TBX_Nom);
            this.GBX_Monuments.Controls.Add(this.PBX_Image);
            this.GBX_Monuments.Controls.Add(this.TBX_NomCircuit);
            this.GBX_Monuments.Location = new System.Drawing.Point(13, 13);
            this.GBX_Monuments.Name = "GBX_Monuments";
            this.GBX_Monuments.Size = new System.Drawing.Size(606, 310);
            this.GBX_Monuments.TabIndex = 0;
            this.GBX_Monuments.TabStop = false;
            this.GBX_Monuments.Text = "Monuments du circuit";
            // 
            // LBL_Histoire
            // 
            this.LBL_Histoire.AutoSize = true;
            this.LBL_Histoire.Location = new System.Drawing.Point(214, 156);
            this.LBL_Histoire.Margin = new System.Windows.Forms.Padding(5, 5, 5, 2);
            this.LBL_Histoire.Name = "LBL_Histoire";
            this.LBL_Histoire.Size = new System.Drawing.Size(54, 16);
            this.LBL_Histoire.TabIndex = 8;
            this.LBL_Histoire.Text = "Histoire";
            // 
            // LBL_Cout
            // 
            this.LBL_Cout.AutoSize = true;
            this.LBL_Cout.Location = new System.Drawing.Point(214, 105);
            this.LBL_Cout.Margin = new System.Windows.Forms.Padding(5, 5, 5, 2);
            this.LBL_Cout.Name = "LBL_Cout";
            this.LBL_Cout.Size = new System.Drawing.Size(102, 16);
            this.LBL_Cout.TabIndex = 7;
            this.LBL_Cout.Text = "Coût de la visite";
            // 
            // LBL_Nom
            // 
            this.LBL_Nom.AutoSize = true;
            this.LBL_Nom.Location = new System.Drawing.Point(213, 54);
            this.LBL_Nom.Margin = new System.Windows.Forms.Padding(5, 5, 5, 2);
            this.LBL_Nom.Name = "LBL_Nom";
            this.LBL_Nom.Size = new System.Drawing.Size(37, 16);
            this.LBL_Nom.TabIndex = 6;
            this.LBL_Nom.Text = "Nom";
            // 
            // RTBX_Histoire
            // 
            this.RTBX_Histoire.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RTBX_Histoire.Location = new System.Drawing.Point(216, 177);
            this.RTBX_Histoire.Name = "RTBX_Histoire";
            this.RTBX_Histoire.ReadOnly = true;
            this.RTBX_Histoire.Size = new System.Drawing.Size(376, 127);
            this.RTBX_Histoire.TabIndex = 5;
            this.RTBX_Histoire.Text = "";
            // 
            // TBX_Cout
            // 
            this.TBX_Cout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBX_Cout.Location = new System.Drawing.Point(217, 126);
            this.TBX_Cout.Name = "TBX_Cout";
            this.TBX_Cout.ReadOnly = true;
            this.TBX_Cout.Size = new System.Drawing.Size(375, 22);
            this.TBX_Cout.TabIndex = 4;
            // 
            // TBX_Nom
            // 
            this.TBX_Nom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBX_Nom.Location = new System.Drawing.Point(217, 75);
            this.TBX_Nom.Name = "TBX_Nom";
            this.TBX_Nom.ReadOnly = true;
            this.TBX_Nom.Size = new System.Drawing.Size(375, 22);
            this.TBX_Nom.TabIndex = 3;
            // 
            // TBX_NomCircuit
            // 
            this.TBX_NomCircuit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBX_NomCircuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBX_NomCircuit.Location = new System.Drawing.Point(6, 21);
            this.TBX_NomCircuit.Name = "TBX_NomCircuit";
            this.TBX_NomCircuit.ReadOnly = true;
            this.TBX_NomCircuit.Size = new System.Drawing.Size(586, 22);
            this.TBX_NomCircuit.TabIndex = 0;
            this.TBX_NomCircuit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FB_Precedent
            // 
            this.FB_Precedent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FB_Precedent.BackgroundImage = global::TP_Final.Properties.Resources.Previous_Neutral;
            this.FB_Precedent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FB_Precedent.ClickedImage = global::TP_Final.Properties.Resources.Previous_Clicked;
            this.FB_Precedent.DisabledImage = global::TP_Final.Properties.Resources.Previous_Disabled;
            this.FB_Precedent.Image = ((System.Drawing.Image)(resources.GetObject("FB_Precedent.Image")));
            this.FB_Precedent.Location = new System.Drawing.Point(6, 258);
            this.FB_Precedent.Margin = new System.Windows.Forms.Padding(4);
            this.FB_Precedent.Name = "FB_Precedent";
            this.FB_Precedent.NeutralImage = global::TP_Final.Properties.Resources.Previous_Neutral;
            this.FB_Precedent.OverImage = global::TP_Final.Properties.Resources.Previous_Hover;
            this.FB_Precedent.Size = new System.Drawing.Size(40, 40);
            this.FB_Precedent.TabIndex = 22;
            this.FB_Precedent.Text = "Afficher les monuments du circuit";
            this.ToolTip.SetToolTip(this.FB_Precedent, "Voir monument précedent");
            this.FB_Precedent.UseVisualStyleBackColor = true;
            this.FB_Precedent.Click += new System.EventHandler(this.FB_Precedent_Click);
            // 
            // FB_Prochain
            // 
            this.FB_Prochain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FB_Prochain.BackgroundImage = global::TP_Final.Properties.Resources.Next_Neutral;
            this.FB_Prochain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FB_Prochain.ClickedImage = global::TP_Final.Properties.Resources.Next_Clicked;
            this.FB_Prochain.DisabledImage = global::TP_Final.Properties.Resources.Next_Disabled;
            this.FB_Prochain.Image = ((System.Drawing.Image)(resources.GetObject("FB_Prochain.Image")));
            this.FB_Prochain.Location = new System.Drawing.Point(163, 258);
            this.FB_Prochain.Margin = new System.Windows.Forms.Padding(4);
            this.FB_Prochain.Name = "FB_Prochain";
            this.FB_Prochain.NeutralImage = global::TP_Final.Properties.Resources.Next_Neutral;
            this.FB_Prochain.OverImage = global::TP_Final.Properties.Resources.Next_Hover;
            this.FB_Prochain.Size = new System.Drawing.Size(40, 40);
            this.FB_Prochain.TabIndex = 21;
            this.FB_Prochain.Text = "Afficher les monuments du circuit";
            this.ToolTip.SetToolTip(this.FB_Prochain, "Voir prochain monument");
            this.FB_Prochain.UseVisualStyleBackColor = true;
            this.FB_Prochain.Click += new System.EventHandler(this.FB_Prochain_Click);
            // 
            // PBX_Image
            // 
            this.PBX_Image.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PBX_Image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBX_Image.Location = new System.Drawing.Point(6, 49);
            this.PBX_Image.Name = "PBX_Image";
            this.PBX_Image.Size = new System.Drawing.Size(197, 202);
            this.PBX_Image.TabIndex = 2;
            this.PBX_Image.TabStop = false;
            // 
            // DLG_ListeMonuments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 331);
            this.Controls.Add(this.GBX_Monuments);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "DLG_ListeMonuments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DLG_ListeMonuments";
            this.Load += new System.EventHandler(this.DLG_GererMonuments_Load);
            this.GBX_Monuments.ResumeLayout(false);
            this.GBX_Monuments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBX_Monuments;
        private System.Windows.Forms.TextBox TBX_NomCircuit;
        private System.Windows.Forms.PictureBox PBX_Image;
        private System.Windows.Forms.Label LBL_Histoire;
        private System.Windows.Forms.Label LBL_Cout;
        private System.Windows.Forms.Label LBL_Nom;
        private System.Windows.Forms.RichTextBox RTBX_Histoire;
        private System.Windows.Forms.TextBox TBX_Cout;
        private System.Windows.Forms.TextBox TBX_Nom;
        private Calculator.FlashButton FB_Precedent;
        private Calculator.FlashButton FB_Prochain;
        private System.Windows.Forms.ToolTip ToolTip;
    }
}