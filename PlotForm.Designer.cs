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
            this.PoleReg_PlotView = new OxyPlot.WindowsForms.PlotView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plot based on...";
            // 
            // PlotBasedOn_comboBox
            // 
            this.PlotBasedOn_comboBox.FormattingEnabled = true;
            this.PlotBasedOn_comboBox.Location = new System.Drawing.Point(132, 15);
            this.PlotBasedOn_comboBox.Margin = new System.Windows.Forms.Padding(4);
            this.PlotBasedOn_comboBox.Name = "PlotBasedOn_comboBox";
            this.PlotBasedOn_comboBox.Size = new System.Drawing.Size(160, 24);
            this.PlotBasedOn_comboBox.TabIndex = 1;
            this.PlotBasedOn_comboBox.Text = "Select";
            this.PlotBasedOn_comboBox.SelectedIndexChanged += new System.EventHandler(this.PlotBasedOn_comboBox_SelectedIndexChanged);
            // 
            // PoleReg_PlotView
            // 
            this.PoleReg_PlotView.Location = new System.Drawing.Point(66, 97);
            this.PoleReg_PlotView.Name = "PoleReg_PlotView";
            this.PoleReg_PlotView.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.PoleReg_PlotView.Size = new System.Drawing.Size(915, 451);
            this.PoleReg_PlotView.TabIndex = 2;
            this.PoleReg_PlotView.Text = "plotView1";
            this.PoleReg_PlotView.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.PoleReg_PlotView.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.PoleReg_PlotView.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // Plot_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 610);
            this.Controls.Add(this.PoleReg_PlotView);
            this.Controls.Add(this.PlotBasedOn_comboBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private OxyPlot.WindowsForms.PlotView PoleReg_PlotView;
    }
}