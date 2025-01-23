namespace Finansu_programele
{
    partial class MoreCharts
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
            this.closeButton = new System.Windows.Forms.Button();
            this.lineChart = new LiveCharts.WinForms.CartesianChart();
            this.barChart = new LiveCharts.WinForms.CartesianChart();
            this.savingsChart = new LiveCharts.WinForms.CartesianChart();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(557, 581);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 30);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Uždaryti";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // lineChart
            // 
            this.lineChart.Location = new System.Drawing.Point(11, 395);
            this.lineChart.Margin = new System.Windows.Forms.Padding(2);
            this.lineChart.Name = "lineChart";
            this.lineChart.Size = new System.Drawing.Size(1112, 182);
            this.lineChart.TabIndex = 1;
            this.lineChart.Text = "cartesianChart1";
            // 
            // barChart
            // 
            this.barChart.Location = new System.Drawing.Point(11, 32);
            this.barChart.Margin = new System.Windows.Forms.Padding(2);
            this.barChart.Name = "barChart";
            this.barChart.Size = new System.Drawing.Size(593, 339);
            this.barChart.TabIndex = 2;
            this.barChart.Text = "cartesianChart2";
            // 
            // savingsChart
            // 
            this.savingsChart.Location = new System.Drawing.Point(671, 32);
            this.savingsChart.Margin = new System.Windows.Forms.Padding(2);
            this.savingsChart.Name = "savingsChart";
            this.savingsChart.Size = new System.Drawing.Size(452, 339);
            this.savingsChart.TabIndex = 3;
            this.savingsChart.Text = "cartesianChart2";
            // 
            // MoreCharts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 622);
            this.Controls.Add(this.savingsChart);
            this.Controls.Add(this.barChart);
            this.Controls.Add(this.lineChart);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MoreCharts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Finansų programėlė";
            this.Load += new System.EventHandler(this.MoreCharts_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private LiveCharts.WinForms.CartesianChart lineChart;
        private LiveCharts.WinForms.CartesianChart barChart;
        private LiveCharts.WinForms.CartesianChart savingsChart;
    }
}