namespace ExtraTask
{
    partial class DataSelection_Form
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
            this.TimePeriod_comboBox = new System.Windows.Forms.ComboBox();
            this.FileNumber_textBox = new System.Windows.Forms.TextBox();
            this.Analyze_button = new System.Windows.Forms.Button();
            this.AvalibleFileQuantity_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TimePeriod_comboBox
            // 
            this.TimePeriod_comboBox.FormattingEnabled = true;
            this.TimePeriod_comboBox.Items.AddRange(new object[] {
            "(rnd) 2013-07",
            "(rnd) 2013-08",
            "(fastStorage) 2013-08",
            "(rnd) 2013-09"});
            this.TimePeriod_comboBox.Location = new System.Drawing.Point(17, 18);
            this.TimePeriod_comboBox.Name = "TimePeriod_comboBox";
            this.TimePeriod_comboBox.Size = new System.Drawing.Size(139, 21);
            this.TimePeriod_comboBox.TabIndex = 0;
            this.TimePeriod_comboBox.Text = "Select a time period";
            this.TimePeriod_comboBox.SelectedIndexChanged += new System.EventHandler(this.TimePeriod_comboBox_SelectedIndexChanged);
            // 
            // FileNumber_textBox
            // 
            this.FileNumber_textBox.Location = new System.Drawing.Point(17, 79);
            this.FileNumber_textBox.Name = "FileNumber_textBox";
            this.FileNumber_textBox.Size = new System.Drawing.Size(139, 20);
            this.FileNumber_textBox.TabIndex = 1;
            // 
            // Analyze_button
            // 
            this.Analyze_button.Location = new System.Drawing.Point(49, 111);
            this.Analyze_button.Name = "Analyze_button";
            this.Analyze_button.Size = new System.Drawing.Size(75, 23);
            this.Analyze_button.TabIndex = 2;
            this.Analyze_button.Text = "Analyze";
            this.Analyze_button.UseVisualStyleBackColor = true;
            this.Analyze_button.Click += new System.EventHandler(this.Analyze_button_Click);
            // 
            // AvalibleFileQuantity_label
            // 
            this.AvalibleFileQuantity_label.AutoSize = true;
            this.AvalibleFileQuantity_label.Location = new System.Drawing.Point(16, 47);
            this.AvalibleFileQuantity_label.Name = "AvalibleFileQuantity_label";
            this.AvalibleFileQuantity_label.Size = new System.Drawing.Size(120, 13);
            this.AvalibleFileQuantity_label.TabIndex = 3;
            this.AvalibleFileQuantity_label.Text = "Enter document number";
            this.AvalibleFileQuantity_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DataSelection_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(176, 156);
            this.Controls.Add(this.AvalibleFileQuantity_label);
            this.Controls.Add(this.Analyze_button);
            this.Controls.Add(this.FileNumber_textBox);
            this.Controls.Add(this.TimePeriod_comboBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DataSelection_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data selection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TimePeriod_comboBox;
        private System.Windows.Forms.TextBox FileNumber_textBox;
        private System.Windows.Forms.Button Analyze_button;
        private System.Windows.Forms.Label AvalibleFileQuantity_label;
    }
}

