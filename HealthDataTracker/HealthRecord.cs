using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthDataTracker
{
    internal class HealthRecord
    {
        //this is the date field, represented in the mm/dd/yyyy format
        public String date { get; set; }
        //this is the systolic blood pressure field, represented as an integer
        public int systolicBloodPressure { get; set; }
        //this is the diastolic blood pressure field, represented as an integer
        public int diastolicBloodPressure { get; set; }
        //this is the blood sugar field, represented as an integer
        public int bloodSugar { get; set; }
    }
}
