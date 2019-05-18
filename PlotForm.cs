using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accord.Statistics;
using Accord.Statistics.Models.Regression.Linear;
using OxyPlot;
using OxyPlot.Series;


namespace ExtraTask
{
    public partial class Plot_Form : Form
    {
        public List<string> InputDataList;

        public Plot_Form()
        {
            InitializeComponent();
        }

        public Plot_Form(List<string> list)
        {
            InitializeComponent();
            InputDataList = list;
        }

        private void PlotBasedOn_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

                 
            var func = Algorithm.PolynomialRegresion(PlotBasedOn_comboBox.SelectedItem.ToString(), InputDataList, out SortedList<double, double> variableForPlotsList);
            //model.Series.Add(new FunctionSeries(func, variableForPlotsList.Keys[0], variableForPlotsList.Keys[variableForPlotsList.Count-1], 0.1));
            var dots = new OxyPlot.Series.LineSeries
            {
                LineStyle = LineStyle.None,
                MarkerType = MarkerType.Circle,
                MarkerSize = 4,
                MarkerStroke = OxyColors.Black
            };
            foreach (var pair in variableForPlotsList)
            {
                dots.Points.Add(new DataPoint(pair.Key, pair.Value));
                dots.Smooth = true;

                
            }
            model.Series.Add(dots);
            PoleReg_PlotView.Model = model;

        }
        public PlotModel model = new PlotModel { Title = "Plot" };

        private void Plot_Form_Load(object sender, EventArgs e)
        {

   

            string[] comboBoxComponent = new string[]
            {
                "CPU cores",
                "CPU capacity provisioned [MHZ]",
                "CPU usage [MHZ]", "CPU usage [%]",
                "Memory capacity provisioned [KB]",
                "Memory usage [KB]",
                "Disk read throughput [KB/s]",
                "Disk write throughput [KB/s];",
                "Network received throughput [KB/s]",
                "Network transmitted throughput [KB/s]"
            };

            PlotBasedOn_comboBox.Items.AddRange(comboBoxComponent);
        }

        private void PlotPR_pannel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
