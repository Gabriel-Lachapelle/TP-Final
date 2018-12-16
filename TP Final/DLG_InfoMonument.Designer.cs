namespace TP_Final
{
    partial class DLG_InfoMonument
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
            this.GBX_Monuments = new System.Windows.Forms.GroupBox();
            this.DGV_Monuments = new System.Windows.Forms.DataGridView();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cotation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TBX_Position = new System.Windows.Forms.TextBox();
            this.LBL_Position = new System.Windows.Forms.Label();
            this.LBX_Circuits = new System.Windows.Forms.ListBox();
            this.GBX_Monuments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Monuments)).BeginInit();
            this.SuspendLayout();
            // 
            // GBX_Monuments
            // 
            this.GBX_Monuments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBX_Monuments.Controls.Add(this.DGV_Monuments);
            this.GBX_Monuments.Controls.Add(this.TBX_Position);
            this.GBX_Monuments.Controls.Add(this.LBL_Position);
            this.GBX_Monuments.Controls.Add(this.LBX_Circuits);
            this.GBX_Monuments.Location = new System.Drawing.Point(13, 13);
            this.GBX_Monuments.Margin = new System.Windows.Forms.Padding(4);
            this.GBX_Monuments.Name = "GBX_Monuments";
            this.GBX_Monuments.Padding = new System.Windows.Forms.Padding(4);
            this.GBX_Monuments.Size = new System.Drawing.Size(450, 343);
            this.GBX_Monuments.TabIndex = 1;
            this.GBX_Monuments.TabStop = false;
            this.GBX_Monuments.Text = "Monument";
            // 
            // DGV_Monuments
            // 
            this.DGV_Monuments.AllowUserToAddRows = false;
            this.DGV_Monuments.AllowUserToDeleteRows = false;
            this.DGV_Monuments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Monuments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGV_Monuments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Monuments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.Cotation});
            this.DGV_Monuments.Location = new System.Drawing.Point(8, 23);
            this.DGV_Monuments.Margin = new System.Windows.Forms.Padding(4);
            this.DGV_Monuments.MultiSelect = false;
            this.DGV_Monuments.Name = "DGV_Monuments";
            this.DGV_Monuments.ReadOnly = true;
            this.DGV_Monuments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Monuments.ShowEditingIcon = false;
            this.DGV_Monuments.Size = new System.Drawing.Size(427, 185);
            this.DGV_Monuments.TabIndex = 4;
            this.DGV_Monuments.SelectionChanged += new System.EventHandler(this.DGV_Monuments_SelectionChanged);
            // 
            // Nom
            // 
            this.Nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nom.FillWeight = 300F;
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // Cotation
            // 
            this.Cotation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cotation.HeaderText = "Cotation";
            this.Cotation.Name = "Cotation";
            this.Cotation.ReadOnly = true;
            // 
            // TBX_Position
            // 
            this.TBX_Position.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TBX_Position.Location = new System.Drawing.Point(390, 306);
            this.TBX_Position.Name = "TBX_Position";
            this.TBX_Position.ReadOnly = true;
            this.TBX_Position.Size = new System.Drawing.Size(45, 22);
            this.TBX_Position.TabIndex = 3;
            this.TBX_Position.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LBL_Position
            // 
            this.LBL_Position.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_Position.AutoSize = true;
            this.LBL_Position.Location = new System.Drawing.Point(328, 309);
            this.LBL_Position.Name = "LBL_Position";
            this.LBL_Position.Size = new System.Drawing.Size(56, 16);
            this.LBL_Position.TabIndex = 2;
            this.LBL_Position.Text = "Position";
            // 
            // LBX_Circuits
            // 
            this.LBX_Circuits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LBX_Circuits.FormattingEnabled = true;
            this.LBX_Circuits.ItemHeight = 16;
            this.LBX_Circuits.Location = new System.Drawing.Point(7, 215);
            this.LBX_Circuits.Name = "LBX_Circuits";
            this.LBX_Circuits.Size = new System.Drawing.Size(315, 116);
            this.LBX_Circuits.TabIndex = 1;
            this.LBX_Circuits.SelectedIndexChanged += new System.EventHandler(this.LBX_Circuits_SelectedIndexChanged);
            // 
            // DLG_InfoMonument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 369);
            this.Controls.Add(this.GBX_Monuments);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 300);
            this.Name = "DLG_InfoMonument";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Détails des monuments";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DLG_InfoMonument_FormClosing);
            this.Load += new System.EventHandler(this.DLG_InfoMonument_Load);
            this.GBX_Monuments.ResumeLayout(false);
            this.GBX_Monuments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Monuments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox GBX_Monuments;
        private System.Windows.Forms.TextBox TBX_Position;
        private System.Windows.Forms.Label LBL_Position;
        private System.Windows.Forms.ListBox LBX_Circuits;
        private System.Windows.Forms.DataGridView DGV_Monuments;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cotation;
    }
}