namespace TP_Final
{
    partial class DLG_AjoutMonument
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DLG_AjoutMonument));
            this.TBX_Nom = new System.Windows.Forms.TextBox();
            this.TBX_Annee = new System.Windows.Forms.TextBox();
            this.TBX_Prix = new System.Windows.Forms.TextBox();
            this.RTBX_Histoire = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GBX_Details = new System.Windows.Forms.GroupBox();
            this.BTN_Ajouter = new System.Windows.Forms.Button();
            this.BTN_Annuler = new System.Windows.Forms.Button();
            this.FB_Etoile_5 = new Calculator.FlashButton();
            this.FB_Etoile_4 = new Calculator.FlashButton();
            this.FB_Etoile_3 = new Calculator.FlashButton();
            this.FB_Etoile_2 = new Calculator.FlashButton();
            this.FB_Etoile_1 = new Calculator.FlashButton();
            this.PBX_Image = new System.Windows.Forms.PictureBox();
            this.GBX_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // TBX_Nom
            // 
            this.TBX_Nom.Location = new System.Drawing.Point(281, 41);
            this.TBX_Nom.Margin = new System.Windows.Forms.Padding(4, 2, 4, 4);
            this.TBX_Nom.Name = "TBX_Nom";
            this.TBX_Nom.Size = new System.Drawing.Size(137, 22);
            this.TBX_Nom.TabIndex = 0;
            // 
            // TBX_Annee
            // 
            this.TBX_Annee.Location = new System.Drawing.Point(281, 102);
            this.TBX_Annee.Margin = new System.Windows.Forms.Padding(4, 2, 4, 4);
            this.TBX_Annee.Name = "TBX_Annee";
            this.TBX_Annee.Size = new System.Drawing.Size(137, 22);
            this.TBX_Annee.TabIndex = 1;
            this.TBX_Annee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numbers_KeyPress);
            // 
            // TBX_Prix
            // 
            this.TBX_Prix.Location = new System.Drawing.Point(281, 161);
            this.TBX_Prix.Margin = new System.Windows.Forms.Padding(4, 2, 4, 4);
            this.TBX_Prix.Name = "TBX_Prix";
            this.TBX_Prix.Size = new System.Drawing.Size(137, 22);
            this.TBX_Prix.TabIndex = 2;
            this.TBX_Prix.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numbers_KeyPress);
            // 
            // RTBX_Histoire
            // 
            this.RTBX_Histoire.Location = new System.Drawing.Point(451, 43);
            this.RTBX_Histoire.Margin = new System.Windows.Forms.Padding(4);
            this.RTBX_Histoire.Name = "RTBX_Histoire";
            this.RTBX_Histoire.Size = new System.Drawing.Size(203, 142);
            this.RTBX_Histoire.TabIndex = 3;
            this.RTBX_Histoire.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 10, 10, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 10, 10, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Annee de construction";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 10, 10, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Prix";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(448, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 10, 10, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Histoire";
            // 
            // GBX_Details
            // 
            this.GBX_Details.Controls.Add(this.BTN_Ajouter);
            this.GBX_Details.Controls.Add(this.BTN_Annuler);
            this.GBX_Details.Controls.Add(this.FB_Etoile_5);
            this.GBX_Details.Controls.Add(this.FB_Etoile_4);
            this.GBX_Details.Controls.Add(this.FB_Etoile_3);
            this.GBX_Details.Controls.Add(this.FB_Etoile_2);
            this.GBX_Details.Controls.Add(this.FB_Etoile_1);
            this.GBX_Details.Controls.Add(this.PBX_Image);
            this.GBX_Details.Controls.Add(this.label1);
            this.GBX_Details.Controls.Add(this.label4);
            this.GBX_Details.Controls.Add(this.TBX_Nom);
            this.GBX_Details.Controls.Add(this.label3);
            this.GBX_Details.Controls.Add(this.TBX_Annee);
            this.GBX_Details.Controls.Add(this.label2);
            this.GBX_Details.Controls.Add(this.TBX_Prix);
            this.GBX_Details.Controls.Add(this.RTBX_Histoire);
            this.GBX_Details.Location = new System.Drawing.Point(13, 13);
            this.GBX_Details.Margin = new System.Windows.Forms.Padding(4);
            this.GBX_Details.Name = "GBX_Details";
            this.GBX_Details.Padding = new System.Windows.Forms.Padding(4);
            this.GBX_Details.Size = new System.Drawing.Size(679, 237);
            this.GBX_Details.TabIndex = 8;
            this.GBX_Details.TabStop = false;
            this.GBX_Details.Text = "Détails";
            // 
            // BTN_Ajouter
            // 
            this.BTN_Ajouter.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_Ajouter.Location = new System.Drawing.Point(579, 207);
            this.BTN_Ajouter.Name = "BTN_Ajouter";
            this.BTN_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.BTN_Ajouter.TabIndex = 9;
            this.BTN_Ajouter.Text = "Ajouter";
            this.BTN_Ajouter.UseVisualStyleBackColor = true;
            this.BTN_Ajouter.Click += new System.EventHandler(this.BTN_Ajouter_Click);
            // 
            // BTN_Annuler
            // 
            this.BTN_Annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Annuler.Location = new System.Drawing.Point(498, 207);
            this.BTN_Annuler.Name = "BTN_Annuler";
            this.BTN_Annuler.Size = new System.Drawing.Size(75, 23);
            this.BTN_Annuler.TabIndex = 10;
            this.BTN_Annuler.Text = "Annuler";
            this.BTN_Annuler.UseVisualStyleBackColor = true;
            this.BTN_Annuler.Click += new System.EventHandler(this.BTN_Annuler_Click);
            // 
            // FB_Etoile_5
            // 
            this.FB_Etoile_5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FB_Etoile_5.BackgroundImage = global::TP_Final.Properties.Resources.Star_Disabled;
            this.FB_Etoile_5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FB_Etoile_5.ClickedImage = global::TP_Final.Properties.Resources.Star_Hover;
            this.FB_Etoile_5.DisabledImage = global::TP_Final.Properties.Resources.Star_Disabled;
            this.FB_Etoile_5.Image = ((System.Drawing.Image)(resources.GetObject("FB_Etoile_5.Image")));
            this.FB_Etoile_5.Location = new System.Drawing.Point(216, 190);
            this.FB_Etoile_5.Margin = new System.Windows.Forms.Padding(4);
            this.FB_Etoile_5.Name = "FB_Etoile_5";
            this.FB_Etoile_5.NeutralImage = global::TP_Final.Properties.Resources.Star_Neutral;
            this.FB_Etoile_5.OverImage = global::TP_Final.Properties.Resources.Star_Clicked;
            this.FB_Etoile_5.Size = new System.Drawing.Size(40, 40);
            this.FB_Etoile_5.TabIndex = 18;
            this.FB_Etoile_5.Text = "Gérer les monuments du circuit";
            this.FB_Etoile_5.UseVisualStyleBackColor = true;
            this.FB_Etoile_5.Click += new System.EventHandler(this.FB_Etoile_5_Click);
            // 
            // FB_Etoile_4
            // 
            this.FB_Etoile_4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FB_Etoile_4.BackgroundImage = global::TP_Final.Properties.Resources.Star_Disabled;
            this.FB_Etoile_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FB_Etoile_4.ClickedImage = global::TP_Final.Properties.Resources.Star_Hover;
            this.FB_Etoile_4.DisabledImage = global::TP_Final.Properties.Resources.Star_Disabled;
            this.FB_Etoile_4.Image = ((System.Drawing.Image)(resources.GetObject("FB_Etoile_4.Image")));
            this.FB_Etoile_4.Location = new System.Drawing.Point(168, 190);
            this.FB_Etoile_4.Margin = new System.Windows.Forms.Padding(4);
            this.FB_Etoile_4.Name = "FB_Etoile_4";
            this.FB_Etoile_4.NeutralImage = global::TP_Final.Properties.Resources.Star_Neutral;
            this.FB_Etoile_4.OverImage = global::TP_Final.Properties.Resources.Star_Clicked;
            this.FB_Etoile_4.Size = new System.Drawing.Size(40, 40);
            this.FB_Etoile_4.TabIndex = 17;
            this.FB_Etoile_4.Text = "Gérer les monuments du circuit";
            this.FB_Etoile_4.UseVisualStyleBackColor = true;
            this.FB_Etoile_4.Click += new System.EventHandler(this.FB_Etoile_4_Click);
            // 
            // FB_Etoile_3
            // 
            this.FB_Etoile_3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FB_Etoile_3.BackgroundImage = global::TP_Final.Properties.Resources.Star_Disabled;
            this.FB_Etoile_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FB_Etoile_3.ClickedImage = global::TP_Final.Properties.Resources.Star_Hover;
            this.FB_Etoile_3.DisabledImage = global::TP_Final.Properties.Resources.Star_Disabled;
            this.FB_Etoile_3.Image = ((System.Drawing.Image)(resources.GetObject("FB_Etoile_3.Image")));
            this.FB_Etoile_3.Location = new System.Drawing.Point(120, 190);
            this.FB_Etoile_3.Margin = new System.Windows.Forms.Padding(4);
            this.FB_Etoile_3.Name = "FB_Etoile_3";
            this.FB_Etoile_3.NeutralImage = global::TP_Final.Properties.Resources.Star_Neutral;
            this.FB_Etoile_3.OverImage = global::TP_Final.Properties.Resources.Star_Clicked;
            this.FB_Etoile_3.Size = new System.Drawing.Size(40, 40);
            this.FB_Etoile_3.TabIndex = 16;
            this.FB_Etoile_3.Text = "Gérer les monuments du circuit";
            this.FB_Etoile_3.UseVisualStyleBackColor = true;
            this.FB_Etoile_3.Click += new System.EventHandler(this.FB_Etoile_3_Click);
            // 
            // FB_Etoile_2
            // 
            this.FB_Etoile_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FB_Etoile_2.BackgroundImage = global::TP_Final.Properties.Resources.Star_Disabled;
            this.FB_Etoile_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FB_Etoile_2.ClickedImage = global::TP_Final.Properties.Resources.Star_Hover;
            this.FB_Etoile_2.DisabledImage = global::TP_Final.Properties.Resources.Star_Disabled;
            this.FB_Etoile_2.Image = ((System.Drawing.Image)(resources.GetObject("FB_Etoile_2.Image")));
            this.FB_Etoile_2.Location = new System.Drawing.Point(72, 190);
            this.FB_Etoile_2.Margin = new System.Windows.Forms.Padding(4);
            this.FB_Etoile_2.Name = "FB_Etoile_2";
            this.FB_Etoile_2.NeutralImage = global::TP_Final.Properties.Resources.Star_Neutral;
            this.FB_Etoile_2.OverImage = global::TP_Final.Properties.Resources.Star_Clicked;
            this.FB_Etoile_2.Size = new System.Drawing.Size(40, 40);
            this.FB_Etoile_2.TabIndex = 15;
            this.FB_Etoile_2.Text = "Gérer les monuments du circuit";
            this.FB_Etoile_2.UseVisualStyleBackColor = true;
            this.FB_Etoile_2.Click += new System.EventHandler(this.FB_Etoile_2_Click);
            // 
            // FB_Etoile_1
            // 
            this.FB_Etoile_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FB_Etoile_1.BackgroundImage = global::TP_Final.Properties.Resources.Star_Disabled;
            this.FB_Etoile_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FB_Etoile_1.ClickedImage = global::TP_Final.Properties.Resources.Star_Hover;
            this.FB_Etoile_1.DisabledImage = global::TP_Final.Properties.Resources.Star_Disabled;
            this.FB_Etoile_1.Image = ((System.Drawing.Image)(resources.GetObject("FB_Etoile_1.Image")));
            this.FB_Etoile_1.Location = new System.Drawing.Point(24, 190);
            this.FB_Etoile_1.Margin = new System.Windows.Forms.Padding(4);
            this.FB_Etoile_1.Name = "FB_Etoile_1";
            this.FB_Etoile_1.NeutralImage = global::TP_Final.Properties.Resources.Star_Neutral;
            this.FB_Etoile_1.OverImage = global::TP_Final.Properties.Resources.Star_Clicked;
            this.FB_Etoile_1.Size = new System.Drawing.Size(40, 40);
            this.FB_Etoile_1.TabIndex = 14;
            this.FB_Etoile_1.Text = "Gérer les monuments du circuit";
            this.FB_Etoile_1.UseVisualStyleBackColor = true;
            this.FB_Etoile_1.Click += new System.EventHandler(this.FB_Etoile_1_Click);
            // 
            // PBX_Image
            // 
            this.PBX_Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PBX_Image.Location = new System.Drawing.Point(24, 22);
            this.PBX_Image.Name = "PBX_Image";
            this.PBX_Image.Size = new System.Drawing.Size(232, 161);
            this.PBX_Image.TabIndex = 13;
            this.PBX_Image.TabStop = false;
            this.PBX_Image.DragDrop += new System.Windows.Forms.DragEventHandler(this.PBX_Image_DragDrop);
            this.PBX_Image.DragEnter += new System.Windows.Forms.DragEventHandler(this.PBX_Image_DragEnter);
            // 
            // DLG_AjoutMonument
            // 
            this.AcceptButton = this.BTN_Ajouter;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTN_Annuler;
            this.ClientSize = new System.Drawing.Size(705, 260);
            this.Controls.Add(this.GBX_Details);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DLG_AjoutMonument";
            this.ShowIcon = false;
            this.Text = "Ajout d\'un monument";
            this.Load += new System.EventHandler(this.DLG_AjoutMonument_Load);
            this.GBX_Details.ResumeLayout(false);
            this.GBX_Details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TBX_Nom;
        private System.Windows.Forms.TextBox TBX_Annee;
        private System.Windows.Forms.TextBox TBX_Prix;
        private System.Windows.Forms.RichTextBox RTBX_Histoire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox GBX_Details;
        private System.Windows.Forms.PictureBox PBX_Image;
        private System.Windows.Forms.Button BTN_Ajouter;
        private System.Windows.Forms.Button BTN_Annuler;
        private Calculator.FlashButton FB_Etoile_1;
        private Calculator.FlashButton FB_Etoile_5;
        private Calculator.FlashButton FB_Etoile_4;
        private Calculator.FlashButton FB_Etoile_3;
        private Calculator.FlashButton FB_Etoile_2;
    }
}