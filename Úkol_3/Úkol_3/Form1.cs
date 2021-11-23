using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Úkol_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num, a = 0, c = 1, d = 0, MIN = Int32.MaxValue, MAX = Int32.MinValue;
            bool mimo = false;
            foreach (string x in textBox.Lines)
            {
                try 
                { 
                    num = int.Parse(x);
                    if (num % 2 != 0) { a++; }
                    if (num < 5 || num > 19) { c = c * num; mimo = true; }
                    if (num < MIN) { MIN = num; }
                    if (num > MAX) { MAX = num; }
                }
                catch { MessageBox.Show("!!Špatná hodnota!!"); break; }
            }
            while (MAX != 0) { d += (MAX % 10); MAX /= 10; }
            lbl_a.Text = "A) Počet lichých čísel: " + a.ToString();
            lbl_b.Text = "B) Minimální číslo: " + MIN.ToString();
            if (mimo == false) { lbl_c.Text = "C) Mimo interval <5;20) neleží žadne cislo!"; }
            else { lbl_c.Text = "C) Součin čísel neležících v intervalu <5;20): " + c.ToString(); }
            lbl_d.Text = "D) Ciferný součet maximálního čísla: " + d.ToString();
        }
    }
}
