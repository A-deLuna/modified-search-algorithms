using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace pactica2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //declares the initial variables 
            List<Results> check = Tests.generateTests();
            this.chart1.Titles.Clear();
            this.chart1.Series.Clear();
            this.chart1.Titles.Add("Results");
            //aki agrega lo demas

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
