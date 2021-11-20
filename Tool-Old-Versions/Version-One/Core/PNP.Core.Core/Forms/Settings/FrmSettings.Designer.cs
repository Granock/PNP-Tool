
namespace PNP.Core.Core.Forms.Settings
{
    partial class FrmSettings
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
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.pMainBody = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSuccess = new System.Windows.Forms.Button();
            this.pMainBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbLanguage
            // 
            this.cbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.Location = new System.Drawing.Point(106, 11);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(159, 23);
            this.cbLanguage.TabIndex = 0;
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(2, 14);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(98, 15);
            this.lblLanguage.TabIndex = 1;
            this.lblLanguage.Text = "Aktuelle Sprache:";
            // 
            // pMainBody
            // 
            this.pMainBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pMainBody.Controls.Add(this.btnCancel);
            this.pMainBody.Controls.Add(this.btnSuccess);
            this.pMainBody.Controls.Add(this.cbLanguage);
            this.pMainBody.Controls.Add(this.lblLanguage);
            this.pMainBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMainBody.Location = new System.Drawing.Point(0, 0);
            this.pMainBody.Name = "pMainBody";
            this.pMainBody.Size = new System.Drawing.Size(278, 232);
            this.pMainBody.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(142, 196);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSuccess
            // 
            this.btnSuccess.Location = new System.Drawing.Point(11, 196);
            this.btnSuccess.Name = "btnSuccess";
            this.btnSuccess.Size = new System.Drawing.Size(123, 23);
            this.btnSuccess.TabIndex = 2;
            this.btnSuccess.Text = "Ok";
            this.btnSuccess.UseVisualStyleBackColor = true;
            this.btnSuccess.Click += new System.EventHandler(this.btnSuccess_Click);
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 232);
            this.Controls.Add(this.pMainBody);
            this.Name = "FrmSettings";
            this.Text = "FrmSettings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmSettings_FormClosed);
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            this.pMainBody.ResumeLayout(false);
            this.pMainBody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbLanguage;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Panel pMainBody;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSuccess;
    }
}