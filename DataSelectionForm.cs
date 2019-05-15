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
    public partial class DataSelection_Form : Form
    {
        public DataSelection_Form()
        {
            InitializeComponent();
        }

        private void TimePeriod_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TimePeriod_comboBox.SelectedItem.ToString() == "(fastStorage) 2013-08")
                AvalibleFileQuantity_label.Text = "Enter document number\n(0-1250 avalible documents)";
            else
                AvalibleFileQuantity_label.Text = "Enter document number\n(0-500 avalible documents)";
            FileNumber_textBox.Clear();
        }

        private void Analyze_button_Click(object sender, EventArgs e)
        {
            if (uint.TryParse(FileNumber_textBox.Text, out uint number))
            {
                if (DataFromFile.ReadFromFile(TimePeriod_comboBox.SelectedItem.ToString(), number.ToString(),
                    out List<string> readDataList))
                {
                    Plot_Form form = new Plot_Form(readDataList);
                    form.Show();
                    Hide();
                }
                else
                {
                    FileNumber_textBox.Clear();
                    MessageBox.Show("There is no such document");
                }
            }
            else
            {
                FileNumber_textBox.Clear();
                MessageBox.Show("This value should be integer");
            }
        }
    }
}
