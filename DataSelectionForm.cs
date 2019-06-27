using System;
using System.Collections.Generic;
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
            if (TimePeriod_comboBox.SelectedItem.ToString() == "(fastStorage) 2013-8")
                AvalibleFileQuantity_label.Text = "Enter document number\n(1-1250 avalible documents)";
            else
                AvalibleFileQuantity_label.Text = "Enter document number\n(1-500 avalible documents)";
            FileNumber_textBox.Clear();
        }

        private void Analyze_button_Click(object sender, EventArgs e)
        {
            if (TimePeriod_comboBox.SelectedIndex > -1)
            {
                if (uint.TryParse(FileNumber_textBox.Text, out uint number))
                {
                    if (DataFromFile.ReadFromFile(TimePeriod_comboBox.SelectedItem.ToString(), number.ToString(),
                        out List<string> readDataList))
                    {
                        Plot_Form form = new Plot_Form(readDataList, this);
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
            else
            {
                MessageBox.Show("Select document time period from combobox");
            }
        }
    }
}
