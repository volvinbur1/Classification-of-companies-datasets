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
            "(rnd) 2013-7",
            "(rnd) 2013-8",
            "(fastStorage) 2013-8",
            "(rnd) 2013-9"});
            this.TimePeriod_comboBox.Location = new System.Drawing.Point(23, 22);
            this.TimePeriod_comboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TimePeriod_comboBox.Name = "TimePeriod_comboBox";
            this.TimePeriod_comboBox.Size = new System.Drawing.Size(184, 24);
            this.TimePeriod_comboBox.TabIndex = 0;
            this.TimePeriod_comboBox.Text = "Select a time period";
            this.TimePeriod_comboBox.SelectedIndexChanged += new System.EventHandler(this.TimePeriod_comboBox_SelectedIndexChanged);
            // 
            // FileNumber_textBox
            // 
            this.FileNumber_textBox.Location = new System.Drawing.Point(23, 97);
            this.FileNumber_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FileNumber_textBox.Name = "FileNumber_textBox";
            this.FileNumber_textBox.Size = new System.Drawing.Size(184, 22);
            this.FileNumber_textBox.TabIndex = 1;
            // 
            // Analyze_button
            // 
            this.Analyze_button.Location = new System.Drawing.Point(65, 137);
            this.Analyze_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Analyze_button.Name = "Analyze_button";
            this.Analyze_button.Size = new System.Drawing.Size(100, 28);
            this.Analyze_button.TabIndex = 2;
            this.Analyze_button.Text = "Analyze";
            this.Analyze_button.UseVisualStyleBackColor = true;
            this.Analyze_button.Click += new System.EventHandler(this.Analyze_button_Click);
            // 
            // AvalibleFileQuantity_label
            // 
            this.AvalibleFileQuantity_label.AutoSize = true;
            this.AvalibleFileQuantity_label.Location = new System.Drawing.Point(21, 58);
            this.AvalibleFileQuantity_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AvalibleFileQuantity_label.Name = "AvalibleFileQuantity_label";
            this.AvalibleFileQuantity_label.Size = new System.Drawing.Size(160, 17);
            this.AvalibleFileQuantity_label.TabIndex = 3;
            this.AvalibleFileQuantity_label.Text = "Enter document number";
            this.AvalibleFileQuantity_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DataSelection_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 192);
            this.Controls.Add(this.AvalibleFileQuantity_label);
            this.Controls.Add(this.Analyze_button);
            this.Controls.Add(this.FileNumber_textBox);
            this.Controls.Add(this.TimePeriod_comboBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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

