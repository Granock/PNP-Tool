
namespace PNP.Core.Core.Forms.Main
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
            this.BottomStatusStrip = new System.Windows.Forms.StatusStrip();
            this.panelMain = new System.Windows.Forms.Panel();
            this.TopMenuStrip = new System.Windows.Forms.ToolStrip();
            this.tsbSettings = new System.Windows.Forms.ToolStripButton();
            this.tsbAdditional = new System.Windows.Forms.ToolStripButton();
            this.tscMenus = new System.Windows.Forms.ToolStripComboBox();
            this.TopMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // BottomStatusStrip
            // 
            this.BottomStatusStrip.Location = new System.Drawing.Point(0, 428);
            this.BottomStatusStrip.Name = "BottomStatusStrip";
            this.BottomStatusStrip.Size = new System.Drawing.Size(800, 22);
            this.BottomStatusStrip.TabIndex = 1;
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 25);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(800, 403);
            this.panelMain.TabIndex = 2;
            // 
            // TopMenuStrip
            // 
            this.TopMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSettings,
            this.tsbAdditional,
            this.tscMenus});
            this.TopMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.TopMenuStrip.Name = "TopMenuStrip";
            this.TopMenuStrip.Size = new System.Drawing.Size(800, 25);
            this.TopMenuStrip.TabIndex = 0;
            // 
            // tsbSettings
            // 
            this.tsbSettings.Image = ((System.Drawing.Image)(resources.GetObject("tsbSettings.Image")));
            this.tsbSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSettings.Name = "tsbSettings";
            this.tsbSettings.Size = new System.Drawing.Size(98, 22);
            this.tsbSettings.Text = "Einstellungen";
            // 
            // tsbAdditional
            // 
            this.tsbAdditional.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdditional.Image")));
            this.tsbAdditional.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdditional.Name = "tsbAdditional";
            this.tsbAdditional.Size = new System.Drawing.Size(53, 22);
            this.tsbAdditional.Text = "Infos";
            // 
            // tscMenus
            // 
            this.tscMenus.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.tscMenus.Name = "tscMenus";
            this.tscMenus.Size = new System.Drawing.Size(121, 25);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.BottomStatusStrip);
            this.Controls.Add(this.TopMenuStrip);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.TopMenuStrip.ResumeLayout(false);
            this.TopMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip BottomStatusStrip;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.ToolStrip TopMenuStrip;
        private System.Windows.Forms.ToolStripButton tsbSettings;
        private System.Windows.Forms.ToolStripButton tsbAdditional;
        private System.Windows.Forms.ToolStripComboBox tscMenus;
    }
}