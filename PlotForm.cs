using System;
using System.Drawing;
using Accord;

//using OxyPlot;
//using OxyPlot.Series;


namespace ExtraTask
{
using System.Collections.Generic;
using System.Windows.Forms;
using ZedGraph;
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

        private void PlotBasedOn_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            GraphPane pane = zedGraphControl1.GraphPane;
            pane.XAxis.Title.Text = "Time";
            pane.YAxis.Title.Text = PlotBasedOn_comboBox.Text;
            pane.Title.Text = "Polinomial regression";

            pane.CurveList.Clear();
            PointPairList dots = new PointPairList();

            var variablePair = DataFromFile.ParseSelectedColumn(PlotBasedOn_comboBox.SelectedItem.ToString(), InputDataList);

            if (normalizedData_CheckBox.Checked == true)
            {
                Algorithm.InputDataNormalization(ref variablePair);
            }
            PointPairList func = new PointPairList(Algorithm.PolynomialRegresion(variablePair, 3));

            LineItem myCurve = pane.AddCurve("Polynomial Regression", func, Color.Red, SymbolType.None);

            foreach (var pair in variablePair)
            {
                dots.Add(pair.Key, pair.Value);
            }

            LineItem myDots = pane.AddCurve(null, dots, Color.Blue, SymbolType.Diamond);
            if(linealGraph_CheckBox.Checked == true)
            {
                myDots.Line.IsVisible = false;
            }
            else
            {
                myDots.Line.IsVisible = true;
            }
            myDots.Symbol.Fill.Color = Color.Blue;
            myDots.Symbol.Fill.Type = FillType.Solid;
            myDots.Symbol.Size = 3;

            pane.YAxis.Scale.MinAuto = true;
            pane.YAxis.Scale.MaxAuto = true;
            pane.XAxis.Scale.MinAuto = true;
            pane.XAxis.Scale.MaxAuto = true;

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

        private void linealGraph_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            PlotBasedOn_comboBox_SelectedIndexChanged(sender, e);
        }

        private void normalizedData_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            PlotBasedOn_comboBox_SelectedIndexChanged(sender, e);
        }
    }
}