
namespace PNP_UI.CoreFunctionalities.Infos
{
    partial class FrmInfo
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
            this.lblInfo1 = new System.Windows.Forms.Label();
            this.lblInfo2 = new System.Windows.Forms.Label();
            this.lblInfoMail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInfo1
            // 
            this.lblInfo1.AutoSize = true;
            this.lblInfo1.Location = new System.Drawing.Point(12, 9);
            this.lblInfo1.Name = "lblInfo1";
            this.lblInfo1.Size = new System.Drawing.Size(428, 15);
            this.lblInfo1.TabIndex = 0;
            this.lblInfo1.Text = "Diese Tool ist nicht perfekt, es wurde rein zum vereinfachen des Spielens gebaut." +
    "";
            // 
            // lblInfo2
            // 
            this.lblInfo2.AutoSize = true;
            this.lblInfo2.Location = new System.Drawing.Point(12, 35);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(160, 15);
            this.lblInfo2.TabIndex = 1;
            this.lblInfo2.Text = "Probleme und Infos bitte  an:";
            // 
            // lblInfoMail
            // 
            this.lblInfoMail.AutoSize = true;
            this.lblInfoMail.Location = new System.Drawing.Point(178, 35);
            this.lblInfoMail.Name = "lblInfoMail";
            this.lblInfoMail.Size = new System.Drawing.Size(116, 15);
            this.lblInfoMail.TabIndex = 2;
            this.lblInfoMail.Text = "*************@***.***";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Das Tool nutzt Icons von:  https://freeiconshop.com/";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 109);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(426, 29);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Schließen";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 150);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblInfoMail);
            this.Controls.Add(this.lblInfo2);
            this.Controls.Add(this.lblInfo1);
            this.Name = "FrmInfo";
            this.Text = "FrmInfo";
            this.Load += new System.EventHandler(this.FrmInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo1;
        private System.Windows.Forms.Label lblInfo2;
        private System.Windows.Forms.Label lblInfoMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
    }
}