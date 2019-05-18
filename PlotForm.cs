using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Series;


namespace ExtraTask
{
    public partial class Plot_Form : Form
    {
        private List<string> InputDataList;
        private DataSelection_Form MainFormObj;

        public Plot_Form()
        {
            InitializeComponent();
        }

        public Plot_Form(List<string> list, DataSelection_Form obj)
        {
            InitializeComponent();
            InputDataList = list;
            MainFormObj = obj;
        }

        public PlotModel model = new PlotModel { Title = "Plot" };
        
        private void PlotBasedOn_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PlotModel model = new PlotModel { Title = "Plot" };
            LineSeries dots = new LineSeries
            {
                LineStyle = LineStyle.None,
                MarkerType = MarkerType.Circle,
                MarkerSize = 1.5,
                //MarkerStroke = OxyColors.Black
            };

            PoleReg_PlotView.Model = model;

            double[] coefForFunc = Algorithm.PolynomialRegresion(PlotBasedOn_comboBox.SelectedItem.ToString(), InputDataList, out SortedList<double, double> variableForPlotsList);

            Func<double, double> func = x => coefForFunc[1] * x + coefForFunc[0];

            model.Series.Add(new FunctionSeries(func, variableForPlotsList.Keys[0], variableForPlotsList.Keys[variableForPlotsList.Count-1], 0.1));

            foreach (var pair in variableForPlotsList)
            {
                dots.Points.Add(new DataPoint(pair.Key, pair.Value));
                dots.Smooth = true;
 
            }
            model.Series.Add(dots);
            PoleReg_PlotView.Model = model;
        }

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

        private void Plot_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainFormObj.Close();
        }
    }
}
