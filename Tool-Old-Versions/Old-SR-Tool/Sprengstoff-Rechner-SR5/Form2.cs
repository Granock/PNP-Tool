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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //Definieren der Variablen:
        int Mod_Barriere;

        private void Form2_Load(object sender, EventArgs e)
        {
            Komplexität.SelectedIndex = 0;
            Verdaemmung.SelectedIndex = 0;
            Probe_Statik.SelectedIndex = 0;
            Gewicht.Text = "1000";
            Box_S1.Enabled = true;
            Box_S2.Enabled = false;
            Box_S3.Enabled = false;
            Mod_Barriere = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(Int32.Parse(Gewicht.Text) > 5000)
            {
                    if (Int32.Parse(Gewicht.Text) > 10000)
                    {
                        Komplexität.SelectedIndex = 2;
                    }
                    else
                    {
                        if (Komplexität.SelectedIndex <= 0)
                        {
                            Komplexität.SelectedIndex = 1;
                        }
                    }
                }
            else
            {
                    if (Komplexität.SelectedIndex <= -1)
                    {
                        Komplexität.SelectedIndex = 0;
                    }
                    if (Int32.Parse(Gewicht.Text) < 1)
                    {
                        Gewicht.Text = "1";
                    }
                }
            }
            catch (FormatException)
            {
                Gewicht.Text = "1";
            }
            Schadenscode();
        }

        private void Stufe_ValueChanged(object sender, EventArgs e)
        {
            if (Stufe.Value <= 0)
            {
                Stufe.Value = 1;
            }
            Schadenscode();
        }

        private void Schadenscode()
        {

        }

        private void Panzerung_ValueChanged(object sender, EventArgs e)
        {
            if (Panzerung.Value <= 0)
            {
                Panzerung.Value = 1;
            }
            Schritt1_schaden();
        }

        private void Structur_ValueChanged(object sender, EventArgs e)
        {
            if (Structur.Value <= 0)
            {
                Structur.Value = 1;
            }
            Schritt1_schaden();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (Stockwerke.Value <= 0)
            {
                Stockwerke.Value = 1;
            }
            Schritt1_schaden();
        }

        private void Bomben_stock_ValueChanged(object sender, EventArgs e)
        {
            if (Bomben_stock.Value <= 0)
            {
                Bomben_stock.Value = 1;
            }
            Schritt1_schaden();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Probe_Statik.SelectedIndex)
            {
                case 0:
                    Mod_Barriere = 0;
                    break;
                case 1:
                    Mod_Barriere = 20;
                    break;
                case 2:
                    Mod_Barriere = 40;
                    break;
                case 3:
                    Mod_Barriere = 60;
                    break;
            }
            Schritt1_schaden();
        }

        private void Schritt1_schaden()
        {
            Decimal Schaden = 0;
            Schaden = Structur.Value + (Panzerung.Value / 2) + Math.Truncate((Structur.Value + (Panzerung.Value / 2))/4);
            MessageBox.Show(Schaden + "");
        }

        private void button_S1_Click(object sender, EventArgs e)
        {
            Box_S1.Enabled = false;
            Box_S2.Enabled = true;
            Random r = new Random();
            r.Next(0, 1);


        }
    }
}
