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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.PlotBasedOn_comboBox = new System.Windows.Forms.ComboBox();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.linealGraph_CheckBox = new System.Windows.Forms.CheckBox();
            this.normalizedData_CheckBox = new System.Windows.Forms.CheckBox();
            this.BayesClassifier_checkBox = new System.Windows.Forms.CheckBox();
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
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(14, 40);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(776, 445);
            this.zedGraphControl1.TabIndex = 2;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // linealGraph_CheckBox
            // 
            this.linealGraph_CheckBox.AutoSize = true;
            this.linealGraph_CheckBox.Location = new System.Drawing.Point(232, 12);
            this.linealGraph_CheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.linealGraph_CheckBox.Name = "linealGraph_CheckBox";
            this.linealGraph_CheckBox.Size = new System.Drawing.Size(70, 17);
            this.linealGraph_CheckBox.TabIndex = 3;
            this.linealGraph_CheckBox.Text = "Only dots";
            this.linealGraph_CheckBox.UseVisualStyleBackColor = true;
            this.linealGraph_CheckBox.CheckedChanged += new System.EventHandler(this.linealGraph_CheckBox_CheckedChanged);
            // 
            // normalizedData_CheckBox
            // 
            this.normalizedData_CheckBox.AutoSize = true;
            this.normalizedData_CheckBox.Location = new System.Drawing.Point(310, 12);
            this.normalizedData_CheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.normalizedData_CheckBox.Name = "normalizedData_CheckBox";
            this.normalizedData_CheckBox.Size = new System.Drawing.Size(124, 17);
            this.normalizedData_CheckBox.TabIndex = 4;
            this.normalizedData_CheckBox.Text = "Use normalized Data";
            this.normalizedData_CheckBox.UseVisualStyleBackColor = true;
            this.normalizedData_CheckBox.CheckedChanged += new System.EventHandler(this.normalizedData_CheckBox_CheckedChanged);
            // 
            // BayesClassifier_checkBox
            // 
            this.BayesClassifier_checkBox.AutoSize = true;
            this.BayesClassifier_checkBox.Location = new System.Drawing.Point(439, 12);
            this.BayesClassifier_checkBox.Name = "BayesClassifier_checkBox";
            this.BayesClassifier_checkBox.Size = new System.Drawing.Size(99, 17);
            this.BayesClassifier_checkBox.TabIndex = 5;
            this.BayesClassifier_checkBox.Text = "Bayes Classifier";
            this.BayesClassifier_checkBox.UseVisualStyleBackColor = true;
            this.BayesClassifier_checkBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Plot_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.BayesClassifier_checkBox);
            this.Controls.Add(this.normalizedData_CheckBox);
            this.Controls.Add(this.linealGraph_CheckBox);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.PlotBasedOn_comboBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Plot_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plot";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Plot_Form_FormClosed);
            this.Load += new System.EventHandler(this.Plot_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PlotBasedOn_comboBox;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.CheckBox linealGraph_CheckBox;
        private System.Windows.Forms.CheckBox normalizedData_CheckBox;
        private System.Windows.Forms.CheckBox BayesClassifier_checkBox;
    }
}