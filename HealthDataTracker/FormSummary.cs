using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace HealthDataTracker
{
    public partial class FormSummary : Form
    {
        public FormSummary()
        {
            InitializeComponent();
        }

        private void FormSummary_Load(object sender, EventArgs e)
        {
            //reading in the data from the health database (Excel file)
            String fileName = "HealthData.csv";
            var records = new List<HealthRecord>();
            using (var reader = new StreamReader(fileName))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                //order records by date from oldest to newest
                records = (List<HealthRecord>)csv.GetRecords<HealthRecord>().ToList();
                var orderRecords = from r in records
                                    orderby r.date
                                    select r;

                //set x value as the date
                string[] x = (from r in orderRecords.AsEnumerable()
                              orderby Convert.ToDateTime(r.date) ascending
                              select r.date).ToArray();

                //set y value as either systolic pressure, diastolic pressure, or blood sugar depending on the chart, and match date with the health data
                int[] y = (from r in orderRecords.AsEnumerable()
                           orderby Convert.ToDateTime(r.date) ascending
                           select r.systolicBloodPressure).ToArray();

                int[] y2 = (from r in orderRecords.AsEnumerable()
                           orderby Convert.ToDateTime(r.date) ascending
                           select r.diastolicBloodPressure).ToArray();

                int[] y3 = (from r in orderRecords.AsEnumerable()
                           orderby Convert.ToDateTime(r.date) ascending
                           select r.bloodSugar).ToArray();

                //setting the properties of the chart
                chartDataSystolicPressure.Series[0].LegendText = "Systolic Pressure";
                chartDataSystolicPressure.Series[0].ChartType = SeriesChartType.Line;
                chartDataSystolicPressure.Series[0].IsValueShownAsLabel = true;
                chartDataSystolicPressure.Series[0].Points.DataBindXY(x, y);

                chartDataDiastolicPressure.Series[0].LegendText = "Diastolic Pressure";
                chartDataDiastolicPressure.Series[0].ChartType = SeriesChartType.Line;
                chartDataDiastolicPressure.Series[0].IsValueShownAsLabel = true;
                chartDataDiastolicPressure.Series[0].Points.DataBindXY(x, y2);

                chartDataSugar.Series[0].LegendText = "Blood Sugar";
                chartDataSugar.Series[0].ChartType = SeriesChartType.Line;
                chartDataSugar.Series[0].IsValueShownAsLabel = true;
                chartDataSugar.Series[0].Points.DataBindXY(x, y3);

                int systolicBloodPressure = y[x.Length-1];
                int diastolicBloodPressure = y2[x.Length-1];
                int bloodSugar = y3[x.Length-1];

                //StringBuilder used because the user's health data may change dynamically, so we need to give out the recommendations accordingly depending on how the health data compares to the standard values
                //We give different subrecommendations based on the user's daily health values and then combine the subrecommendations into a summary recommendation
                StringBuilder sb = new StringBuilder();

                //this condition recommended when user has low systollic blood pressure or low diastolic blood blood pressure
                if (systolicBloodPressure <= 100 || diastolicBloodPressure <= 60)
                {
                    sb.AppendLine("Your blood pressure today is low.");
                    sb.AppendLine("The system recommends drinking plenty of water and eating more salt. If you exercise, you should avoid activities that involve bending and rising quickly into a standing position.");
                }
                //this condition recommended when user has high systolic blood pressure or high diastolic blood pressure
                else if (systolicBloodPressure >= 120 || diastolicBloodPressure >= 80)
                {
                    sb.AppendLine("Your blood pressure today is high.");
                    sb.AppendLine("The system recommends increasing physical activity and decreasing the salt in your diet. You should also opt for a heart-healthy diet that includes more vegetables and fruits, whole grains, and low-fat protein sources.");
                }
                //this condition recommended when user's blood pressure values do not meet the criteria above and is deemed optimal
                else
                {
                    sb.AppendLine("Your blood pressure today is optimal.");
                    sb.AppendLine("The system recommends that you exercise regularly for at least 30 minutes a day. Additionally, you should cut back on caffeine and eat a healthy diet of fruits and vegetables.");
                }

                sb.AppendLine("  ");

                //this condition recommended when user has low blood sugar
                if (bloodSugar <= 70)
                {
                    sb.AppendLine("Your blood sugar today is low.");
                    sb.AppendLine("The system recommends avoiding working out, or only exercising for very short periods of time. Additionally, you should eat more fruit and aim to eat carbohydrate - heavy foods such as whole wheat crackers.");
                }
                //this condition recommended when user has high blood sugar
                else if (bloodSugar >= 100)
                {
                    sb.AppendLine("Your blood sugar today is high.");
                    sb.AppendLine("The system recommends at least 30 minutes of exercise a day.You should also add more vegetables to your diet and eat higher - fiber foods.");
                }
                //this condition recommended when user's blood sugar values do not meet the criteria above and are deemed optimal
                else
                {
                    sb.AppendLine("Your blood sugar today is optimal.");
                    sb.AppendLine("The system recommends eating every 3 to 4 hours during the day.You should also avoid sugar sweetened beverages and focus on eating whole grains.");
                }

                textBoxAdvice.Text = sb.ToString();

                this.Update();
           }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
