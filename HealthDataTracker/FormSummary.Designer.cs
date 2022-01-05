namespace HealthDataTracker
{
    partial class FormSummary
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartDataSystolicPressure = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartDataSugar = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxAdvice = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.chartDataDiastolicPressure = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartDataSystolicPressure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDataSugar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDataDiastolicPressure)).BeginInit();
            this.SuspendLayout();
            // 
            // chartDataSystolicPressure
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDataSystolicPressure.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDataSystolicPressure.Legends.Add(legend1);
            this.chartDataSystolicPressure.Location = new System.Drawing.Point(21, 19);
            this.chartDataSystolicPressure.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartDataSystolicPressure.Name = "chartDataSystolicPressure";
            this.chartDataSystolicPressure.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartDataSystolicPressure.Series.Add(series1);
            this.chartDataSystolicPressure.Size = new System.Drawing.Size(601, 112);
            this.chartDataSystolicPressure.TabIndex = 0;
            // 
            // chartDataSugar
            // 
            chartArea2.Name = "ChartArea1";
            this.chartDataSugar.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartDataSugar.Legends.Add(legend2);
            this.chartDataSugar.Location = new System.Drawing.Point(21, 262);
            this.chartDataSugar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartDataSugar.Name = "chartDataSugar";
            this.chartDataSugar.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartDataSugar.Series.Add(series2);
            this.chartDataSugar.Size = new System.Drawing.Size(601, 112);
            this.chartDataSugar.TabIndex = 1;
            // 
            // textBoxAdvice
            // 
            this.textBoxAdvice.Location = new System.Drawing.Point(21, 389);
            this.textBoxAdvice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxAdvice.Multiline = true;
            this.textBoxAdvice.Name = "textBoxAdvice";
            this.textBoxAdvice.ReadOnly = true;
            this.textBoxAdvice.Size = new System.Drawing.Size(602, 99);
            this.textBoxAdvice.TabIndex = 2;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(21, 502);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(72, 28);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // chartDataDiastolicPressure
            // 
            chartArea3.Name = "ChartArea1";
            this.chartDataDiastolicPressure.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartDataDiastolicPressure.Legends.Add(legend3);
            this.chartDataDiastolicPressure.Location = new System.Drawing.Point(21, 141);
            this.chartDataDiastolicPressure.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartDataDiastolicPressure.Name = "chartDataDiastolicPressure";
            this.chartDataDiastolicPressure.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartDataDiastolicPressure.Series.Add(series3);
            this.chartDataDiastolicPressure.Size = new System.Drawing.Size(601, 112);
            this.chartDataDiastolicPressure.TabIndex = 4;
            // 
            // FormSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 540);
            this.Controls.Add(this.chartDataDiastolicPressure);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.textBoxAdvice);
            this.Controls.Add(this.chartDataSugar);
            this.Controls.Add(this.chartDataSystolicPressure);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FormSummary";
            this.Text = "Health Data Trend";
            this.Load += new System.EventHandler(this.FormSummary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartDataSystolicPressure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDataSugar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDataDiastolicPressure)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartDataSystolicPressure;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDataSugar;
        private System.Windows.Forms.TextBox textBoxAdvice;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDataDiastolicPressure;
    }
}