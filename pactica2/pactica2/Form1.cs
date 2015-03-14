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
using modifiedSearch;
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
        private int selectedResult(Results result)
        {
            if (this.radioButton1.Checked)
            {
                return result.comparisons;
            }
            if (this.radioButton2.Checked)
            {
                return result.swaps;
            }
            if (this.radioButton3.Checked)
            {
                return result.comparisons + result.swaps;
            }
            return result.comparisons;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //declares the initial variables 
           
            this.chart1.Titles.Clear();
            this.chart1.Series.Clear();
            this.chart1.Titles.Add("small");
            //aki agrega lo demas
            List<Results> smallResults = Tests.generateSmallTests();

            foreach( Results result in smallResults){
                Series series = this.chart1.Series.Add(result.name);
                series.Points.Add(selectedResult(result));
            }
            chart1.Visible = true;

            this.chart2.Titles.Clear();
            this.chart2.Series.Clear();
            this.chart2.Titles.Add("big");
            List<Results> bigResults = Tests.generateBigTests();
            foreach (Results result in bigResults)
            {
                Series series = this.chart2.Series.Add(result.name);
                series.Points.Add(result.comparisons);
            }
            chart2.Visible = true;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
