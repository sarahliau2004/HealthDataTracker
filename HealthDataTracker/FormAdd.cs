using CsvHelper;
using CsvHelper.Configuration;
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
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            HealthRecord healthRecord = new HealthRecord();
            healthRecord.date = DateTime.Today.ToShortDateString();
            healthRecord.systolicBloodPressure = Convert.ToInt32(textBoxSystolicBloodPressure.Text);
            healthRecord.diastolicBloodPressure = Convert.ToInt32(textBoxDiastolicBloodPressure.Text);
            healthRecord.bloodSugar = Convert.ToInt32(textBoxBloodSugar.Text);

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
                if (Convert.ToDateTime(r.date) == Convert.ToDateTime(healthRecord.date))
                {
                    isSameDate = true;
                    r.systolicBloodPressure = healthRecord.systolicBloodPressure;
                    r.diastolicBloodPressure = healthRecord.diastolicBloodPressure;
                    r.bloodSugar = healthRecord.bloodSugar;
                    break;
                }
            }

            if (!isSameDate)
            {
                records.Add(healthRecord);
            }

            using (var writer = new StreamWriter(fileName))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(records);
            }

            Form dlgSummary = new FormSummary();
            dlgSummary.ShowDialog();
        }

        private void buttonImportExcel_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "csv files (*.csv)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    var newRecords = new List<HealthRecord>();
                    using (var reader = new StreamReader(filePath))
                    using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                    {
                        newRecords = (List<HealthRecord>)csv.GetRecords<HealthRecord>().ToList();
                    }

                    String fileName = "HealthData.csv";
                    var records = new List<HealthRecord>();
                    using (var reader = new StreamReader(fileName))
                    using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                    {
                        records = (List<HealthRecord>)csv.GetRecords<HealthRecord>().ToList();
                    }

                    foreach (var nr in newRecords)
                    {
                        var isSameDate = false;
                        foreach (var r in records)
                        {
                            if (Convert.ToDateTime(r.date) == Convert.ToDateTime(nr.date))
                            {
                                isSameDate = true;
                                r.systolicBloodPressure = nr.systolicBloodPressure;
                                r.diastolicBloodPressure = nr.diastolicBloodPressure;
                                r.bloodSugar = nr.bloodSugar;
                                break;
                            }
                        }

                        if (!isSameDate)
                        {
                            records.Add(nr);
                        }
                    }

                    using (var writer = new StreamWriter(fileName))
                    using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                    {
                        csv.WriteRecords(records);
                    }

                    Form dlgSummary = new FormSummary();
                    dlgSummary.ShowDialog();
                }
            }
        }
    }
}
