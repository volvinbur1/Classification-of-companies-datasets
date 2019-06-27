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
            this.Plot_zedGraph = new ZedGraph.ZedGraphControl();
            this.OnlyDots_CheckBox = new System.Windows.Forms.CheckBox();
            this.NormalizedData_CheckBox = new System.Windows.Forms.CheckBox();
            this.BayesClassifier_checkBox = new System.Windows.Forms.CheckBox();
            this.ChangeFile_button = new System.Windows.Forms.Button();
            this.PlotDrawing_timer = new System.Windows.Forms.Timer(this.components);
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
            this.PlotBasedOn_comboBox.Size = new System.Drawing.Size(177, 21);
            this.PlotBasedOn_comboBox.TabIndex = 1;
            this.PlotBasedOn_comboBox.Text = "Select";
            this.PlotBasedOn_comboBox.SelectedIndexChanged += new System.EventHandler(this.PlotBasedOn_comboBox_SelectedIndexChanged);
            // 
            // Plot_zedGraph
            // 
            this.Plot_zedGraph.Location = new System.Drawing.Point(14, 40);
            this.Plot_zedGraph.Name = "Plot_zedGraph";
            this.Plot_zedGraph.ScrollGrace = 0D;
            this.Plot_zedGraph.ScrollMaxX = 0D;
            this.Plot_zedGraph.ScrollMaxY = 0D;
            this.Plot_zedGraph.ScrollMaxY2 = 0D;
            this.Plot_zedGraph.ScrollMinX = 0D;
            this.Plot_zedGraph.ScrollMinY = 0D;
            this.Plot_zedGraph.ScrollMinY2 = 0D;
            this.Plot_zedGraph.Size = new System.Drawing.Size(776, 445);
            this.Plot_zedGraph.TabIndex = 2;
            this.Plot_zedGraph.UseExtendedPrintDialog = true;
            // 
            // OnlyDots_CheckBox
            // 
            this.OnlyDots_CheckBox.AutoSize = true;
            this.OnlyDots_CheckBox.Location = new System.Drawing.Point(301, 11);
            this.OnlyDots_CheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.OnlyDots_CheckBox.Name = "OnlyDots_CheckBox";
            this.OnlyDots_CheckBox.Size = new System.Drawing.Size(70, 17);
            this.OnlyDots_CheckBox.TabIndex = 3;
            this.OnlyDots_CheckBox.Text = "Only dots";
            this.OnlyDots_CheckBox.UseVisualStyleBackColor = true;
            this.OnlyDots_CheckBox.CheckedChanged += new System.EventHandler(this.OnlyDots_CheckBox_CheckedChanged);
            // 
            // NormalizedData_CheckBox
            // 
            this.NormalizedData_CheckBox.AutoSize = true;
            this.NormalizedData_CheckBox.Location = new System.Drawing.Point(379, 11);
            this.NormalizedData_CheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.NormalizedData_CheckBox.Name = "NormalizedData_CheckBox";
            this.NormalizedData_CheckBox.Size = new System.Drawing.Size(124, 17);
            this.NormalizedData_CheckBox.TabIndex = 4;
            this.NormalizedData_CheckBox.Text = "Use normalized Data";
            this.NormalizedData_CheckBox.UseVisualStyleBackColor = true;
            this.NormalizedData_CheckBox.CheckedChanged += new System.EventHandler(this.NormalizedData_CheckBox_CheckedChanged);
            // 
            // BayesClassifier_checkBox
            // 
            this.BayesClassifier_checkBox.AutoSize = true;
            this.BayesClassifier_checkBox.Location = new System.Drawing.Point(508, 11);
            this.BayesClassifier_checkBox.Name = "BayesClassifier_checkBox";
            this.BayesClassifier_checkBox.Size = new System.Drawing.Size(99, 17);
            this.BayesClassifier_checkBox.TabIndex = 5;
            this.BayesClassifier_checkBox.Text = "Bayes Classifier";
            this.BayesClassifier_checkBox.UseVisualStyleBackColor = true;
            this.BayesClassifier_checkBox.CheckedChanged += new System.EventHandler(this.BayesClassifier_checkBox_CheckedChanged);
            // 
            // ChangeFile_button
            // 
            this.ChangeFile_button.Location = new System.Drawing.Point(668, 10);
            this.ChangeFile_button.Name = "ChangeFile_button";
            this.ChangeFile_button.Size = new System.Drawing.Size(120, 23);
            this.ChangeFile_button.TabIndex = 6;
            this.ChangeFile_button.Text = "Choose another file";
            this.ChangeFile_button.UseVisualStyleBackColor = true;
            this.ChangeFile_button.Click += new System.EventHandler(this.ChangeFile_button_Click);
            // 
            // PlotDrawing_timer
            // 
            this.PlotDrawing_timer.Enabled = true;
            this.PlotDrawing_timer.Tick += new System.EventHandler(this.PlotDrawing_timer_Tick);
            // 
            // Plot_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.ChangeFile_button);
            this.Controls.Add(this.BayesClassifier_checkBox);
            this.Controls.Add(this.NormalizedData_CheckBox);
            this.Controls.Add(this.OnlyDots_CheckBox);
            this.Controls.Add(this.Plot_zedGraph);
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
        private ZedGraph.ZedGraphControl Plot_zedGraph;
        private System.Windows.Forms.CheckBox OnlyDots_CheckBox;
        private System.Windows.Forms.CheckBox NormalizedData_CheckBox;
        private System.Windows.Forms.CheckBox BayesClassifier_checkBox;
        private System.Windows.Forms.Button ChangeFile_button;
        private System.Windows.Forms.Timer PlotDrawing_timer;
    }
}