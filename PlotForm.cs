using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ZedGraph;
using System.Drawing;
//using OxyPlot;
//using OxyPlot.Series;


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

        
        //public PlotModel model = new PlotModel { Title = "Polynomial Regression Plot" };
       

        private void PlotBasedOn_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //Func<double, double> func = x => coefForFunc[1] * x + coefForFunc[0];

            


            GraphPane pane = zedGraphControl1.GraphPane;
            pane.XAxis.Title.Text = "Time";
            pane.YAxis.Title.Text = PlotBasedOn_comboBox.Text;
            pane.Title.Text = "Polinomial regression";

            pane.CurveList.Clear();
            PointPairList dots = new PointPairList();
            PointPairList func = new PointPairList(Algorithm.PolynomialRegresion(PlotBasedOn_comboBox.SelectedItem.ToString(), InputDataList, out SortedList<double, double> variableForPlotsList, 5));

            LineItem myCurve = pane.AddCurve("Polynomial Regression", func, Color.Red, SymbolType.None );

            //PointPairList dots = new PointPairList();
            
            foreach (var pair in variableForPlotsList)
            {
                dots.Add(pair.Key, pair.Value);
            }

            LineItem myDots = pane.AddCurve(null, dots, Color.Green, SymbolType.Circle);
            myDots.Line.IsVisible = false;
            myDots.Symbol.Fill.Color = Color.Green;
            myDots.Symbol.Fill.Type = FillType.Solid;
            myDots.Symbol.Size = 3;
            //PlotModel model = new PlotModel { Title = "Polynomial Regression Plot"};


            //LineSeries dots = new LineSeries
            //{ 
            //    //Color = OxyColors.Black,
            //    LineStyle = LineStyle.None,              
            //    MarkerType = MarkerType.Circle,
            //    MarkerSize = 1.5,
            //    //MarkerStroke = OxyColors.Black
            //};
            //var myController = new PlotController();
            //PoleReg_PlotView.Controller = myController;

            //PoleReg_PlotView.Model = model;

            //double[] coefForFunc = Algorithm.PolynomialRegresion(PlotBasedOn_comboBox.SelectedItem.ToString(), InputDataList, out SortedList<double, double> variableForPlotsList);

            //Func<double, double> func = x => coefForFunc[1] * x + coefForFunc[0];

            //model.Series.Add(new FunctionSeries(func, variableForPlotsList.Keys[0], variableForPlotsList.Keys[variableForPlotsList.Count - 1], 0.1, "Polynomial Regression"));        

            //foreach (var pair in variableForPlotsList)
            //{
            //    dots.Points.Add(new DataPoint(pair.Key, pair.Value));
            //    dots.Smooth = true;

            //}
            //model.Series.Add(dots);
            //PoleReg_PlotView.Model = model;
            //pane.XAxis.Scale.Min = xmin;

            //pane.YAxis.Scale.Min = ymin;

            pane.AxisChange();
            pane.AxisChange();
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