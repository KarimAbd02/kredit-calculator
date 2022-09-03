using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace percentCalc
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            total.Controls[0].Visible = false;
        }         

       

        private void comboprocess_SelectedIndexChanged(object sender, EventArgs e)
        {

            label7.Text = (sender as ComboBox).Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            numstartcount.ResetText();
            numpercent.ResetText();
            numyears.ResetText();
            comboprocess.ResetText();
            total.ResetText();
            label7.ResetText();
            label8.ResetText();
        }

        public void calc_Click(object sender, EventArgs e)
        {
            double startcount = Convert.ToDouble(numstartcount.Value);
            double rate = Convert.ToDouble(numpercent.Value);
            int years = Convert.ToInt32(numyears.Value);
            double kredit;
            rate = rate / 100;
            int periods = 0;
            double yearRate = rate;

            // Calculate savings using the following Formula: p=c(1+r/n)^nt
            if (comboprocess.SelectedIndex == 0)
            {
                double dayRate = rate / 365;
                periods = years * 365;
                startcount = startcount * Math.Pow((1 + dayRate), periods);
                total.Text = Convert.ToString(Math.Round(startcount, 2));
                kredit = startcount / periods;
                label8.Text = Convert.ToString(Math.Round(kredit, 2));

            }
            else if (comboprocess.SelectedIndex == 1)
            {
                double monthRate = rate / 12;
                periods = years * 12;
                startcount = startcount * Math.Pow((1 + monthRate), periods);
                total.Text = Convert.ToString(Math.Round(startcount, 2));
                kredit = startcount / periods;
                label8.Text = Convert.ToString(Math.Round(kredit, 2));
            }
            else if (comboprocess.SelectedIndex == 2)
            {
                double quarterRate = rate / 4;
                periods = years * 4;
                startcount = startcount * Math.Pow((1 + quarterRate), periods);
                total.Text = Convert.ToString(Math.Round(startcount, 2));
                kredit = startcount / periods;
                label8.Text = Convert.ToString(Math.Round(kredit, 2));
            }
            else if (comboprocess.SelectedIndex == 3)
            {
                double halfyearRate = rate / 2;
                periods = years * 2;
                startcount = startcount * Math.Pow((1 + halfyearRate), periods);
                total.Text = Convert.ToString(Math.Round(startcount, 2));
                kredit = startcount / periods;
                label8.Text = Convert.ToString(Math.Round(kredit, 2));
            }
            else if (comboprocess.SelectedIndex == 4)
            { 
                periods = years;
                startcount = startcount * Math.Pow((1 + yearRate), periods);
                total.Text = Convert.ToString(Math.Round(startcount, 2));
                kredit = startcount / periods;
                label8.Text = Convert.ToString(Math.Round(kredit, 2));
            }
            else
            {
                MessageBox.Show("Введите все значения");

            }
        }
    }
}
