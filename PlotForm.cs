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

        }
    }
}
