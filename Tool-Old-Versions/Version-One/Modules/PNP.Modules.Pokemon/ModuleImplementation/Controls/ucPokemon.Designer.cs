
namespace PNP.Modules.Pokemon.ModuleImplementation.Controls
{
    partial class ucPokemon
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node0");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Team", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node4");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Computer", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("T1", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Trainer", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Node5");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Node6");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Node7");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("freie Pokemon", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9});
            this.tvTrainerPokemon = new System.Windows.Forms.TreeView();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpMain = new System.Windows.Forms.TabPage();
            this.tcSpecificControls = new System.Windows.Forms.TabControl();
            this.tpTrainersRoot = new System.Windows.Forms.TabPage();
            this.tpFPokRoot = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tpTrainerNode = new System.Windows.Forms.TabPage();
            this.tpFPokNode = new System.Windows.Forms.TabPage();
            this.tpTranierTeamComputer = new System.Windows.Forms.TabPage();
            this.tpTrainerPok = new System.Windows.Forms.TabPage();
            this.tcMain.SuspendLayout();
            this.tpMain.SuspendLayout();
            this.tcSpecificControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvTrainerPokemon
            // 
            this.tvTrainerPokemon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvTrainerPokemon.Location = new System.Drawing.Point(3, 0);
            this.tvTrainerPokemon.Name = "tvTrainerPokemon";
            treeNode1.Name = "Node0";
            treeNode1.Text = "Node0";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Team";
            treeNode3.Name = "Node4";
            treeNode3.Text = "Node4";
            treeNode4.Name = "Node3";
            treeNode4.Text = "Computer";
            treeNode5.Name = "Node1";
            treeNode5.Text = "T1";
            treeNode6.Name = "nTrainer";
            treeNode6.Text = "Trainer";
            treeNode7.Name = "Node5";
            treeNode7.Text = "Node5";
            treeNode8.Name = "Node6";
            treeNode8.Text = "Node6";
            treeNode9.Name = "Node7";
            treeNode9.Text = "Node7";
            treeNode10.Name = "nFreePokemon";
            treeNode10.Text = "freie Pokemon";
            this.tvTrainerPokemon.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode10});
            this.tvTrainerPokemon.Size = new System.Drawing.Size(184, 349);
            this.tvTrainerPokemon.TabIndex = 0;
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpMain);
            this.tcMain.Controls.Add(this.tabPage2);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(698, 377);
            this.tcMain.TabIndex = 1;
            // 
            // tpMain
            // 
            this.tpMain.Controls.Add(this.tcSpecificControls);
            this.tpMain.Controls.Add(this.tvTrainerPokemon);
            this.tpMain.Location = new System.Drawing.Point(4, 24);
            this.tpMain.Name = "tpMain";
            this.tpMain.Padding = new System.Windows.Forms.Padding(3);
            this.tpMain.Size = new System.Drawing.Size(690, 349);
            this.tpMain.TabIndex = 0;
            this.tpMain.Text = "tabPage1";
            this.tpMain.UseVisualStyleBackColor = true;
            // 
            // tcSpecificControls
            // 
            this.tcSpecificControls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcSpecificControls.Controls.Add(this.tpTrainersRoot);
            this.tcSpecificControls.Controls.Add(this.tpTrainerNode);
            this.tcSpecificControls.Controls.Add(this.tpTranierTeamComputer);
            this.tcSpecificControls.Controls.Add(this.tpTrainerPok);
            this.tcSpecificControls.Controls.Add(this.tpFPokRoot);
            this.tcSpecificControls.Controls.Add(this.tpFPokNode);
            this.tcSpecificControls.Location = new System.Drawing.Point(193, 3);
            this.tcSpecificControls.Name = "tcSpecificControls";
            this.tcSpecificControls.SelectedIndex = 0;
            this.tcSpecificControls.Size = new System.Drawing.Size(494, 343);
            this.tcSpecificControls.TabIndex = 1;
            // 
            // tpTrainersRoot
            // 
            this.tpTrainersRoot.Location = new System.Drawing.Point(4, 24);
            this.tpTrainersRoot.Name = "tpTrainersRoot";
            this.tpTrainersRoot.Padding = new System.Windows.Forms.Padding(3);
            this.tpTrainersRoot.Size = new System.Drawing.Size(372, 315);
            this.tpTrainersRoot.TabIndex = 0;
            this.tpTrainersRoot.Text = "TrainersRoot";
            this.tpTrainersRoot.UseVisualStyleBackColor = true;
            // 
            // tpFPokRoot
            // 
            this.tpFPokRoot.Location = new System.Drawing.Point(4, 24);
            this.tpFPokRoot.Name = "tpFPokRoot";
            this.tpFPokRoot.Padding = new System.Windows.Forms.Padding(3);
            this.tpFPokRoot.Size = new System.Drawing.Size(486, 315);
            this.tpFPokRoot.TabIndex = 1;
            this.tpFPokRoot.Text = "FPokRoot";
            this.tpFPokRoot.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(576, 349);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tpTrainerNode
            // 
            this.tpTrainerNode.Location = new System.Drawing.Point(4, 24);
            this.tpTrainerNode.Name = "tpTrainerNode";
            this.tpTrainerNode.Size = new System.Drawing.Size(372, 315);
            this.tpTrainerNode.TabIndex = 2;
            this.tpTrainerNode.Text = "TrainerNode";
            this.tpTrainerNode.UseVisualStyleBackColor = true;
            // 
            // tpFPokNode
            // 
            this.tpFPokNode.Location = new System.Drawing.Point(4, 24);
            this.tpFPokNode.Name = "tpFPokNode";
            this.tpFPokNode.Size = new System.Drawing.Size(372, 315);
            this.tpFPokNode.TabIndex = 3;
            this.tpFPokNode.Text = "FPokNode";
            this.tpFPokNode.UseVisualStyleBackColor = true;
            // 
            // tpTranierTeamComputer
            // 
            this.tpTranierTeamComputer.Location = new System.Drawing.Point(4, 24);
            this.tpTranierTeamComputer.Name = "tpTranierTeamComputer";
            this.tpTranierTeamComputer.Size = new System.Drawing.Size(372, 315);
            this.tpTranierTeamComputer.TabIndex = 4;
            this.tpTranierTeamComputer.Text = "TrainerTeamComputer";
            this.tpTranierTeamComputer.UseVisualStyleBackColor = true;
            // 
            // tpTrainerPok
            // 
            this.tpTrainerPok.Location = new System.Drawing.Point(4, 24);
            this.tpTrainerPok.Name = "tpTrainerPok";
            this.tpTrainerPok.Size = new System.Drawing.Size(372, 315);
            this.tpTrainerPok.TabIndex = 5;
            this.tpTrainerPok.Text = "TrainerPok";
            this.tpTrainerPok.UseVisualStyleBackColor = true;
            // 
            // ucPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tcMain);
            this.Name = "ucPokemon";
            this.Size = new System.Drawing.Size(698, 377);
            this.tcMain.ResumeLayout(false);
            this.tpMain.ResumeLayout(false);
            this.tcSpecificControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvTrainerPokemon;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpMain;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tcSpecificControls;
        private System.Windows.Forms.TabPage tpTrainersRoot;
        private System.Windows.Forms.TabPage tpFPokRoot;
        private System.Windows.Forms.TabPage tpTrainerNode;
        private System.Windows.Forms.TabPage tpFPokNode;
        private System.Windows.Forms.TabPage tpTranierTeamComputer;
        private System.Windows.Forms.TabPage tpTrainerPok;
    }
}
