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

namespace HealthDataTracker
{
    public partial class FormView : Form
    {
        public FormView()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            var date = textBoxEnterDate.Text;

            String fileName = "HealthData.csv";
            var records = new List<HealthRecord>();
            using (var reader = new StreamReader(fileName))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                records = (List<HealthRecord>)csv.GetRecords<HealthRecord>().ToList();
            }

            var isSameDate = false;
            foreach (var r in records)
            {
                if (Convert.ToDateTime(r.date) == Convert.ToDateTime(date))
                {
                    isSameDate = true;
                    textBoxDate.Text = date;
                    textBoxSystolicBloodPressure.Text = r.systolicBloodPressure.ToString();
                    textBoxDiastolicBloodPressure.Text = r.diastolicBloodPressure.ToString();
                    textBoxBloodSugar.Text = r.bloodSugar.ToString();
                    this.Update();
                    break;
                }
            }

            if (!isSameDate)
            {
                string message = "There is no recorded data on " + date + ".";
                string title = "No Data Found";
                MessageBox.Show(message, title);
            }
        }
    }
}
