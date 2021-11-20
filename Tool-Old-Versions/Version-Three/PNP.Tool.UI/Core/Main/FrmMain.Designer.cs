
namespace PNP_UI.Core.Main
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.PnMenu = new System.Windows.Forms.Panel();
            this.BtnInfo = new System.Windows.Forms.Button();
            this.BtnHelp = new System.Windows.Forms.Button();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.PnDivider = new System.Windows.Forms.Panel();
            this.PnModules = new System.Windows.Forms.Panel();
            this.ctrlModuleGrouping1 = new PNP_UI.Base.Controls.CtrlModuleGrouping();
            this.PnStatus = new System.Windows.Forms.Panel();
            this.PnBottom = new System.Windows.Forms.Panel();
            this.PnContent = new System.Windows.Forms.Panel();
            this.PnMenu.SuspendLayout();
            this.PnModules.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnMenu
            // 
            this.PnMenu.AutoScroll = true;
            this.PnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.PnMenu.Controls.Add(this.BtnInfo);
            this.PnMenu.Controls.Add(this.BtnHelp);
            this.PnMenu.Controls.Add(this.BtnSettings);
            this.PnMenu.Controls.Add(this.PnDivider);
            this.PnMenu.Controls.Add(this.PnModules);
            this.PnMenu.Controls.Add(this.PnStatus);
            this.PnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnMenu.Location = new System.Drawing.Point(0, 0);
            this.PnMenu.Name = "PnMenu";
            this.PnMenu.Size = new System.Drawing.Size(200, 561);
            this.PnMenu.TabIndex = 0;
            // 
            // BtnInfo
            // 
            this.BtnInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnInfo.FlatAppearance.BorderSize = 0;
            this.BtnInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.BtnInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.BtnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInfo.Location = new System.Drawing.Point(0, 204);
            this.BtnInfo.Name = "BtnInfo";
            this.BtnInfo.Size = new System.Drawing.Size(200, 30);
            this.BtnInfo.TabIndex = 0;
            this.BtnInfo.Text = "Info";
            this.BtnInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInfo.UseVisualStyleBackColor = true;
            // 
            // BtnHelp
            // 
            this.BtnHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnHelp.FlatAppearance.BorderSize = 0;
            this.BtnHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.BtnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.BtnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHelp.Location = new System.Drawing.Point(0, 174);
            this.BtnHelp.Name = "BtnHelp";
            this.BtnHelp.Size = new System.Drawing.Size(200, 30);
            this.BtnHelp.TabIndex = 0;
            this.BtnHelp.Text = "Hilfe";
            this.BtnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHelp.UseVisualStyleBackColor = true;
            // 
            // BtnSettings
            // 
            this.BtnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSettings.FlatAppearance.BorderSize = 0;
            this.BtnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.BtnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.BtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSettings.Location = new System.Drawing.Point(0, 144);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(200, 30);
            this.BtnSettings.TabIndex = 0;
            this.BtnSettings.Text = "Einstellungen";
            this.BtnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSettings.UseVisualStyleBackColor = true;
            // 
            // PnDivider
            // 
            this.PnDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(5)))));
            this.PnDivider.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnDivider.Location = new System.Drawing.Point(0, 134);
            this.PnDivider.Name = "PnDivider";
            this.PnDivider.Size = new System.Drawing.Size(200, 10);
            this.PnDivider.TabIndex = 1;
            // 
            // PnModules
            // 
            this.PnModules.AutoSize = true;
            this.PnModules.Controls.Add(this.ctrlModuleGrouping1);
            this.PnModules.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnModules.Location = new System.Drawing.Point(0, 100);
            this.PnModules.Name = "PnModules";
            this.PnModules.Size = new System.Drawing.Size(200, 34);
            this.PnModules.TabIndex = 0;
            // 
            // ctrlModuleGrouping1
            // 
            this.ctrlModuleGrouping1.AutoSize = true;
            this.ctrlModuleGrouping1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ctrlModuleGrouping1.Collapsed = false;
            this.ctrlModuleGrouping1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctrlModuleGrouping1.ForeColor = System.Drawing.Color.Silver;
            this.ctrlModuleGrouping1.Location = new System.Drawing.Point(0, 0);
            this.ctrlModuleGrouping1.ModuleClicked = null;
            this.ctrlModuleGrouping1.Name = "ctrlModuleGrouping1";
            this.ctrlModuleGrouping1.Size = new System.Drawing.Size(200, 34);
            this.ctrlModuleGrouping1.TabIndex = 0;
            // 
            // PnStatus
            // 
            this.PnStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnStatus.Location = new System.Drawing.Point(0, 0);
            this.PnStatus.Name = "PnStatus";
            this.PnStatus.Size = new System.Drawing.Size(200, 100);
            this.PnStatus.TabIndex = 0;
            // 
            // PnBottom
            // 
            this.PnBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.PnBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnBottom.Location = new System.Drawing.Point(200, 376);
            this.PnBottom.Name = "PnBottom";
            this.PnBottom.Size = new System.Drawing.Size(734, 185);
            this.PnBottom.TabIndex = 1;
            // 
            // PnContent
            // 
            this.PnContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.PnContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnContent.Location = new System.Drawing.Point(200, 0);
            this.PnContent.Name = "PnContent";
            this.PnContent.Size = new System.Drawing.Size(734, 376);
            this.PnContent.TabIndex = 2;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.PnContent);
            this.Controls.Add(this.PnBottom);
            this.Controls.Add(this.PnMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Silver;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.PnMenu.ResumeLayout(false);
            this.PnMenu.PerformLayout();
            this.PnModules.ResumeLayout(false);
            this.PnModules.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnMenu;
        private System.Windows.Forms.Panel PnBottom;
        private System.Windows.Forms.Panel PnContent;
        private System.Windows.Forms.Panel PnStatus;
        private System.Windows.Forms.Panel PnModules;
        private Base.Controls.CtrlModuleGrouping ctrlModuleGrouping1;
        private System.Windows.Forms.Button BtnSettings;
        private System.Windows.Forms.Button BtnHelp;
        private System.Windows.Forms.Button BtnInfo;
        private System.Windows.Forms.Panel PnDivider;
    }
}