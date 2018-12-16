namespace TP_Final
{
    partial class DLG_APropos
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
            this.RTBX_APropos = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // RTBX_APropos
            // 
            this.RTBX_APropos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RTBX_APropos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTBX_APropos.Location = new System.Drawing.Point(12, 12);
            this.RTBX_APropos.Name = "RTBX_APropos";
            this.RTBX_APropos.ReadOnly = true;
            this.RTBX_APropos.Size = new System.Drawing.Size(261, 192);
            this.RTBX_APropos.TabIndex = 0;
            this.RTBX_APropos.Text = "Application faite par:\n\n➜ Gabriel Lachapelle\n➜ Alexandre Tremblay\n\nInformations d" +
    "e connection:\n\nNom usager: lachapel\nMot de passe: ORACLE1";
            // 
            // DLG_APropos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 210);
            this.Controls.Add(this.RTBX_APropos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DLG_APropos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "À propros";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox RTBX_APropos;
    }
}