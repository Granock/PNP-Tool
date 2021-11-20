using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sprengstoff_Rechner_SR5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numeric_Struktur.Value = 1;
            numeric_Panzerung.Value = 1;
            numeric_Sprengstoff.Value = 1;
            textBox_Dicke.Text = "1";
            textBox_Flaeche.Text = "1";
            textBox_Probe.Text = "0";
            textBox_Gewicht.Text = "1000";
            listBox_komplexitaet.SelectedIndex = 0;
            listBox_opti.SelectedIndex = 0;
            listBox_verschleiert.SelectedIndex = 0;
            groupBox_Sprengstoff.Enabled = false;
            groupBox_Intervall.Enabled = false;
            textBox_Fehler.Clear();
            listBox_mehrfachBomben.SelectedIndex = 0;
        }

        private void Wiederstand_Barriere()
        {
            //Variable defineieren und Füllen
            decimal Struktur = numeric_Struktur.Value;
            decimal Panzerung = numeric_Panzerung.Value;
            decimal Dicke = 1;
            decimal Flaeche = 1;
            //Variable füllen, mit Sicherheit eingebaut
            try
            {
                Dicke = Decimal.Parse(textBox_Dicke.Text);
                Flaeche = Decimal.Parse(textBox_Flaeche.Text);
            }
            catch(FormatException)
            {
                Dicke = 1;
                Flaeche = 1;
                textBox_Fehler.Text = "Umwandlungsfehler beim errechnen der Barriere";
            }
            //Barrierenstärke berechnen
            //gibt bei Pa = 1 und St = 1 einen Wert von 1 statt 2 aus
            textBox_W_1_2.Text = Math.Ceiling(((Math.Ceiling(Struktur * Dicke)) + Math.Floor(((Math.Ceiling(Struktur * Dicke)) + Math.Ceiling((Math.Ceiling(Panzerung * Dicke)) / 2)) / 4))*Flaeche) + "K";
            textBox_W_0.Text=    Math.Ceiling(((Math.Ceiling(Struktur * Dicke)) + Math.Floor(((Math.Ceiling(Struktur * Dicke)) + (Math.Ceiling(Panzerung * Dicke))) / 4))*Flaeche) + "K";
        }

        private void Sprengstoff_staerke()
        {
            //Variablen erstellen
            double Sprengstoff_Stufe = 1;
            double Gewicht = 1000;
            double Probe = 0;
            //Variablen füllen mit Sicherheit
            try
            {
                Sprengstoff_Stufe = double.Parse("" + numeric_Sprengstoff.Value);
                Gewicht = double.Parse(textBox_Gewicht.Text);
                Probe = double.Parse(textBox_Probe.Text);
            }
            catch (FormatException)
            {
                Sprengstoff_Stufe = 1;
                Gewicht = 1000;
                Probe = 0;
                textBox_Fehler.Text="Umwandlugsfehler bei Errechner der Sprengladung";
            }
            //Sprengsatz-Stärke berechnen
            textBox_verdaemmt.Text =   (Math.Ceiling((Sprengstoff_Stufe + Probe) * Math.Sqrt((Gewicht / 1000))) * 4) + "K";
            textBox_n_verdaemmt.Text = (Math.Ceiling((Sprengstoff_Stufe + Probe) * Math.Sqrt((Gewicht / 1000))) * 2) + "K";
            //gibt bei 10kg stufe 22 1K zuviel an
        }

        private void Intervall_Schwellwert()
        {
            //Variabeln bestimmen
            decimal Anzahl_Bomben = numeric_bomben.Value;
            decimal Komplexität = listBox_komplexitaet.SelectedIndex;
            decimal Verschleiert = listBox_verschleiert.SelectedIndex;
            string Interval = "";
            decimal Schwellwert = 0;
            if (Anzahl_Bomben == 1)
            {
                switch (Komplexität)
                {
                    case 0:
                        Interval = "10min";
                        Schwellwert = 6;
                        break;
                    case 1:
                        Interval = "1 Stunde";
                        Schwellwert = 12;
                        break;
                    case 2:
                        Interval = "1 Tag";
                        Schwellwert = 18;
                        break;
                }
            }
            else
            {
                if (listBox_mehrfachBomben.SelectedIndex > 0)
                    switch (Komplexität)
                    {
                    case 0:
                        Interval = "30min";
                        Schwellwert = 6 + Anzahl_Bomben;
                        break;
                    case 1:
                        Interval = "1 Stunde";
                        Schwellwert = 12 + Anzahl_Bomben;
                        break;
                    case 2:
                        Interval = "1 Tag";
                        Schwellwert = 18 + Anzahl_Bomben;
                        break;
                    }
                else
                    switch (Komplexität)
                    {
                        case 0:
                            Interval = "30min";
                            Schwellwert = 6 * Anzahl_Bomben;
                            break;
                        case 1:
                            Interval = "1 Stunde";
                            Schwellwert = 12 * Anzahl_Bomben;
                            break;
                        case 2:
                            Interval = "1 Tag";
                            Schwellwert = 18 * Anzahl_Bomben;
                            break;
                    }
            }
            if (Verschleiert ==1)
            {
                textBox_Intervall.Text = Interval;
                textBox_Schwellwert.Text = ("Sprengstoff + Logik[" + (Schwellwert*2) + "]");
            }
            else
            {
                textBox_Intervall.Text = Interval;
                textBox_Schwellwert.Text = ("Sprengstoff + Logik[" + (Schwellwert) + "]");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void numeric_Struktur_ValueChanged(object sender, EventArgs e)
        {
            if (numeric_Struktur.Value <= 0)
                numeric_Struktur.Value = 1;
            Wiederstand_Barriere();
        }

        private void numeric_Panzerung_ValueChanged(object sender, EventArgs e)
        {
            if (numeric_Panzerung.Value <= 0)
                numeric_Panzerung.Value = 1;
            Wiederstand_Barriere();
        }

        private void textBox_Dicke_Leave(object sender, EventArgs e)
        {
            try
            {
                decimal.Parse(textBox_Dicke.Text);
            }
            catch (FormatException)
            {
                textBox_Dicke.Text = "1";
            }
            Wiederstand_Barriere();
        }

        private void textBox_Flaeche_Leave(object sender, EventArgs e)
        {
            try
            {
                decimal.Parse(textBox_Flaeche.Text);
            }
            catch (FormatException)
            {
                textBox_Flaeche.Text = "1";
            }
            Wiederstand_Barriere();
        }

        private void button_Barriere_Click(object sender, EventArgs e)
        {
            Wiederstand_Barriere();
            groupBox_Sprengstoff.Enabled = true;
            groupBox_Barriere.Enabled = false;
        }

        private void numeric_Sprengstoff_ValueChanged(object sender, EventArgs e)
        {
            if (numeric_Sprengstoff.Value <= 0)
                numeric_Sprengstoff.Value = 1;
            if(numeric_Sprengstoff.Value > 25)
                numeric_Sprengstoff.Value = 25;
            Sprengstoff_staerke();
        }

        private void textBox_Probe_Leave(object sender, EventArgs e)
        {
            try
            {
                decimal.Parse(textBox_Probe.Text);
            }
            catch (FormatException)
            {
                textBox_Probe.Text = "0";
            }
            Sprengstoff_staerke();
        }

        private void textBox_Gewicht_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if ((decimal.Parse(textBox_Gewicht.Text)) > 5000)
                    listBox_komplexitaet.SelectedIndex = 1;
                if((decimal.Parse(textBox_Gewicht.Text)) > 10000)
                    listBox_komplexitaet.SelectedIndex = 2;
            }
            catch (FormatException)
            {
                textBox_Gewicht.Text = "1000";
            }
            Sprengstoff_staerke();
        }

        private void button_Sprengstoff_Click(object sender, EventArgs e)
        {
            Sprengstoff_staerke();
            groupBox_Intervall.Enabled = true;
            groupBox_Sprengstoff.Enabled = false;
            listBox_mehrfachBomben.Enabled = false;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numeric_Zuender.Value <= 0)
                numeric_Zuender.Value = 1;
            if ((numeric_Zuender.Value > 1) & (listBox_komplexitaet.SelectedIndex <= 0))
                listBox_komplexitaet.SelectedIndex = 1;
            if((numeric_Zuender.Value > 3) & (listBox_komplexitaet.SelectedIndex <= 1))
                listBox_komplexitaet.SelectedIndex = 2;
            Intervall_Schwellwert();

        }

        private void listBox_komplexitaet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((numeric_Zuender.Value > 1) & (listBox_komplexitaet.SelectedIndex <= 0))
                listBox_komplexitaet.SelectedIndex = 1;
            if ((numeric_Zuender.Value > 3) & (listBox_komplexitaet.SelectedIndex <= 1))
                listBox_komplexitaet.SelectedIndex = 2;
            if (listBox_opti.SelectedIndex >= 1)
                listBox_komplexitaet.SelectedIndex = 2;
            if ((numeric_AntiDemontage.Value > 0) & (listBox_komplexitaet.SelectedIndex < 1))
                listBox_komplexitaet.SelectedIndex = 1;
            if ((numeric_AntiDemontage.Value > 4) & (listBox_komplexitaet.SelectedIndex < 2))
                listBox_komplexitaet.SelectedIndex = 2;
            Intervall_Schwellwert();
        }

        private void listBox_opti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_opti.SelectedIndex >= 1)
                listBox_komplexitaet.SelectedIndex = 2;
            Intervall_Schwellwert();
        }

        private void numeric_bomben_ValueChanged(object sender, EventArgs e)
        {
            if (numeric_bomben.Value <= 0)
                numeric_bomben.Value = 1;
            if (numeric_bomben.Value > 1)
                listBox_mehrfachBomben.Enabled = true;
            else
                listBox_mehrfachBomben.Enabled = false;
            Intervall_Schwellwert();
        }

        private void listBox_verschleiert_SelectedIndexChanged(object sender, EventArgs e)
        {
            Intervall_Schwellwert();
        }

        private void button_intervall_Click(object sender, EventArgs e)
        {
            groupBox_Sprengstoff.Enabled = false;
            groupBox_Barriere.Enabled = true;
            groupBox_Intervall.Enabled = false;
        }

        private void numeric_AntiDemontage_ValueChanged(object sender, EventArgs e)
        {
            if (numeric_AntiDemontage.Value >= 13)
                numeric_AntiDemontage.Value = 12;
            if (numeric_AntiDemontage.Value > 0)
                listBox_komplexitaet.SelectedIndex = 1;
            if (numeric_AntiDemontage.Value > 4)
                listBox_komplexitaet.SelectedIndex = 2;
        }

        private void listBox_mehrfachBomben_SelectedIndexChanged(object sender, EventArgs e)
        {
            Intervall_Schwellwert();
        }
    }
}
