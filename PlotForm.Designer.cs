namespace ExtraTask
{
    partial class Plot_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.PlotBasedOn_comboBox = new System.Windows.Forms.ComboBox();
            this.Plot_panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plot based on...";
            // 
            // PlotBasedOn_comboBox
            // 
            this.PlotBasedOn_comboBox.FormattingEnabled = true;
            this.PlotBasedOn_comboBox.Location = new System.Drawing.Point(99, 12);
            this.PlotBasedOn_comboBox.Name = "PlotBasedOn_comboBox";
            this.PlotBasedOn_comboBox.Size = new System.Drawing.Size(121, 21);
            this.PlotBasedOn_comboBox.TabIndex = 1;
            this.PlotBasedOn_comboBox.Text = "Select";
            this.PlotBasedOn_comboBox.SelectedIndexChanged += new System.EventHandler(this.PlotBasedOn_comboBox_SelectedIndexChanged);
            // 
            // Plot_panel
            // 
            this.Plot_panel.Location = new System.Drawing.Point(12, 51);
            this.Plot_panel.Name = "Plot_panel";
            this.Plot_panel.Size = new System.Drawing.Size(776, 433);
            this.Plot_panel.TabIndex = 2;
            // 
            // Plot_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.Plot_panel);
            this.Controls.Add(this.PlotBasedOn_comboBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Plot_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plot";
            this.Load += new System.EventHandler(this.Plot_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PlotBasedOn_comboBox;
        private System.Windows.Forms.Panel Plot_panel;
    }
}