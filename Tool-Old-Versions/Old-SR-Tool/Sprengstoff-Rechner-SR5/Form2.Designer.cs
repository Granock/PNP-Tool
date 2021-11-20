namespace Sprengstoff_Rechner_SR5
{
    partial class Form2
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
            this.Verdaemmung = new System.Windows.Forms.ListBox();
            this.Box_S1 = new System.Windows.Forms.GroupBox();
            this.Box_S2 = new System.Windows.Forms.GroupBox();
            this.label_gewicht = new System.Windows.Forms.Label();
            this.label_Komlexität = new System.Windows.Forms.Label();
            this.label_Verdaemung = new System.Windows.Forms.Label();
            this.Komplexität = new System.Windows.Forms.ListBox();
            this.Box_S3 = new System.Windows.Forms.GroupBox();
            this.Gewicht = new System.Windows.Forms.TextBox();
            this.Stufe = new System.Windows.Forms.NumericUpDown();
            this.label_stufe = new System.Windows.Forms.Label();
            this.Structur = new System.Windows.Forms.NumericUpDown();
            this.Panzerung = new System.Windows.Forms.NumericUpDown();
            this.label_Struktur = new System.Windows.Forms.Label();
            this.label_Panzerung = new System.Windows.Forms.Label();
            this.Stockwerke = new System.Windows.Forms.NumericUpDown();
            this.Bomben_stock = new System.Windows.Forms.NumericUpDown();
            this.label_Stockwerke = new System.Windows.Forms.Label();
            this.label_Stock_Bomben = new System.Windows.Forms.Label();
            this.Probe_Statik = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_S1 = new System.Windows.Forms.Button();
            this.button_S2 = new System.Windows.Forms.Button();
            this.button_S3 = new System.Windows.Forms.Button();
            this.label_S1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Box_S1.SuspendLayout();
            this.Box_S2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Stufe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Structur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panzerung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stockwerke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bomben_stock)).BeginInit();
            this.SuspendLayout();
            // 
            // Verdaemmung
            // 
            this.Verdaemmung.FormattingEnabled = true;
            this.Verdaemmung.Items.AddRange(new object[] {
            "NEIN",
            "JA"});
            this.Verdaemmung.Location = new System.Drawing.Point(128, 19);
            this.Verdaemmung.Name = "Verdaemmung";
            this.Verdaemmung.ScrollAlwaysVisible = true;
            this.Verdaemmung.Size = new System.Drawing.Size(120, 30);
            this.Verdaemmung.TabIndex = 1;
            // 
            // Box_S1
            // 
            this.Box_S1.Controls.Add(this.label2);
            this.Box_S1.Controls.Add(this.textBox1);
            this.Box_S1.Controls.Add(this.label_S1);
            this.Box_S1.Controls.Add(this.label1);
            this.Box_S1.Controls.Add(this.Probe_Statik);
            this.Box_S1.Controls.Add(this.label_Stock_Bomben);
            this.Box_S1.Controls.Add(this.label_Stockwerke);
            this.Box_S1.Controls.Add(this.Bomben_stock);
            this.Box_S1.Controls.Add(this.Stockwerke);
            this.Box_S1.Controls.Add(this.label_Panzerung);
            this.Box_S1.Controls.Add(this.label_Struktur);
            this.Box_S1.Controls.Add(this.Panzerung);
            this.Box_S1.Controls.Add(this.Structur);
            this.Box_S1.Location = new System.Drawing.Point(12, 25);
            this.Box_S1.Name = "Box_S1";
            this.Box_S1.Size = new System.Drawing.Size(220, 278);
            this.Box_S1.TabIndex = 2;
            this.Box_S1.TabStop = false;
            this.Box_S1.Text = "Schritt 1";
            // 
            // Box_S2
            // 
            this.Box_S2.Controls.Add(this.label_stufe);
            this.Box_S2.Controls.Add(this.Stufe);
            this.Box_S2.Controls.Add(this.Gewicht);
            this.Box_S2.Controls.Add(this.label_gewicht);
            this.Box_S2.Controls.Add(this.label_Komlexität);
            this.Box_S2.Controls.Add(this.label_Verdaemung);
            this.Box_S2.Controls.Add(this.Komplexität);
            this.Box_S2.Controls.Add(this.Verdaemmung);
            this.Box_S2.Location = new System.Drawing.Point(238, 25);
            this.Box_S2.Name = "Box_S2";
            this.Box_S2.Size = new System.Drawing.Size(268, 278);
            this.Box_S2.TabIndex = 3;
            this.Box_S2.TabStop = false;
            this.Box_S2.Text = "Schritt 2";
            // 
            // label_gewicht
            // 
            this.label_gewicht.AutoSize = true;
            this.label_gewicht.Location = new System.Drawing.Point(13, 130);
            this.label_gewicht.Name = "label_gewicht";
            this.label_gewicht.Size = new System.Drawing.Size(85, 26);
            this.label_gewicht.TabIndex = 7;
            this.label_gewicht.Text = "Gewicht(g) der\r\nSprengladungen";
            // 
            // label_Komlexität
            // 
            this.label_Komlexität.AutoSize = true;
            this.label_Komlexität.Location = new System.Drawing.Point(13, 55);
            this.label_Komlexität.Name = "label_Komlexität";
            this.label_Komlexität.Size = new System.Drawing.Size(79, 26);
            this.label_Komlexität.TabIndex = 5;
            this.label_Komlexität.Text = "Komplexität der\r\nSprengladung";
            // 
            // label_Verdaemung
            // 
            this.label_Verdaemung.AutoSize = true;
            this.label_Verdaemung.Location = new System.Drawing.Point(13, 19);
            this.label_Verdaemung.Name = "label_Verdaemung";
            this.label_Verdaemung.Size = new System.Drawing.Size(69, 13);
            this.label_Verdaemung.TabIndex = 6;
            this.label_Verdaemung.Text = "Verdämmung";
            // 
            // Komplexität
            // 
            this.Komplexität.FormattingEnabled = true;
            this.Komplexität.Items.AddRange(new object[] {
            "EINFACH",
            "DURCHSCHNITTLICH",
            "KOMPLEX"});
            this.Komplexität.Location = new System.Drawing.Point(128, 55);
            this.Komplexität.Name = "Komplexität";
            this.Komplexität.Size = new System.Drawing.Size(120, 43);
            this.Komplexität.TabIndex = 5;
            // 
            // Box_S3
            // 
            this.Box_S3.Location = new System.Drawing.Point(571, 33);
            this.Box_S3.Name = "Box_S3";
            this.Box_S3.Size = new System.Drawing.Size(200, 270);
            this.Box_S3.TabIndex = 4;
            this.Box_S3.TabStop = false;
            this.Box_S3.Text = "Schritt 3";
            // 
            // Gewicht
            // 
            this.Gewicht.Location = new System.Drawing.Point(128, 130);
            this.Gewicht.Name = "Gewicht";
            this.Gewicht.Size = new System.Drawing.Size(120, 20);
            this.Gewicht.TabIndex = 5;
            this.Gewicht.Text = "100";
            this.Gewicht.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Stufe
            // 
            this.Stufe.Location = new System.Drawing.Point(128, 104);
            this.Stufe.Name = "Stufe";
            this.Stufe.Size = new System.Drawing.Size(120, 20);
            this.Stufe.TabIndex = 8;
            this.Stufe.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Stufe.ValueChanged += new System.EventHandler(this.Stufe_ValueChanged);
            // 
            // label_stufe
            // 
            this.label_stufe.AutoSize = true;
            this.label_stufe.Location = new System.Drawing.Point(13, 104);
            this.label_stufe.Name = "label_stufe";
            this.label_stufe.Size = new System.Drawing.Size(109, 13);
            this.label_stufe.TabIndex = 9;
            this.label_stufe.Text = "Stufe des Sprengstoff";
            // 
            // Structur
            // 
            this.Structur.Location = new System.Drawing.Point(100, 24);
            this.Structur.Name = "Structur";
            this.Structur.Size = new System.Drawing.Size(120, 20);
            this.Structur.TabIndex = 0;
            this.Structur.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Structur.ValueChanged += new System.EventHandler(this.Structur_ValueChanged);
            // 
            // Panzerung
            // 
            this.Panzerung.Location = new System.Drawing.Point(100, 50);
            this.Panzerung.Name = "Panzerung";
            this.Panzerung.Size = new System.Drawing.Size(120, 20);
            this.Panzerung.TabIndex = 10;
            this.Panzerung.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Panzerung.ValueChanged += new System.EventHandler(this.Panzerung_ValueChanged);
            // 
            // label_Struktur
            // 
            this.label_Struktur.AutoSize = true;
            this.label_Struktur.Location = new System.Drawing.Point(50, 26);
            this.label_Struktur.Name = "label_Struktur";
            this.label_Struktur.Size = new System.Drawing.Size(44, 13);
            this.label_Struktur.TabIndex = 11;
            this.label_Struktur.Text = "Struktur";
            // 
            // label_Panzerung
            // 
            this.label_Panzerung.AutoSize = true;
            this.label_Panzerung.Location = new System.Drawing.Point(36, 50);
            this.label_Panzerung.Name = "label_Panzerung";
            this.label_Panzerung.Size = new System.Drawing.Size(58, 13);
            this.label_Panzerung.TabIndex = 12;
            this.label_Panzerung.Text = "Panzerung";
            // 
            // Stockwerke
            // 
            this.Stockwerke.Location = new System.Drawing.Point(100, 102);
            this.Stockwerke.Name = "Stockwerke";
            this.Stockwerke.Size = new System.Drawing.Size(120, 20);
            this.Stockwerke.TabIndex = 5;
            this.Stockwerke.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Stockwerke.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Bomben_stock
            // 
            this.Bomben_stock.Location = new System.Drawing.Point(100, 130);
            this.Bomben_stock.Name = "Bomben_stock";
            this.Bomben_stock.Size = new System.Drawing.Size(120, 20);
            this.Bomben_stock.TabIndex = 13;
            this.Bomben_stock.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Bomben_stock.ValueChanged += new System.EventHandler(this.Bomben_stock_ValueChanged);
            // 
            // label_Stockwerke
            // 
            this.label_Stockwerke.AutoSize = true;
            this.label_Stockwerke.Location = new System.Drawing.Point(30, 104);
            this.label_Stockwerke.Name = "label_Stockwerke";
            this.label_Stockwerke.Size = new System.Drawing.Size(64, 13);
            this.label_Stockwerke.TabIndex = 14;
            this.label_Stockwerke.Text = "Stockwerke";
            // 
            // label_Stock_Bomben
            // 
            this.label_Stock_Bomben.AutoSize = true;
            this.label_Stock_Bomben.Location = new System.Drawing.Point(27, 130);
            this.label_Stock_Bomben.Name = "label_Stock_Bomben";
            this.label_Stock_Bomben.Size = new System.Drawing.Size(67, 26);
            this.label_Stock_Bomben.TabIndex = 15;
            this.label_Stock_Bomben.Text = "Bomben pro \r\nStockwerk";
            // 
            // Probe_Statik
            // 
            this.Probe_Statik.FormattingEnabled = true;
            this.Probe_Statik.Items.AddRange(new object[] {
            "Erfolg",
            "misslungen",
            "Patzer",
            "Kritischer Patzer"});
            this.Probe_Statik.Location = new System.Drawing.Point(100, 167);
            this.Probe_Statik.Name = "Probe_Statik";
            this.Probe_Statik.Size = new System.Drawing.Size(120, 56);
            this.Probe_Statik.TabIndex = 16;
            this.Probe_Statik.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 52);
            this.label1.TabIndex = 17;
            this.label1.Text = "Statik-Probe:\r\nSpreng+Logik[6]\r\nSchwelle [4] wenn\r\nBaupläne\r\n";
            // 
            // button_S1
            // 
            this.button_S1.Location = new System.Drawing.Point(15, 309);
            this.button_S1.Name = "button_S1";
            this.button_S1.Size = new System.Drawing.Size(217, 23);
            this.button_S1.TabIndex = 5;
            this.button_S1.Text = "Schritt 1 Bestätigen";
            this.button_S1.UseVisualStyleBackColor = true;
            this.button_S1.Click += new System.EventHandler(this.button_S1_Click);
            // 
            // button_S2
            // 
            this.button_S2.Location = new System.Drawing.Point(238, 309);
            this.button_S2.Name = "button_S2";
            this.button_S2.Size = new System.Drawing.Size(268, 23);
            this.button_S2.TabIndex = 6;
            this.button_S2.Text = "Schritt 2 Bestätigen";
            this.button_S2.UseVisualStyleBackColor = true;
            // 
            // button_S3
            // 
            this.button_S3.Location = new System.Drawing.Point(571, 309);
            this.button_S3.Name = "button_S3";
            this.button_S3.Size = new System.Drawing.Size(200, 23);
            this.button_S3.TabIndex = 7;
            this.button_S3.Text = "Schritt 3 Bestätigen";
            this.button_S3.UseVisualStyleBackColor = true;
            // 
            // label_S1
            // 
            this.label_S1.AutoSize = true;
            this.label_S1.Location = new System.Drawing.Point(6, 233);
            this.label_S1.Name = "label_S1";
            this.label_S1.Size = new System.Drawing.Size(53, 13);
            this.label_S1.TabIndex = 18;
            this.label_S1.Text = "Schaden:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 252);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 20);
            this.textBox1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 21;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_S3);
            this.Controls.Add(this.button_S2);
            this.Controls.Add(this.button_S1);
            this.Controls.Add(this.Box_S3);
            this.Controls.Add(this.Box_S2);
            this.Controls.Add(this.Box_S1);
            this.Name = "Form2";
            this.Text = "s";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Box_S1.ResumeLayout(false);
            this.Box_S1.PerformLayout();
            this.Box_S2.ResumeLayout(false);
            this.Box_S2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Stufe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Structur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panzerung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stockwerke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bomben_stock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox Verdaemmung;
        private System.Windows.Forms.GroupBox Box_S1;
        private System.Windows.Forms.GroupBox Box_S2;
        private System.Windows.Forms.Label label_gewicht;
        private System.Windows.Forms.Label label_Komlexität;
        private System.Windows.Forms.Label label_Verdaemung;
        private System.Windows.Forms.ListBox Komplexität;
        private System.Windows.Forms.GroupBox Box_S3;
        private System.Windows.Forms.TextBox Gewicht;
        private System.Windows.Forms.Label label_stufe;
        private System.Windows.Forms.NumericUpDown Stufe;
        private System.Windows.Forms.NumericUpDown Panzerung;
        private System.Windows.Forms.NumericUpDown Structur;
        private System.Windows.Forms.Label label_Panzerung;
        private System.Windows.Forms.Label label_Struktur;
        private System.Windows.Forms.Label label_Stock_Bomben;
        private System.Windows.Forms.Label label_Stockwerke;
        private System.Windows.Forms.NumericUpDown Bomben_stock;
        private System.Windows.Forms.NumericUpDown Stockwerke;
        private System.Windows.Forms.ListBox Probe_Statik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_S1;
        private System.Windows.Forms.Button button_S1;
        private System.Windows.Forms.Button button_S2;
        private System.Windows.Forms.Button button_S3;
        private System.Windows.Forms.Label label2;
    }
}