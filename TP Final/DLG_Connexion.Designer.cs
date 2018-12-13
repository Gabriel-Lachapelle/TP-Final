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
            this.SuspendLayout();
            // 
            // LBL_Nom
            // 
            this.LBL_Nom.AutoSize = true;
            this.LBL_Nom.Location = new System.Drawing.Point(24, 9);
            this.LBL_Nom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Nom.Name = "LBL_Nom";
            this.LBL_Nom.Size = new System.Drawing.Size(96, 16);
            this.LBL_Nom.TabIndex = 0;
            this.LBL_Nom.Text = "Nom d\'usager:";
            // 
            // TBX_Nom
            // 
            this.TBX_Nom.Location = new System.Drawing.Point(24, 29);
            this.TBX_Nom.Margin = new System.Windows.Forms.Padding(4);
            this.TBX_Nom.Name = "TBX_Nom";
            this.TBX_Nom.Size = new System.Drawing.Size(220, 22);
            this.TBX_Nom.TabIndex = 1;
            this.TBX_Nom.TextChanged += new System.EventHandler(this.TBX_TextChanged);
            // 
            // LBL_MDP
            // 
            this.LBL_MDP.AutoSize = true;
            this.LBL_MDP.Location = new System.Drawing.Point(21, 71);
            this.LBL_MDP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_MDP.Name = "LBL_MDP";
            this.LBL_MDP.Size = new System.Drawing.Size(93, 16);
            this.LBL_MDP.TabIndex = 2;
            this.LBL_MDP.Text = "Mot de passe:";
            // 
            // TBX_MDP
            // 
            this.TBX_MDP.Location = new System.Drawing.Point(24, 91);
            this.TBX_MDP.Margin = new System.Windows.Forms.Padding(4);
            this.TBX_MDP.Name = "TBX_MDP";
            this.TBX_MDP.PasswordChar = '•';
            this.TBX_MDP.Size = new System.Drawing.Size(220, 22);
            this.TBX_MDP.TabIndex = 3;
            this.TBX_MDP.TextChanged += new System.EventHandler(this.TBX_TextChanged);
            // 
            // BTN_Connexion
            // 
            this.BTN_Connexion.Enabled = false;
            this.BTN_Connexion.Location = new System.Drawing.Point(152, 121);
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
            this.BTN_Annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Annuler.Location = new System.Drawing.Point(24, 121);
            this.BTN_Annuler.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Annuler.Name = "BTN_Annuler";
            this.BTN_Annuler.Size = new System.Drawing.Size(69, 28);
            this.BTN_Annuler.TabIndex = 5;
            this.BTN_Annuler.Text = "Annuler";
            this.BTN_Annuler.UseVisualStyleBackColor = true;
            // 
            // DLG_Connexion
            // 
            this.AcceptButton = this.BTN_Connexion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTN_Annuler;
            this.ClientSize = new System.Drawing.Size(264, 160);
            this.Controls.Add(this.BTN_Annuler);
            this.Controls.Add(this.BTN_Connexion);
            this.Controls.Add(this.TBX_MDP);
            this.Controls.Add(this.LBL_MDP);
            this.Controls.Add(this.TBX_Nom);
            this.Controls.Add(this.LBL_Nom);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DLG_Connexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Nom;
        private System.Windows.Forms.TextBox TBX_Nom;
        private System.Windows.Forms.Label LBL_MDP;
        private System.Windows.Forms.TextBox TBX_MDP;
        private System.Windows.Forms.Button BTN_Connexion;
        private System.Windows.Forms.Button BTN_Annuler;
    }
}