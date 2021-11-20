namespace Sprengstoff_Rechner_SR5
{
    partial class Form1
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.numeric_Panzerung = new System.Windows.Forms.NumericUpDown();
            this.numeric_Struktur = new System.Windows.Forms.NumericUpDown();
            this.textBox_Dicke = new System.Windows.Forms.TextBox();
            this.label_Struktur = new System.Windows.Forms.Label();
            this.groupBox_Barriere = new System.Windows.Forms.GroupBox();
            this.button_Barriere = new System.Windows.Forms.Button();
            this.label_Wiederstand_1_2 = new System.Windows.Forms.Label();
            this.label_Wiederstand_0 = new System.Windows.Forms.Label();
            this.textBox_W_1_2 = new System.Windows.Forms.TextBox();
            this.textBox_W_0 = new System.Windows.Forms.TextBox();
            this.textBox_Flaeche = new System.Windows.Forms.TextBox();
            this.label_Flaeche = new System.Windows.Forms.Label();
            this.label_Panzerung = new System.Windows.Forms.Label();
            this.label_Dicke = new System.Windows.Forms.Label();
            this.groupBox_Sprengstoff = new System.Windows.Forms.GroupBox();
            this.button_Sprengstoff = new System.Windows.Forms.Button();
            this.label_n_verdaemmt = new System.Windows.Forms.Label();
            this.label_verdaemmt = new System.Windows.Forms.Label();
            this.textBox_n_verdaemmt = new System.Windows.Forms.TextBox();
            this.label_Gewicht = new System.Windows.Forms.Label();
            this.label_probe = new System.Windows.Forms.Label();
            this.label_Sprengstoff = new System.Windows.Forms.Label();
            this.textBox_verdaemmt = new System.Windows.Forms.TextBox();
            this.textBox_Gewicht = new System.Windows.Forms.TextBox();
            this.textBox_Probe = new System.Windows.Forms.TextBox();
            this.numeric_Sprengstoff = new System.Windows.Forms.NumericUpDown();
            this.groupBox_Intervall = new System.Windows.Forms.GroupBox();
            this.label_AntiDemontage = new System.Windows.Forms.Label();
            this.numeric_AntiDemontage = new System.Windows.Forms.NumericUpDown();
            this.button_intervall = new System.Windows.Forms.Button();
            this.label_schwellwert = new System.Windows.Forms.Label();
            this.label_interval = new System.Windows.Forms.Label();
            this.label_verschleiern = new System.Windows.Forms.Label();
            this.label_komplexitaet = new System.Windows.Forms.Label();
            this.label3_zuender_2 = new System.Windows.Forms.Label();
            this.label_bomben = new System.Windows.Forms.Label();
            this.label_Zuender = new System.Windows.Forms.Label();
            this.textBox_Schwellwert = new System.Windows.Forms.TextBox();
            this.textBox_Intervall = new System.Windows.Forms.TextBox();
            this.listBox_verschleiert = new System.Windows.Forms.ListBox();
            this.listBox_komplexitaet = new System.Windows.Forms.ListBox();
            this.listBox_opti = new System.Windows.Forms.ListBox();
            this.numeric_bomben = new System.Windows.Forms.NumericUpDown();
            this.numeric_Zuender = new System.Windows.Forms.NumericUpDown();
            this.textBox_Fehler = new System.Windows.Forms.TextBox();
            this.listBox_mehrfachBomben = new System.Windows.Forms.ListBox();
            this.label_multibomben = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Panzerung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Struktur)).BeginInit();
            this.groupBox_Barriere.SuspendLayout();
            this.groupBox_Sprengstoff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Sprengstoff)).BeginInit();
            this.groupBox_Intervall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_AntiDemontage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_bomben)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Zuender)).BeginInit();
            this.SuspendLayout();
            // 
            // numeric_Panzerung
            // 
            this.numeric_Panzerung.Location = new System.Drawing.Point(74, 45);
            this.numeric_Panzerung.Name = "numeric_Panzerung";
            this.numeric_Panzerung.Size = new System.Drawing.Size(120, 20);
            this.numeric_Panzerung.TabIndex = 1;
            this.numeric_Panzerung.ValueChanged += new System.EventHandler(this.numeric_Panzerung_ValueChanged);
            // 
            // numeric_Struktur
            // 
            this.numeric_Struktur.Location = new System.Drawing.Point(74, 19);
            this.numeric_Struktur.Name = "numeric_Struktur";
            this.numeric_Struktur.Size = new System.Drawing.Size(120, 20);
            this.numeric_Struktur.TabIndex = 0;
            this.numeric_Struktur.ValueChanged += new System.EventHandler(this.numeric_Struktur_ValueChanged);
            // 
            // textBox_Dicke
            // 
            this.textBox_Dicke.Location = new System.Drawing.Point(74, 82);
            this.textBox_Dicke.Name = "textBox_Dicke";
            this.textBox_Dicke.Size = new System.Drawing.Size(120, 20);
            this.textBox_Dicke.TabIndex = 2;
            this.textBox_Dicke.Leave += new System.EventHandler(this.textBox_Dicke_Leave);
            // 
            // label_Struktur
            // 
            this.label_Struktur.AutoSize = true;
            this.label_Struktur.Location = new System.Drawing.Point(24, 19);
            this.label_Struktur.Name = "label_Struktur";
            this.label_Struktur.Size = new System.Drawing.Size(50, 13);
            this.label_Struktur.TabIndex = 6;
            this.label_Struktur.Text = "Struktur :";
            // 
            // groupBox_Barriere
            // 
            this.groupBox_Barriere.Controls.Add(this.button_Barriere);
            this.groupBox_Barriere.Controls.Add(this.label_Wiederstand_1_2);
            this.groupBox_Barriere.Controls.Add(this.label_Wiederstand_0);
            this.groupBox_Barriere.Controls.Add(this.textBox_W_1_2);
            this.groupBox_Barriere.Controls.Add(this.textBox_W_0);
            this.groupBox_Barriere.Controls.Add(this.textBox_Flaeche);
            this.groupBox_Barriere.Controls.Add(this.label_Flaeche);
            this.groupBox_Barriere.Controls.Add(this.label_Panzerung);
            this.groupBox_Barriere.Controls.Add(this.label_Dicke);
            this.groupBox_Barriere.Controls.Add(this.numeric_Struktur);
            this.groupBox_Barriere.Controls.Add(this.numeric_Panzerung);
            this.groupBox_Barriere.Controls.Add(this.textBox_Dicke);
            this.groupBox_Barriere.Controls.Add(this.label_Struktur);
            this.groupBox_Barriere.Location = new System.Drawing.Point(12, 4);
            this.groupBox_Barriere.Name = "groupBox_Barriere";
            this.groupBox_Barriere.Size = new System.Drawing.Size(200, 331);
            this.groupBox_Barriere.TabIndex = 7;
            this.groupBox_Barriere.TabStop = false;
            this.groupBox_Barriere.Text = "Barriere";
            // 
            // button_Barriere
            // 
            this.button_Barriere.Location = new System.Drawing.Point(4, 302);
            this.button_Barriere.Name = "button_Barriere";
            this.button_Barriere.Size = new System.Drawing.Size(190, 23);
            this.button_Barriere.TabIndex = 13;
            this.button_Barriere.Text = "Berechnen";
            this.button_Barriere.UseVisualStyleBackColor = true;
            this.button_Barriere.Click += new System.EventHandler(this.button_Barriere_Click);
            // 
            // label_Wiederstand_1_2
            // 
            this.label_Wiederstand_1_2.AutoSize = true;
            this.label_Wiederstand_1_2.Location = new System.Drawing.Point(1, 172);
            this.label_Wiederstand_1_2.Name = "label_Wiederstand_1_2";
            this.label_Wiederstand_1_2.Size = new System.Drawing.Size(73, 26);
            this.label_Wiederstand_1_2.TabIndex = 12;
            this.label_Wiederstand_1_2.Text = "Wiederstand :\r\n(DK = 1/2)";
            // 
            // label_Wiederstand_0
            // 
            this.label_Wiederstand_0.AutoSize = true;
            this.label_Wiederstand_0.Location = new System.Drawing.Point(1, 143);
            this.label_Wiederstand_0.Name = "label_Wiederstand_0";
            this.label_Wiederstand_0.Size = new System.Drawing.Size(73, 26);
            this.label_Wiederstand_0.TabIndex = 8;
            this.label_Wiederstand_0.Text = "Wiederstand :\r\n(DK = 0)";
            // 
            // textBox_W_1_2
            // 
            this.textBox_W_1_2.Location = new System.Drawing.Point(74, 169);
            this.textBox_W_1_2.Name = "textBox_W_1_2";
            this.textBox_W_1_2.ReadOnly = true;
            this.textBox_W_1_2.Size = new System.Drawing.Size(120, 20);
            this.textBox_W_1_2.TabIndex = 11;
            // 
            // textBox_W_0
            // 
            this.textBox_W_0.Location = new System.Drawing.Point(74, 143);
            this.textBox_W_0.Name = "textBox_W_0";
            this.textBox_W_0.ReadOnly = true;
            this.textBox_W_0.Size = new System.Drawing.Size(120, 20);
            this.textBox_W_0.TabIndex = 10;
            // 
            // textBox_Flaeche
            // 
            this.textBox_Flaeche.Location = new System.Drawing.Point(74, 108);
            this.textBox_Flaeche.Name = "textBox_Flaeche";
            this.textBox_Flaeche.Size = new System.Drawing.Size(120, 20);
            this.textBox_Flaeche.TabIndex = 3;
            this.textBox_Flaeche.Leave += new System.EventHandler(this.textBox_Flaeche_Leave);
            this.textBox_Flaeche.MouseCaptureChanged += new System.EventHandler(this.textBox_Flaeche_Leave);
            // 
            // label_Flaeche
            // 
            this.label_Flaeche.AutoSize = true;
            this.label_Flaeche.Location = new System.Drawing.Point(9, 108);
            this.label_Flaeche.Name = "label_Flaeche";
            this.label_Flaeche.Size = new System.Drawing.Size(65, 13);
            this.label_Flaeche.TabIndex = 9;
            this.label_Flaeche.Text = "Fläche(m2) :";
            // 
            // label_Panzerung
            // 
            this.label_Panzerung.AutoSize = true;
            this.label_Panzerung.Location = new System.Drawing.Point(10, 45);
            this.label_Panzerung.Name = "label_Panzerung";
            this.label_Panzerung.Size = new System.Drawing.Size(64, 13);
            this.label_Panzerung.TabIndex = 8;
            this.label_Panzerung.Text = "Panzerung :";
            // 
            // label_Dicke
            // 
            this.label_Dicke.AutoSize = true;
            this.label_Dicke.Location = new System.Drawing.Point(19, 82);
            this.label_Dicke.Name = "label_Dicke";
            this.label_Dicke.Size = new System.Drawing.Size(55, 13);
            this.label_Dicke.TabIndex = 8;
            this.label_Dicke.Text = "Dicke(m) :";
            // 
            // groupBox_Sprengstoff
            // 
            this.groupBox_Sprengstoff.Controls.Add(this.button_Sprengstoff);
            this.groupBox_Sprengstoff.Controls.Add(this.label_n_verdaemmt);
            this.groupBox_Sprengstoff.Controls.Add(this.label_verdaemmt);
            this.groupBox_Sprengstoff.Controls.Add(this.textBox_n_verdaemmt);
            this.groupBox_Sprengstoff.Controls.Add(this.label_Gewicht);
            this.groupBox_Sprengstoff.Controls.Add(this.label_probe);
            this.groupBox_Sprengstoff.Controls.Add(this.label_Sprengstoff);
            this.groupBox_Sprengstoff.Controls.Add(this.textBox_verdaemmt);
            this.groupBox_Sprengstoff.Controls.Add(this.textBox_Gewicht);
            this.groupBox_Sprengstoff.Controls.Add(this.textBox_Probe);
            this.groupBox_Sprengstoff.Controls.Add(this.numeric_Sprengstoff);
            this.groupBox_Sprengstoff.Location = new System.Drawing.Point(218, 4);
            this.groupBox_Sprengstoff.Name = "groupBox_Sprengstoff";
            this.groupBox_Sprengstoff.Size = new System.Drawing.Size(200, 331);
            this.groupBox_Sprengstoff.TabIndex = 8;
            this.groupBox_Sprengstoff.TabStop = false;
            this.groupBox_Sprengstoff.Text = "Sprengstoff Stärke";
            // 
            // button_Sprengstoff
            // 
            this.button_Sprengstoff.Location = new System.Drawing.Point(0, 302);
            this.button_Sprengstoff.Name = "button_Sprengstoff";
            this.button_Sprengstoff.Size = new System.Drawing.Size(190, 23);
            this.button_Sprengstoff.TabIndex = 11;
            this.button_Sprengstoff.Text = "Berechnen";
            this.button_Sprengstoff.UseVisualStyleBackColor = true;
            this.button_Sprengstoff.Click += new System.EventHandler(this.button_Sprengstoff_Click);
            // 
            // label_n_verdaemmt
            // 
            this.label_n_verdaemmt.AutoSize = true;
            this.label_n_verdaemmt.Location = new System.Drawing.Point(13, 163);
            this.label_n_verdaemmt.Name = "label_n_verdaemmt";
            this.label_n_verdaemmt.Size = new System.Drawing.Size(60, 26);
            this.label_n_verdaemmt.TabIndex = 10;
            this.label_n_verdaemmt.Text = "Nicht \r\nVerdämmt :";
            // 
            // label_verdaemmt
            // 
            this.label_verdaemmt.AutoSize = true;
            this.label_verdaemmt.Location = new System.Drawing.Point(13, 143);
            this.label_verdaemmt.Name = "label_verdaemmt";
            this.label_verdaemmt.Size = new System.Drawing.Size(60, 13);
            this.label_verdaemmt.TabIndex = 9;
            this.label_verdaemmt.Text = "Verdämmt :";
            // 
            // textBox_n_verdaemmt
            // 
            this.textBox_n_verdaemmt.Location = new System.Drawing.Point(74, 169);
            this.textBox_n_verdaemmt.Name = "textBox_n_verdaemmt";
            this.textBox_n_verdaemmt.ReadOnly = true;
            this.textBox_n_verdaemmt.Size = new System.Drawing.Size(120, 20);
            this.textBox_n_verdaemmt.TabIndex = 8;
            // 
            // label_Gewicht
            // 
            this.label_Gewicht.AutoSize = true;
            this.label_Gewicht.Location = new System.Drawing.Point(21, 88);
            this.label_Gewicht.Name = "label_Gewicht";
            this.label_Gewicht.Size = new System.Drawing.Size(52, 26);
            this.label_Gewicht.TabIndex = 7;
            this.label_Gewicht.Text = "Gewicht :\r\nin (g)";
            // 
            // label_probe
            // 
            this.label_probe.AutoSize = true;
            this.label_probe.Location = new System.Drawing.Point(9, 45);
            this.label_probe.Name = "label_probe";
            this.label_probe.Size = new System.Drawing.Size(64, 26);
            this.label_probe.TabIndex = 6;
            this.label_probe.Text = "Probe (+/-) :\r\nSpr+Lo[ge]";
            // 
            // label_Sprengstoff
            // 
            this.label_Sprengstoff.AutoSize = true;
            this.label_Sprengstoff.Location = new System.Drawing.Point(6, 13);
            this.label_Sprengstoff.Name = "label_Sprengstoff";
            this.label_Sprengstoff.Size = new System.Drawing.Size(67, 26);
            this.label_Sprengstoff.TabIndex = 5;
            this.label_Sprengstoff.Text = "Stufe des \r\nSprengstoff :";
            // 
            // textBox_verdaemmt
            // 
            this.textBox_verdaemmt.Location = new System.Drawing.Point(74, 143);
            this.textBox_verdaemmt.Name = "textBox_verdaemmt";
            this.textBox_verdaemmt.ReadOnly = true;
            this.textBox_verdaemmt.Size = new System.Drawing.Size(120, 20);
            this.textBox_verdaemmt.TabIndex = 4;
            // 
            // textBox_Gewicht
            // 
            this.textBox_Gewicht.Location = new System.Drawing.Point(74, 88);
            this.textBox_Gewicht.Name = "textBox_Gewicht";
            this.textBox_Gewicht.Size = new System.Drawing.Size(120, 20);
            this.textBox_Gewicht.TabIndex = 3;
            this.textBox_Gewicht.TextChanged += new System.EventHandler(this.textBox_Gewicht_TextChanged);
            // 
            // textBox_Probe
            // 
            this.textBox_Probe.Location = new System.Drawing.Point(74, 45);
            this.textBox_Probe.Name = "textBox_Probe";
            this.textBox_Probe.Size = new System.Drawing.Size(120, 20);
            this.textBox_Probe.TabIndex = 2;
            this.textBox_Probe.Leave += new System.EventHandler(this.textBox_Probe_Leave);
            // 
            // numeric_Sprengstoff
            // 
            this.numeric_Sprengstoff.Location = new System.Drawing.Point(74, 19);
            this.numeric_Sprengstoff.Name = "numeric_Sprengstoff";
            this.numeric_Sprengstoff.Size = new System.Drawing.Size(120, 20);
            this.numeric_Sprengstoff.TabIndex = 0;
            this.numeric_Sprengstoff.ValueChanged += new System.EventHandler(this.numeric_Sprengstoff_ValueChanged);
            // 
            // groupBox_Intervall
            // 
            this.groupBox_Intervall.Controls.Add(this.label_multibomben);
            this.groupBox_Intervall.Controls.Add(this.listBox_mehrfachBomben);
            this.groupBox_Intervall.Controls.Add(this.label_AntiDemontage);
            this.groupBox_Intervall.Controls.Add(this.numeric_AntiDemontage);
            this.groupBox_Intervall.Controls.Add(this.button_intervall);
            this.groupBox_Intervall.Controls.Add(this.label_schwellwert);
            this.groupBox_Intervall.Controls.Add(this.label_interval);
            this.groupBox_Intervall.Controls.Add(this.label_verschleiern);
            this.groupBox_Intervall.Controls.Add(this.label_komplexitaet);
            this.groupBox_Intervall.Controls.Add(this.label3_zuender_2);
            this.groupBox_Intervall.Controls.Add(this.label_bomben);
            this.groupBox_Intervall.Controls.Add(this.label_Zuender);
            this.groupBox_Intervall.Controls.Add(this.textBox_Schwellwert);
            this.groupBox_Intervall.Controls.Add(this.textBox_Intervall);
            this.groupBox_Intervall.Controls.Add(this.listBox_verschleiert);
            this.groupBox_Intervall.Controls.Add(this.listBox_komplexitaet);
            this.groupBox_Intervall.Controls.Add(this.listBox_opti);
            this.groupBox_Intervall.Controls.Add(this.numeric_bomben);
            this.groupBox_Intervall.Controls.Add(this.numeric_Zuender);
            this.groupBox_Intervall.Location = new System.Drawing.Point(424, 4);
            this.groupBox_Intervall.Name = "groupBox_Intervall";
            this.groupBox_Intervall.Size = new System.Drawing.Size(200, 331);
            this.groupBox_Intervall.TabIndex = 9;
            this.groupBox_Intervall.TabStop = false;
            this.groupBox_Intervall.Text = "Bau-Zeit";
            // 
            // label_AntiDemontage
            // 
            this.label_AntiDemontage.AutoSize = true;
            this.label_AntiDemontage.Location = new System.Drawing.Point(3, 138);
            this.label_AntiDemontage.Name = "label_AntiDemontage";
            this.label_AntiDemontage.Size = new System.Drawing.Size(65, 26);
            this.label_AntiDemontage.TabIndex = 16;
            this.label_AntiDemontage.Text = "         Anti-\r\nDemontage:\r\n";
            // 
            // numeric_AntiDemontage
            // 
            this.numeric_AntiDemontage.Location = new System.Drawing.Point(74, 144);
            this.numeric_AntiDemontage.Name = "numeric_AntiDemontage";
            this.numeric_AntiDemontage.Size = new System.Drawing.Size(120, 20);
            this.numeric_AntiDemontage.TabIndex = 15;
            this.numeric_AntiDemontage.ValueChanged += new System.EventHandler(this.numeric_AntiDemontage_ValueChanged);
            // 
            // button_intervall
            // 
            this.button_intervall.Location = new System.Drawing.Point(4, 300);
            this.button_intervall.Name = "button_intervall";
            this.button_intervall.Size = new System.Drawing.Size(190, 23);
            this.button_intervall.TabIndex = 14;
            this.button_intervall.Text = "Reset";
            this.button_intervall.UseVisualStyleBackColor = true;
            this.button_intervall.Click += new System.EventHandler(this.button_intervall_Click);
            // 
            // label_schwellwert
            // 
            this.label_schwellwert.AutoSize = true;
            this.label_schwellwert.Location = new System.Drawing.Point(-2, 274);
            this.label_schwellwert.Name = "label_schwellwert";
            this.label_schwellwert.Size = new System.Drawing.Size(70, 13);
            this.label_schwellwert.TabIndex = 13;
            this.label_schwellwert.Text = "Schwellwert :";
            // 
            // label_interval
            // 
            this.label_interval.AutoSize = true;
            this.label_interval.Location = new System.Drawing.Point(12, 248);
            this.label_interval.Name = "label_interval";
            this.label_interval.Size = new System.Drawing.Size(56, 13);
            this.label_interval.TabIndex = 12;
            this.label_interval.Text = "Interavall :";
            // 
            // label_verschleiern
            // 
            this.label_verschleiern.AutoSize = true;
            this.label_verschleiern.Location = new System.Drawing.Point(0, 211);
            this.label_verschleiern.Name = "label_verschleiern";
            this.label_verschleiern.Size = new System.Drawing.Size(68, 13);
            this.label_verschleiern.TabIndex = 11;
            this.label_verschleiern.Text = "Verschleiert :";
            // 
            // label_komplexitaet
            // 
            this.label_komplexitaet.AutoSize = true;
            this.label_komplexitaet.Location = new System.Drawing.Point(1, 176);
            this.label_komplexitaet.Name = "label_komplexitaet";
            this.label_komplexitaet.Size = new System.Drawing.Size(67, 13);
            this.label_komplexitaet.TabIndex = 10;
            this.label_komplexitaet.Text = "Komplexität :";
            // 
            // label3_zuender_2
            // 
            this.label3_zuender_2.AutoSize = true;
            this.label3_zuender_2.Location = new System.Drawing.Point(21, 110);
            this.label3_zuender_2.Name = "label3_zuender_2";
            this.label3_zuender_2.Size = new System.Drawing.Size(47, 26);
            this.label3_zuender_2.TabIndex = 9;
            this.label3_zuender_2.Text = "Bester\r\nZünder :";
            // 
            // label_bomben
            // 
            this.label_bomben.AutoSize = true;
            this.label_bomben.Location = new System.Drawing.Point(11, 37);
            this.label_bomben.Name = "label_bomben";
            this.label_bomben.Size = new System.Drawing.Size(57, 26);
            this.label_bomben.TabIndex = 8;
            this.label_bomben.Text = "Anzahl der\r\n Bomben :";
            // 
            // label_Zuender
            // 
            this.label_Zuender.AutoSize = true;
            this.label_Zuender.Location = new System.Drawing.Point(11, 11);
            this.label_Zuender.Name = "label_Zuender";
            this.label_Zuender.Size = new System.Drawing.Size(57, 26);
            this.label_Zuender.TabIndex = 7;
            this.label_Zuender.Text = "Anzahl der\r\n Zünder :";
            // 
            // textBox_Schwellwert
            // 
            this.textBox_Schwellwert.Location = new System.Drawing.Point(74, 274);
            this.textBox_Schwellwert.Name = "textBox_Schwellwert";
            this.textBox_Schwellwert.ReadOnly = true;
            this.textBox_Schwellwert.Size = new System.Drawing.Size(120, 20);
            this.textBox_Schwellwert.TabIndex = 6;
            // 
            // textBox_Intervall
            // 
            this.textBox_Intervall.Location = new System.Drawing.Point(74, 248);
            this.textBox_Intervall.Name = "textBox_Intervall";
            this.textBox_Intervall.ReadOnly = true;
            this.textBox_Intervall.Size = new System.Drawing.Size(120, 20);
            this.textBox_Intervall.TabIndex = 5;
            // 
            // listBox_verschleiert
            // 
            this.listBox_verschleiert.FormattingEnabled = true;
            this.listBox_verschleiert.Items.AddRange(new object[] {
            "Nein",
            "Ja"});
            this.listBox_verschleiert.Location = new System.Drawing.Point(74, 212);
            this.listBox_verschleiert.Name = "listBox_verschleiert";
            this.listBox_verschleiert.Size = new System.Drawing.Size(120, 30);
            this.listBox_verschleiert.TabIndex = 4;
            this.listBox_verschleiert.SelectedIndexChanged += new System.EventHandler(this.listBox_verschleiert_SelectedIndexChanged);
            // 
            // listBox_komplexitaet
            // 
            this.listBox_komplexitaet.FormattingEnabled = true;
            this.listBox_komplexitaet.Items.AddRange(new object[] {
            "Einfach",
            "Durchschnittlich",
            "Komplex"});
            this.listBox_komplexitaet.Location = new System.Drawing.Point(74, 175);
            this.listBox_komplexitaet.Name = "listBox_komplexitaet";
            this.listBox_komplexitaet.Size = new System.Drawing.Size(120, 30);
            this.listBox_komplexitaet.TabIndex = 3;
            this.listBox_komplexitaet.SelectedIndexChanged += new System.EventHandler(this.listBox_komplexitaet_SelectedIndexChanged);
            // 
            // listBox_opti
            // 
            this.listBox_opti.FormattingEnabled = true;
            this.listBox_opti.Items.AddRange(new object[] {
            "Normal",
            "optischer Zünder"});
            this.listBox_opti.Location = new System.Drawing.Point(74, 108);
            this.listBox_opti.Name = "listBox_opti";
            this.listBox_opti.Size = new System.Drawing.Size(120, 30);
            this.listBox_opti.TabIndex = 2;
            this.listBox_opti.SelectedIndexChanged += new System.EventHandler(this.listBox_opti_SelectedIndexChanged);
            // 
            // numeric_bomben
            // 
            this.numeric_bomben.Location = new System.Drawing.Point(74, 43);
            this.numeric_bomben.Name = "numeric_bomben";
            this.numeric_bomben.Size = new System.Drawing.Size(120, 20);
            this.numeric_bomben.TabIndex = 1;
            this.numeric_bomben.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_bomben.ValueChanged += new System.EventHandler(this.numeric_bomben_ValueChanged);
            // 
            // numeric_Zuender
            // 
            this.numeric_Zuender.Location = new System.Drawing.Point(74, 17);
            this.numeric_Zuender.Name = "numeric_Zuender";
            this.numeric_Zuender.Size = new System.Drawing.Size(120, 20);
            this.numeric_Zuender.TabIndex = 0;
            this.numeric_Zuender.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_Zuender.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // textBox_Fehler
            // 
            this.textBox_Fehler.Location = new System.Drawing.Point(10, 341);
            this.textBox_Fehler.Name = "textBox_Fehler";
            this.textBox_Fehler.Size = new System.Drawing.Size(608, 20);
            this.textBox_Fehler.TabIndex = 10;
            // 
            // listBox_mehrfachBomben
            // 
            this.listBox_mehrfachBomben.FormattingEnabled = true;
            this.listBox_mehrfachBomben.Items.AddRange(new object[] {
            "Nein",
            "Ja"});
            this.listBox_mehrfachBomben.Location = new System.Drawing.Point(74, 70);
            this.listBox_mehrfachBomben.Name = "listBox_mehrfachBomben";
            this.listBox_mehrfachBomben.Size = new System.Drawing.Size(120, 30);
            this.listBox_mehrfachBomben.TabIndex = 17;
            this.listBox_mehrfachBomben.SelectedIndexChanged += new System.EventHandler(this.listBox_mehrfachBomben_SelectedIndexChanged);
            // 
            // label_multibomben
            // 
            this.label_multibomben.AutoSize = true;
            this.label_multibomben.Location = new System.Drawing.Point(12, 70);
            this.label_multibomben.Name = "label_multibomben";
            this.label_multibomben.Size = new System.Drawing.Size(51, 26);
            this.label_multibomben.TabIndex = 18;
            this.label_multibomben.Text = "Bomben \r\ngekopelt:\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 373);
            this.Controls.Add(this.textBox_Fehler);
            this.Controls.Add(this.groupBox_Intervall);
            this.Controls.Add(this.groupBox_Sprengstoff);
            this.Controls.Add(this.groupBox_Barriere);
            this.Name = "Form1";
            this.Text = "(^-^)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Panzerung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Struktur)).EndInit();
            this.groupBox_Barriere.ResumeLayout(false);
            this.groupBox_Barriere.PerformLayout();
            this.groupBox_Sprengstoff.ResumeLayout(false);
            this.groupBox_Sprengstoff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Sprengstoff)).EndInit();
            this.groupBox_Intervall.ResumeLayout(false);
            this.groupBox_Intervall.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_AntiDemontage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_bomben)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Zuender)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_Dicke;
        private System.Windows.Forms.Label label_Struktur;
        private System.Windows.Forms.NumericUpDown numeric_Struktur;
        private System.Windows.Forms.NumericUpDown numeric_Panzerung;
        private System.Windows.Forms.GroupBox groupBox_Barriere;
        private System.Windows.Forms.Label label_Panzerung;
        private System.Windows.Forms.Label label_Dicke;
        private System.Windows.Forms.Label label_Flaeche;
        private System.Windows.Forms.TextBox textBox_Flaeche;
        private System.Windows.Forms.Label label_Wiederstand_1_2;
        private System.Windows.Forms.Label label_Wiederstand_0;
        private System.Windows.Forms.TextBox textBox_W_1_2;
        private System.Windows.Forms.TextBox textBox_W_0;
        private System.Windows.Forms.Button button_Barriere;
        private System.Windows.Forms.GroupBox groupBox_Sprengstoff;
        private System.Windows.Forms.Button button_Sprengstoff;
        private System.Windows.Forms.Label label_n_verdaemmt;
        private System.Windows.Forms.Label label_verdaemmt;
        private System.Windows.Forms.TextBox textBox_n_verdaemmt;
        private System.Windows.Forms.Label label_Gewicht;
        private System.Windows.Forms.Label label_probe;
        private System.Windows.Forms.Label label_Sprengstoff;
        private System.Windows.Forms.TextBox textBox_verdaemmt;
        private System.Windows.Forms.TextBox textBox_Gewicht;
        private System.Windows.Forms.TextBox textBox_Probe;
        private System.Windows.Forms.NumericUpDown numeric_Sprengstoff;
        private System.Windows.Forms.GroupBox groupBox_Intervall;
        private System.Windows.Forms.TextBox textBox_Fehler;
        private System.Windows.Forms.Label label_schwellwert;
        private System.Windows.Forms.Label label_interval;
        private System.Windows.Forms.Label label_verschleiern;
        private System.Windows.Forms.Label label_komplexitaet;
        private System.Windows.Forms.Label label3_zuender_2;
        private System.Windows.Forms.Label label_bomben;
        private System.Windows.Forms.Label label_Zuender;
        private System.Windows.Forms.TextBox textBox_Schwellwert;
        private System.Windows.Forms.TextBox textBox_Intervall;
        private System.Windows.Forms.ListBox listBox_verschleiert;
        private System.Windows.Forms.ListBox listBox_komplexitaet;
        private System.Windows.Forms.ListBox listBox_opti;
        private System.Windows.Forms.NumericUpDown numeric_bomben;
        private System.Windows.Forms.NumericUpDown numeric_Zuender;
        private System.Windows.Forms.Button button_intervall;
        private System.Windows.Forms.Label label_AntiDemontage;
        private System.Windows.Forms.NumericUpDown numeric_AntiDemontage;
        private System.Windows.Forms.Label label_multibomben;
        private System.Windows.Forms.ListBox listBox_mehrfachBomben;
    }
}

