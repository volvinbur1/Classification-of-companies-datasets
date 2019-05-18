using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Algorithm.PolynomialRegresion(PlotBasedOn_comboBox.SelectedItem.ToString(), InputDataList);
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
    }
}
