using System;
using System.Drawing;
using Accord;

namespace ExtraTask
{
    using System.Collections.Generic;
    using System.Windows.Forms;
    using ZedGraph;
    public partial class Plot_Form : Form
    {
        private List<string> InputDataList;
        private DataSelection_Form MainFormObj;
        private bool rebuiltPlot = false;

        public Plot_Form(List<string> list, DataSelection_Form obj)
        {
            InitializeComponent();
            InputDataList = list;
            MainFormObj = obj;
        }

        private GraphPane pane;

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

            pane = Plot_zedGraph.GraphPane;
            pane.XAxis.Title.Text = "Time";
            pane.YAxis.Title.Text = "Choose performance type";
            pane.Title.Text = "VMs preformance data clasification";
        }

        private void PlotBasedOn_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            rebuiltPlot = true;
        }

        private void OnlyDots_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PlotBasedOn_comboBox.SelectedIndex > -1)
                rebuiltPlot = true;
        }

        private void NormalizedData_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PlotBasedOn_comboBox.SelectedIndex > -1)
                rebuiltPlot = true;
        }

        private void BayesClassifier_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PlotBasedOn_comboBox.SelectedIndex > -1)
                rebuiltPlot = true;
        }

        private void PlotDrawing_timer_Tick(object sender, EventArgs e)
        {
            if (rebuiltPlot)
            {
                pane.CurveList.Clear();

                pane.YAxis.Title.Text = PlotBasedOn_comboBox.SelectedItem.ToString();

                var variablePair = DataFromFile.ParseSelectedColumn(PlotBasedOn_comboBox.SelectedItem.ToString(), InputDataList);

                if (NormalizedData_CheckBox.Checked)
                {
                    Algorithm.InputDataNormalization(ref variablePair);
                    pane.YAxis.Scale.Min = -0.1;
                    pane.YAxis.Scale.Max = 1.1;
                }
                else
                {
                    pane.YAxis.Scale.MinAuto = true;
                    pane.YAxis.Scale.MaxAuto = true;
                }

                Dictionary<double, double> resultOfClassification = new Dictionary<double, double>();

                if (BayesClassifier_checkBox.Checked)
                    resultOfClassification = Algorithm.BayesClassifier(InputDataList);

                if (!OnlyDots_CheckBox.Checked)
                {
                    PointPairList func = new PointPairList(Algorithm.PolynomialRegresion(variablePair, 3));

                    LineItem myCurve = pane.AddCurve("Polynomial Regression", func, Color.Red, SymbolType.None);
                }

                PointPairList dotsRed = new PointPairList();
                PointPairList dotsGreen = new PointPairList();

                foreach (var pair in variablePair)
                {
                    if (resultOfClassification.TryGetValue(pair.Key, out double value) && Math.Round(value * 10) == 1)
                        dotsRed.Add(pair.Key, pair.Value);
                    else
                        dotsGreen.Add(pair.Key, pair.Value);
                }

                LineItem myDotsRed = pane.AddCurve(null, dotsRed, Color.Red, SymbolType.Diamond);
                LineItem myDotsGreen = pane.AddCurve(null, dotsGreen, Color.Green, SymbolType.Diamond);

                myDotsRed.Symbol.Fill.Type = FillType.Solid;
                myDotsRed.Symbol.Size = 3;
                myDotsRed.Line.IsVisible = false;
                myDotsGreen.Symbol.Fill.Type = FillType.Solid;
                myDotsGreen.Symbol.Size = 3;
                myDotsGreen.Line.IsVisible = false;

                pane.XAxis.Scale.Min = -20;
                pane.XAxis.Scale.Max = 750;

                pane.AxisChange();

                Plot_zedGraph.Refresh();

                rebuiltPlot = false;
            }
        }

        private void Plot_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainFormObj.Close();
        }

        private void ChangeFile_button_Click(object sender, EventArgs e)
        {
            MainFormObj.Show();
            Hide();
        }
    }
}