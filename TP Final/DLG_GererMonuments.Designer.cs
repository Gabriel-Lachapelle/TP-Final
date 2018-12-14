namespace TP_Final
{
    partial class DLG_GererMonuments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DLG_GererMonuments));
            this.LBL_Nom = new System.Windows.Forms.Label();
            this.LBL_Cout = new System.Windows.Forms.Label();
            this.LBL_Histoire = new System.Windows.Forms.Label();
            this.TBX_Nom = new System.Windows.Forms.TextBox();
            this.TBX_Cout = new System.Windows.Forms.TextBox();
            this.RTBX_Histoire = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.FB_Suivant = new Calculator.FlashButton();
            this.FB_Precedent = new Calculator.FlashButton();
            this.PBX_Monument = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Monument)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_Nom
            // 
            this.LBL_Nom.AutoSize = true;
            this.LBL_Nom.Location = new System.Drawing.Point(10, 230);
            this.LBL_Nom.Margin = new System.Windows.Forms.Padding(10);
            this.LBL_Nom.Name = "LBL_Nom";
            this.LBL_Nom.Size = new System.Drawing.Size(37, 16);
            this.LBL_Nom.TabIndex = 1;
            this.LBL_Nom.Text = "Nom";
            // 
            // LBL_Cout
            // 
            this.LBL_Cout.AutoSize = true;
            this.LBL_Cout.Location = new System.Drawing.Point(10, 266);
            this.LBL_Cout.Margin = new System.Windows.Forms.Padding(10);
            this.LBL_Cout.Name = "LBL_Cout";
            this.LBL_Cout.Size = new System.Drawing.Size(35, 16);
            this.LBL_Cout.TabIndex = 2;
            this.LBL_Cout.Text = "Coût";
            // 
            // LBL_Histoire
            // 
            this.LBL_Histoire.AutoSize = true;
            this.LBL_Histoire.Location = new System.Drawing.Point(10, 302);
            this.LBL_Histoire.Margin = new System.Windows.Forms.Padding(10);
            this.LBL_Histoire.Name = "LBL_Histoire";
            this.LBL_Histoire.Size = new System.Drawing.Size(54, 16);
            this.LBL_Histoire.TabIndex = 3;
            this.LBL_Histoire.Text = "Histoire";
            // 
            // TBX_Nom
            // 
            this.TBX_Nom.Location = new System.Drawing.Point(89, 227);
            this.TBX_Nom.Name = "TBX_Nom";
            this.TBX_Nom.ReadOnly = true;
            this.TBX_Nom.Size = new System.Drawing.Size(195, 22);
            this.TBX_Nom.TabIndex = 16;
            // 
            // TBX_Cout
            // 
            this.TBX_Cout.Location = new System.Drawing.Point(89, 263);
            this.TBX_Cout.Name = "TBX_Cout";
            this.TBX_Cout.ReadOnly = true;
            this.TBX_Cout.Size = new System.Drawing.Size(195, 22);
            this.TBX_Cout.TabIndex = 17;
            // 
            // RTBX_Histoire
            // 
            this.RTBX_Histoire.Location = new System.Drawing.Point(89, 299);
            this.RTBX_Histoire.Name = "RTBX_Histoire";
            this.RTBX_Histoire.ReadOnly = true;
            this.RTBX_Histoire.Size = new System.Drawing.Size(195, 96);
            this.RTBX_Histoire.TabIndex = 18;
            this.RTBX_Histoire.Text = "";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(224, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Retour";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FB_Suivant
            // 
            this.FB_Suivant.BackgroundImage = global::TP_Final.Properties.Resources.Next_Neutral;
            this.FB_Suivant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FB_Suivant.ClickedImage = global::TP_Final.Properties.Resources.Next_Clicked;
            this.FB_Suivant.DisabledImage = global::TP_Final.Properties.Resources.Next_Disabled;
            this.FB_Suivant.Image = ((System.Drawing.Image)(resources.GetObject("FB_Suivant.Image")));
            this.FB_Suivant.Location = new System.Drawing.Point(244, 176);
            this.FB_Suivant.Margin = new System.Windows.Forms.Padding(4);
            this.FB_Suivant.Name = "FB_Suivant";
            this.FB_Suivant.NeutralImage = global::TP_Final.Properties.Resources.Next_Neutral;
            this.FB_Suivant.OverImage = global::TP_Final.Properties.Resources.Next_Hover;
            this.FB_Suivant.Size = new System.Drawing.Size(40, 40);
            this.FB_Suivant.TabIndex = 15;
            this.FB_Suivant.UseVisualStyleBackColor = true;
            // 
            // FB_Precedent
            // 
            this.FB_Precedent.BackgroundImage = global::TP_Final.Properties.Resources.Previous_Neutral;
            this.FB_Precedent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FB_Precedent.ClickedImage = global::TP_Final.Properties.Resources.Previous_Clicked;
            this.FB_Precedent.DisabledImage = global::TP_Final.Properties.Resources.Previous_Disabled;
            this.FB_Precedent.Image = ((System.Drawing.Image)(resources.GetObject("FB_Precedent.Image")));
            this.FB_Precedent.Location = new System.Drawing.Point(13, 176);
            this.FB_Precedent.Margin = new System.Windows.Forms.Padding(4);
            this.FB_Precedent.Name = "FB_Precedent";
            this.FB_Precedent.NeutralImage = global::TP_Final.Properties.Resources.Previous_Neutral;
            this.FB_Precedent.OverImage = global::TP_Final.Properties.Resources.Previous_Hover;
            this.FB_Precedent.Size = new System.Drawing.Size(40, 40);
            this.FB_Precedent.TabIndex = 14;
            this.FB_Precedent.UseVisualStyleBackColor = true;
            // 
            // PBX_Monument
            // 
            this.PBX_Monument.Location = new System.Drawing.Point(13, 13);
            this.PBX_Monument.Margin = new System.Windows.Forms.Padding(4);
            this.PBX_Monument.Name = "PBX_Monument";
            this.PBX_Monument.Size = new System.Drawing.Size(271, 155);
            this.PBX_Monument.TabIndex = 0;
            this.PBX_Monument.TabStop = false;
            // 
            // DLG_ListeMonuments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 435);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RTBX_Histoire);
            this.Controls.Add(this.TBX_Cout);
            this.Controls.Add(this.TBX_Nom);
            this.Controls.Add(this.FB_Suivant);
            this.Controls.Add(this.FB_Precedent);
            this.Controls.Add(this.LBL_Histoire);
            this.Controls.Add(this.LBL_Cout);
            this.Controls.Add(this.LBL_Nom);
            this.Controls.Add(this.PBX_Monument);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DLG_ListeMonuments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DLG_ListeMonuments";
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Monument)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBX_Monument;
        private System.Windows.Forms.Label LBL_Nom;
        private System.Windows.Forms.Label LBL_Cout;
        private System.Windows.Forms.Label LBL_Histoire;
        private Calculator.FlashButton FB_Precedent;
        private Calculator.FlashButton FB_Suivant;
        private System.Windows.Forms.TextBox TBX_Nom;
        private System.Windows.Forms.TextBox TBX_Cout;
        private System.Windows.Forms.RichTextBox RTBX_Histoire;
        private System.Windows.Forms.Button button1;
    }
}