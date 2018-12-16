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
            this.components = new System.ComponentModel.Container();
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
            this.Stars = new EvaluationDemo.Stars();
            this.PBX_Image = new PhotoManagerClient.ImageBox();
            this.GBX_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // TBX_Nom
            // 
            this.TBX_Nom.Location = new System.Drawing.Point(314, 41);
            this.TBX_Nom.Margin = new System.Windows.Forms.Padding(4, 2, 4, 4);
            this.TBX_Nom.Name = "TBX_Nom";
            this.TBX_Nom.Size = new System.Drawing.Size(137, 22);
            this.TBX_Nom.TabIndex = 0;
            // 
            // TBX_Annee
            // 
            this.TBX_Annee.Location = new System.Drawing.Point(314, 102);
            this.TBX_Annee.Margin = new System.Windows.Forms.Padding(4, 2, 4, 4);
            this.TBX_Annee.Name = "TBX_Annee";
            this.TBX_Annee.Size = new System.Drawing.Size(137, 22);
            this.TBX_Annee.TabIndex = 1;
            this.TBX_Annee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numbers_KeyPress);
            // 
            // TBX_Prix
            // 
            this.TBX_Prix.Location = new System.Drawing.Point(314, 161);
            this.TBX_Prix.Margin = new System.Windows.Forms.Padding(4, 2, 4, 4);
            this.TBX_Prix.MaxLength = 3;
            this.TBX_Prix.Name = "TBX_Prix";
            this.TBX_Prix.Size = new System.Drawing.Size(137, 22);
            this.TBX_Prix.TabIndex = 2;
            this.TBX_Prix.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numbers_KeyPress);
            // 
            // RTBX_Histoire
            // 
            this.RTBX_Histoire.Location = new System.Drawing.Point(484, 43);
            this.RTBX_Histoire.Margin = new System.Windows.Forms.Padding(4);
            this.RTBX_Histoire.Name = "RTBX_Histoire";
            this.RTBX_Histoire.Size = new System.Drawing.Size(203, 142);
            this.RTBX_Histoire.TabIndex = 3;
            this.RTBX_Histoire.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 10, 10, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 10, 10, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Annee de construction";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 10, 10, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Prix";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(481, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 10, 10, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Histoire";
            // 
            // GBX_Details
            // 
            this.GBX_Details.Controls.Add(this.Stars);
            this.GBX_Details.Controls.Add(this.PBX_Image);
            this.GBX_Details.Controls.Add(this.BTN_Ajouter);
            this.GBX_Details.Controls.Add(this.BTN_Annuler);
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
            this.GBX_Details.Size = new System.Drawing.Size(708, 251);
            this.GBX_Details.TabIndex = 8;
            this.GBX_Details.TabStop = false;
            this.GBX_Details.Text = "Détails";
            // 
            // BTN_Ajouter
            // 
            this.BTN_Ajouter.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_Ajouter.Location = new System.Drawing.Point(612, 220);
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
            this.BTN_Annuler.Location = new System.Drawing.Point(531, 220);
            this.BTN_Annuler.Name = "BTN_Annuler";
            this.BTN_Annuler.Size = new System.Drawing.Size(75, 23);
            this.BTN_Annuler.TabIndex = 10;
            this.BTN_Annuler.Text = "Annuler";
            this.BTN_Annuler.UseVisualStyleBackColor = true;
            this.BTN_Annuler.Click += new System.EventHandler(this.BTN_Annuler_Click);
            // 
            // Stars
            // 
            this.Stars.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stars.Location = new System.Drawing.Point(23, 190);
            this.Stars.Margin = new System.Windows.Forms.Padding(4);
            this.Stars.MinimumSize = new System.Drawing.Size(133, 25);
            this.Stars.Name = "Stars";
            this.Stars.Size = new System.Drawing.Size(265, 53);
            this.Stars.StarsCount = 5;
            this.Stars.TabIndex = 20;
            this.Stars.Value = 0;
            this.Stars.ValueChanged += new EvaluationDemo.Stars.ValueChangedEventHandler(this.Stars_ValueChanged);
            // 
            // PBX_Image
            // 
            this.PBX_Image.AllowDrop = true;
            this.PBX_Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PBX_Image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBX_Image.ControlToolTipText = "You can either drag & drop, paste image from clipboard or choose an image file wi" +
    "th context menu.";
            this.PBX_Image.ImportImageText = "Import image from file...";
            this.PBX_Image.Location = new System.Drawing.Point(21, 22);
            this.PBX_Image.Name = "PBX_Image";
            this.PBX_Image.OpenFileDialogTitle = "Please choose image an file";
            this.PBX_Image.PasteMenuText = "Paste image from clipboard";
            this.PBX_Image.Size = new System.Drawing.Size(267, 161);
            this.PBX_Image.TabIndex = 19;
            this.PBX_Image.TabStop = false;
            // 
            // DLG_AjoutMonument
            // 
            this.AcceptButton = this.BTN_Ajouter;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTN_Annuler;
            this.ClientSize = new System.Drawing.Size(732, 273);
            this.Controls.Add(this.GBX_Details);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DLG_AjoutMonument";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajout d\'un monument";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DLG_AjoutMonument_FormClosing);
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
        private System.Windows.Forms.Button BTN_Ajouter;
        private System.Windows.Forms.Button BTN_Annuler;
        private PhotoManagerClient.ImageBox PBX_Image;
        private EvaluationDemo.Stars Stars;
    }
}