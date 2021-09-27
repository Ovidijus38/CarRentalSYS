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

namespace CarRentalSYS
{
    

    public partial class frmYearlyRevenueAnalysis : Form
    {
        private frmAdmin parent;

        public frmYearlyRevenueAnalysis(frmAdmin Parent)
        {
            InitializeComponent();
            parent = Parent;
        }



        public frmYearlyRevenueAnalysis()
        {
            InitializeComponent();
        }

        private void frmYearlyRevenueAnalysis_Load(object sender, EventArgs e)
        {
            chartYearlyRevenue.Series.RemoveAt(0);
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        //https://www.c-sharpcorner.com/UploadFile/suthish_nair/mschart-how-to-draw-a-line-or-multiple-line-chart/
        //https://www.youtube.com/watch?v=6ua-IegyKB4
        //https://www.advsofteng.com/doc/cdnetdoc/multibar.htm

        private void comboBoxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            int yearNumber = int.Parse(comboBoxYear.SelectedItem.ToString());
            List<string[]> catIdAndDescriptionList = Category.GetCatIdAndDescriptionList();

            chartYearlyRevenue.ChartAreas[0].AxisX.Interval = 1;
            chartYearlyRevenue.Titles.Add("Yearly Revenue");
            string[] months = new string[12] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            foreach (string[] catIdAndDescription in catIdAndDescriptionList)
            {


                string seriesName = catIdAndDescription[0] + "-" + catIdAndDescription[1];
                string carsClassCode = catIdAndDescription[0];
                chartYearlyRevenue.Series.Add(seriesName); //adds created class automatically, dinamically
                
                for (int i = 0; i < months.Length; i++)
                {
                    int monthNumber = i + 1;

                    double monthSalesValue = Utility.GetSelectedYearSelectedMonthRevenueForSelectedCarClass(yearNumber, monthNumber, carsClassCode);
                    chartYearlyRevenue.Series[seriesName].Points.AddXY(months[i], monthSalesValue);
                }



            }
            
            //Axis axisX = chartYearlyRevenue.ChartAreas[0].AxisX;
            //double axisLabelPos = 0.5;
            //for (int i = 0; i < months.Length; i++)
            //{
            //    axisX.CustomLabels.Add(axisLabelPos, axisLabelPos + 1, months[i]);
            //    axisLabelPos = axisLabelPos + 1.0;
            //}
        }

        private void chartYearlyRevenue_Click(object sender, EventArgs e)
        {

        }
    }
}
