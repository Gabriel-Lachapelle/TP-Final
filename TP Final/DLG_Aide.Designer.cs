namespace TP_Final
{
    partial class DLG_Aide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DLG_Aide));
            this.RTBX_Aide = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // RTBX_Aide
            // 
            this.RTBX_Aide.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RTBX_Aide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTBX_Aide.Location = new System.Drawing.Point(12, 13);
            this.RTBX_Aide.Name = "RTBX_Aide";
            this.RTBX_Aide.ReadOnly = true;
            this.RTBX_Aide.Size = new System.Drawing.Size(857, 542);
            this.RTBX_Aide.TabIndex = 0;
            this.RTBX_Aide.Text = resources.GetString("RTBX_Aide.Text");
            // 
            // DLG_Aide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 567);
            this.Controls.Add(this.RTBX_Aide);
            this.MinimumSize = new System.Drawing.Size(250, 150);
            this.Name = "DLG_Aide";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aide";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DLG_Aide_FormClosing);
            this.Load += new System.EventHandler(this.DLG_Aide_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox RTBX_Aide;
    }
}