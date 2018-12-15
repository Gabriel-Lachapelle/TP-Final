namespace TP_Final
{
    partial class DLG_Connexion
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
            this.LBL_Nom = new System.Windows.Forms.Label();
            this.TBX_Nom = new System.Windows.Forms.TextBox();
            this.LBL_MDP = new System.Windows.Forms.Label();
            this.TBX_MDP = new System.Windows.Forms.TextBox();
            this.BTN_Connexion = new System.Windows.Forms.Button();
            this.BTN_Annuler = new System.Windows.Forms.Button();
            this.GBX_Info = new System.Windows.Forms.GroupBox();
            this.CBX_Souvenir = new System.Windows.Forms.CheckBox();
            this.GBX_Info.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBL_Nom
            // 
            this.LBL_Nom.AutoSize = true;
            this.LBL_Nom.Location = new System.Drawing.Point(23, 28);
            this.LBL_Nom.Margin = new System.Windows.Forms.Padding(10, 10, 5, 10);
            this.LBL_Nom.Name = "LBL_Nom";
            this.LBL_Nom.Size = new System.Drawing.Size(93, 16);
            this.LBL_Nom.TabIndex = 0;
            this.LBL_Nom.Text = "Nom d\'usager";
            // 
            // TBX_Nom
            // 
            this.TBX_Nom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBX_Nom.Location = new System.Drawing.Point(126, 25);
            this.TBX_Nom.Margin = new System.Windows.Forms.Padding(5, 10, 10, 10);
            this.TBX_Nom.Name = "TBX_Nom";
            this.TBX_Nom.Size = new System.Drawing.Size(145, 22);
            this.TBX_Nom.TabIndex = 1;
            this.TBX_Nom.TextChanged += new System.EventHandler(this.TBX_TextChanged);
            // 
            // LBL_MDP
            // 
            this.LBL_MDP.AutoSize = true;
            this.LBL_MDP.Location = new System.Drawing.Point(23, 64);
            this.LBL_MDP.Margin = new System.Windows.Forms.Padding(10, 10, 5, 10);
            this.LBL_MDP.Name = "LBL_MDP";
            this.LBL_MDP.Size = new System.Drawing.Size(90, 16);
            this.LBL_MDP.TabIndex = 2;
            this.LBL_MDP.Text = "Mot de passe";
            // 
            // TBX_MDP
            // 
            this.TBX_MDP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBX_MDP.Location = new System.Drawing.Point(126, 61);
            this.TBX_MDP.Margin = new System.Windows.Forms.Padding(5, 10, 10, 10);
            this.TBX_MDP.Name = "TBX_MDP";
            this.TBX_MDP.PasswordChar = '•';
            this.TBX_MDP.Size = new System.Drawing.Size(145, 22);
            this.TBX_MDP.TabIndex = 3;
            this.TBX_MDP.TextChanged += new System.EventHandler(this.TBX_TextChanged);
            // 
            // BTN_Connexion
            // 
            this.BTN_Connexion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Connexion.Enabled = false;
            this.BTN_Connexion.Location = new System.Drawing.Point(220, 152);
            this.BTN_Connexion.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Connexion.Name = "BTN_Connexion";
            this.BTN_Connexion.Size = new System.Drawing.Size(92, 28);
            this.BTN_Connexion.TabIndex = 4;
            this.BTN_Connexion.Text = "Connexion";
            this.BTN_Connexion.UseVisualStyleBackColor = true;
            this.BTN_Connexion.Click += new System.EventHandler(this.BTN_Connexion_Click);
            // 
            // BTN_Annuler
            // 
            this.BTN_Annuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Annuler.Location = new System.Drawing.Point(142, 152);
            this.BTN_Annuler.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Annuler.Name = "BTN_Annuler";
            this.BTN_Annuler.Size = new System.Drawing.Size(69, 28);
            this.BTN_Annuler.TabIndex = 5;
            this.BTN_Annuler.Text = "Annuler";
            this.BTN_Annuler.UseVisualStyleBackColor = true;
            // 
            // GBX_Info
            // 
            this.GBX_Info.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBX_Info.Controls.Add(this.CBX_Souvenir);
            this.GBX_Info.Controls.Add(this.LBL_Nom);
            this.GBX_Info.Controls.Add(this.LBL_MDP);
            this.GBX_Info.Controls.Add(this.TBX_Nom);
            this.GBX_Info.Controls.Add(this.TBX_MDP);
            this.GBX_Info.Location = new System.Drawing.Point(12, 12);
            this.GBX_Info.Name = "GBX_Info";
            this.GBX_Info.Size = new System.Drawing.Size(300, 133);
            this.GBX_Info.TabIndex = 6;
            this.GBX_Info.TabStop = false;
            this.GBX_Info.Text = "Informations utilisateur";
            // 
            // CBX_Souvenir
            // 
            this.CBX_Souvenir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CBX_Souvenir.AutoSize = true;
            this.CBX_Souvenir.Location = new System.Drawing.Point(150, 100);
            this.CBX_Souvenir.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.CBX_Souvenir.Name = "CBX_Souvenir";
            this.CBX_Souvenir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CBX_Souvenir.Size = new System.Drawing.Size(142, 20);
            this.CBX_Souvenir.TabIndex = 4;
            this.CBX_Souvenir.Text = "Se souvenir de moi";
            this.CBX_Souvenir.UseVisualStyleBackColor = true;
            // 
            // DLG_Connexion
            // 
            this.AcceptButton = this.BTN_Connexion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTN_Annuler;
            this.ClientSize = new System.Drawing.Size(324, 191);
            this.Controls.Add(this.GBX_Info);
            this.Controls.Add(this.BTN_Annuler);
            this.Controls.Add(this.BTN_Connexion);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 230);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(340, 230);
            this.Name = "DLG_Connexion";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DLG_Connexion_FormClosing);
            this.Load += new System.EventHandler(this.DLG_Connexion_Load);
            this.GBX_Info.ResumeLayout(false);
            this.GBX_Info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LBL_Nom;
        private System.Windows.Forms.TextBox TBX_Nom;
        private System.Windows.Forms.Label LBL_MDP;
        private System.Windows.Forms.TextBox TBX_MDP;
        private System.Windows.Forms.Button BTN_Connexion;
        private System.Windows.Forms.Button BTN_Annuler;
        private System.Windows.Forms.GroupBox GBX_Info;
        private System.Windows.Forms.CheckBox CBX_Souvenir;
    }
}