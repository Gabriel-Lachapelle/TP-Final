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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DLG_GererMonuments));
            this.GBX_Monument = new System.Windows.Forms.GroupBox();
            this.LBX_TousMonuments = new System.Windows.Forms.ListBox();
            this.LBX_MonumentsCircuit = new System.Windows.Forms.ListBox();
            this.TBX_NomCircuit = new System.Windows.Forms.TextBox();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.BTN_Retour = new System.Windows.Forms.Button();
            this.FB_Ajouter = new Calculator.FlashButton();
            this.FB_Retirer = new Calculator.FlashButton();
            this.LBL_MonumentsCircuit = new System.Windows.Forms.Label();
            this.LBL_TousMonuments = new System.Windows.Forms.Label();
            this.GBX_Monument.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBX_Monument
            // 
            this.GBX_Monument.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBX_Monument.Controls.Add(this.LBL_TousMonuments);
            this.GBX_Monument.Controls.Add(this.LBL_MonumentsCircuit);
            this.GBX_Monument.Controls.Add(this.FB_Ajouter);
            this.GBX_Monument.Controls.Add(this.FB_Retirer);
            this.GBX_Monument.Controls.Add(this.LBX_TousMonuments);
            this.GBX_Monument.Controls.Add(this.LBX_MonumentsCircuit);
            this.GBX_Monument.Controls.Add(this.TBX_NomCircuit);
            this.GBX_Monument.Location = new System.Drawing.Point(17, 16);
            this.GBX_Monument.Margin = new System.Windows.Forms.Padding(4);
            this.GBX_Monument.Name = "GBX_Monument";
            this.GBX_Monument.Padding = new System.Windows.Forms.Padding(4);
            this.GBX_Monument.Size = new System.Drawing.Size(578, 188);
            this.GBX_Monument.TabIndex = 0;
            this.GBX_Monument.TabStop = false;
            this.GBX_Monument.Text = "Monuments du circuit";
            // 
            // LBX_TousMonuments
            // 
            this.LBX_TousMonuments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LBX_TousMonuments.FormattingEnabled = true;
            this.LBX_TousMonuments.ItemHeight = 16;
            this.LBX_TousMonuments.Location = new System.Drawing.Point(317, 69);
            this.LBX_TousMonuments.Margin = new System.Windows.Forms.Padding(4);
            this.LBX_TousMonuments.Name = "LBX_TousMonuments";
            this.LBX_TousMonuments.Size = new System.Drawing.Size(250, 84);
            this.LBX_TousMonuments.TabIndex = 3;
            this.LBX_TousMonuments.SelectedIndexChanged += new System.EventHandler(this.LBX_TousMonuments_SelectedIndexChanged);
            // 
            // LBX_MonumentsCircuit
            // 
            this.LBX_MonumentsCircuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LBX_MonumentsCircuit.FormattingEnabled = true;
            this.LBX_MonumentsCircuit.ItemHeight = 16;
            this.LBX_MonumentsCircuit.Location = new System.Drawing.Point(9, 69);
            this.LBX_MonumentsCircuit.Margin = new System.Windows.Forms.Padding(4);
            this.LBX_MonumentsCircuit.Name = "LBX_MonumentsCircuit";
            this.LBX_MonumentsCircuit.Size = new System.Drawing.Size(250, 84);
            this.LBX_MonumentsCircuit.TabIndex = 2;
            this.LBX_MonumentsCircuit.SelectedIndexChanged += new System.EventHandler(this.LBX_MonumentsCircuit_SelectedIndexChanged);
            // 
            // TBX_NomCircuit
            // 
            this.TBX_NomCircuit.Location = new System.Drawing.Point(8, 23);
            this.TBX_NomCircuit.Margin = new System.Windows.Forms.Padding(4);
            this.TBX_NomCircuit.Name = "TBX_NomCircuit";
            this.TBX_NomCircuit.ReadOnly = true;
            this.TBX_NomCircuit.Size = new System.Drawing.Size(558, 22);
            this.TBX_NomCircuit.TabIndex = 1;
            this.TBX_NomCircuit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BTN_Retour
            // 
            this.BTN_Retour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Retour.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_Retour.Location = new System.Drawing.Point(536, 211);
            this.BTN_Retour.Name = "BTN_Retour";
            this.BTN_Retour.Size = new System.Drawing.Size(59, 23);
            this.BTN_Retour.TabIndex = 0;
            this.BTN_Retour.Text = "Retour";
            this.BTN_Retour.UseVisualStyleBackColor = true;
            this.BTN_Retour.Click += new System.EventHandler(this.BTN_Retour_Click);
            // 
            // FB_Ajouter
            // 
            this.FB_Ajouter.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.FB_Ajouter.BackgroundImage = global::TP_Final.Properties.Resources.Previous_Neutral;
            this.FB_Ajouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FB_Ajouter.ClickedImage = global::TP_Final.Properties.Resources.Previous_Clicked;
            this.FB_Ajouter.DisabledImage = global::TP_Final.Properties.Resources.Previous_Disabled;
            this.FB_Ajouter.Enabled = false;
            this.FB_Ajouter.Image = ((System.Drawing.Image)(resources.GetObject("FB_Ajouter.Image")));
            this.FB_Ajouter.Location = new System.Drawing.Point(268, 113);
            this.FB_Ajouter.Margin = new System.Windows.Forms.Padding(5, 5, 5, 20);
            this.FB_Ajouter.Name = "FB_Ajouter";
            this.FB_Ajouter.NeutralImage = global::TP_Final.Properties.Resources.Previous_Neutral;
            this.FB_Ajouter.OverImage = global::TP_Final.Properties.Resources.Previous_Hover;
            this.FB_Ajouter.Size = new System.Drawing.Size(40, 40);
            this.FB_Ajouter.TabIndex = 22;
            this.ToolTip.SetToolTip(this.FB_Ajouter, "Ajouter le monument au circuit");
            this.FB_Ajouter.UseVisualStyleBackColor = true;
            this.FB_Ajouter.Click += new System.EventHandler(this.FB_Ajouter_Click);
            // 
            // FB_Retirer
            // 
            this.FB_Retirer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FB_Retirer.BackgroundImage = global::TP_Final.Properties.Resources.Next_Neutral;
            this.FB_Retirer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FB_Retirer.ClickedImage = global::TP_Final.Properties.Resources.Next_Clicked;
            this.FB_Retirer.DisabledImage = global::TP_Final.Properties.Resources.Next_Disabled;
            this.FB_Retirer.Enabled = false;
            this.FB_Retirer.Image = ((System.Drawing.Image)(resources.GetObject("FB_Retirer.Image")));
            this.FB_Retirer.Location = new System.Drawing.Point(268, 69);
            this.FB_Retirer.Margin = new System.Windows.Forms.Padding(5, 20, 5, 5);
            this.FB_Retirer.Name = "FB_Retirer";
            this.FB_Retirer.NeutralImage = global::TP_Final.Properties.Resources.Next_Neutral;
            this.FB_Retirer.OverImage = global::TP_Final.Properties.Resources.Next_Hover;
            this.FB_Retirer.Size = new System.Drawing.Size(40, 40);
            this.FB_Retirer.TabIndex = 21;
            this.ToolTip.SetToolTip(this.FB_Retirer, "Retirer le monument du circuit");
            this.FB_Retirer.UseVisualStyleBackColor = true;
            this.FB_Retirer.Click += new System.EventHandler(this.FB_Retirer_Click);
            // 
            // LBL_MonumentsCircuit
            // 
            this.LBL_MonumentsCircuit.AutoSize = true;
            this.LBL_MonumentsCircuit.Location = new System.Drawing.Point(56, 49);
            this.LBL_MonumentsCircuit.Name = "LBL_MonumentsCircuit";
            this.LBL_MonumentsCircuit.Size = new System.Drawing.Size(161, 16);
            this.LBL_MonumentsCircuit.TabIndex = 23;
            this.LBL_MonumentsCircuit.Text = "Monuments dans le circuit";
            // 
            // LBL_TousMonuments
            // 
            this.LBL_TousMonuments.AutoSize = true;
            this.LBL_TousMonuments.Location = new System.Drawing.Point(346, 49);
            this.LBL_TousMonuments.Name = "LBL_TousMonuments";
            this.LBL_TousMonuments.Size = new System.Drawing.Size(191, 16);
            this.LBL_TousMonuments.TabIndex = 24;
            this.LBL_TousMonuments.Text = "Autres monuments disponibles";
            // 
            // DLG_GererMonuments
            // 
            this.AcceptButton = this.BTN_Retour;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 246);
            this.Controls.Add(this.BTN_Retour);
            this.Controls.Add(this.GBX_Monument);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(620, 5000);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(620, 285);
            this.Name = "DLG_GererMonuments";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gérer les monuments du circuit";
            this.Load += new System.EventHandler(this.DLG_GererMonuments_Load);
            this.GBX_Monument.ResumeLayout(false);
            this.GBX_Monument.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBX_Monument;
        private System.Windows.Forms.ListBox LBX_TousMonuments;
        private System.Windows.Forms.ListBox LBX_MonumentsCircuit;
        private System.Windows.Forms.TextBox TBX_NomCircuit;
        private Calculator.FlashButton FB_Ajouter;
        private Calculator.FlashButton FB_Retirer;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.Button BTN_Retour;
        private System.Windows.Forms.Label LBL_TousMonuments;
        private System.Windows.Forms.Label LBL_MonumentsCircuit;
    }
}