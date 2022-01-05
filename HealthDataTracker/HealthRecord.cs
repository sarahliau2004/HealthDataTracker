using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthDataTracker
{
    internal class HealthRecord
    {
        public String date { get; set; }
        public int systolicBloodPressure { get; set; }
        public int diastolicBloodPressure { get; set; }
        public int bloodSugar { get; set; }
    }
}
