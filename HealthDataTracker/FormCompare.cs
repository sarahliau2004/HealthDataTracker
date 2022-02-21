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
    public partial class FormCompare : Form
    {
        public FormCompare()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            var date1 = textBoxEnterDate1.Text;
            var date2 = textBoxEnterDate2.Text;

            String fileName = "HealthData.csv";
            var records = new List<HealthRecord>();
            using (var reader = new StreamReader(fileName))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                records = (List<HealthRecord>)csv.GetRecords<HealthRecord>().ToList();
            }

            var isSameDate1 = false;
            var isSameDate2 = false;
            int sbp1 = 0;
            int sbp2 = 0;
            int dbp1 = 0;
            int dbp2 = 0;
            int bs1 = 0;
            int bs2 = 0;

            //this loop iterates through each health record in the database to find health data associated with the two dates
            foreach (var r in records)
            {
                if (Convert.ToDateTime(r.date) == Convert.ToDateTime(date1))
                {
                    //if date is found, set the flag and collect health data for that date
                    isSameDate1 = true;
                    sbp1 = r.systolicBloodPressure;
                    dbp1 = r.diastolicBloodPressure;
                    bs1 = r.bloodSugar;
                }
                else if (Convert.ToDateTime(r.date) == Convert.ToDateTime(date2))
                {
                    isSameDate2 = true;
                    sbp2 = r.systolicBloodPressure;
                    dbp2 = r.diastolicBloodPressure;
                    bs2 = r.bloodSugar;
                }
            }

            if (!isSameDate1)
            {
                //if there is no data associated with the date the user entered, notify user of this 
                string message = "There is no recorded data on " + date1 + ".";
                string title = "No Data Found";
                MessageBox.Show(message, title);
            }
            else if (!isSameDate2)
            {
                string message = "There is no recorded data on " + date2 + ".";
                string title = "No Data Found";
                MessageBox.Show(message, title);
            }
            else if (isSameDate1 && isSameDate2)
            {
                //if data found for both dates, compute the difference in blood presusre and sugar
                textBoxSystolicBloodPressureChange.Text = (sbp2 - sbp1).ToString();
                textBoxDiastolicBloodPressureChange.Text = (dbp2 - dbp1).ToString();
                textBoxSugarChange.Text = (bs2 - bs1).ToString();
            }

            this.Update();
        }
    }
}
