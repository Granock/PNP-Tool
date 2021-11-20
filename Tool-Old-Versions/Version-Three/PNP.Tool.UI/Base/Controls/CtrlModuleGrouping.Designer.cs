
namespace PNP_UI.Base.Controls
{
    partial class CtrlModuleGrouping
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BtnGroupingHead = new System.Windows.Forms.Button();
            this.PnButtons = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.PnButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnGroupingHead
            // 
            this.BtnGroupingHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnGroupingHead.FlatAppearance.BorderSize = 0;
            this.BtnGroupingHead.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.BtnGroupingHead.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.BtnGroupingHead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGroupingHead.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnGroupingHead.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGroupingHead.Location = new System.Drawing.Point(0, 0);
            this.BtnGroupingHead.Name = "BtnGroupingHead";
            this.BtnGroupingHead.Size = new System.Drawing.Size(200, 30);
            this.BtnGroupingHead.TabIndex = 0;
            this.BtnGroupingHead.Text = "BtnGroupingName";
            this.BtnGroupingHead.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGroupingHead.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGroupingHead.UseVisualStyleBackColor = true;
            this.BtnGroupingHead.Click += new System.EventHandler(this.BtnGroupingHead_Click);
            // 
            // PnButtons
            // 
            this.PnButtons.AutoSize = true;
            this.PnButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.PnButtons.Controls.Add(this.button1);
            this.PnButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnButtons.Location = new System.Drawing.Point(0, 30);
            this.PnButtons.Name = "PnButtons";
            this.PnButtons.Size = new System.Drawing.Size(200, 30);
            this.PnButtons.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(56)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(56)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(200, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CtrlModuleGrouping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.Controls.Add(this.PnButtons);
            this.Controls.Add(this.BtnGroupingHead);
            this.ForeColor = System.Drawing.Color.Silver;
            this.Name = "CtrlModuleGrouping";
            this.Size = new System.Drawing.Size(200, 60);
            this.PnButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGroupingHead;
        private System.Windows.Forms.Panel PnButtons;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.Button button1;
    }
}
