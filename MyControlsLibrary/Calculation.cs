using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyControlsLibrary
{
    public class Calculation
    {
        public List<MyApplication> Applications { get; set; }
        public double AverageTime { get; set; }

        public Calculation(List<MyApplication> applications)
        {
            Applications = applications;
            AverageTime = 0;
        }

        public double GetAverageTime()
        {
            if (Applications.Count == 0) return 0;
            TimeSpan sum = new TimeSpan();
            foreach (var app in Applications)
            {
                if(app.DateEnd != DateTime.MinValue && app.Status == "Completed")
                {
                    sum += app.DateEnd.Subtract(app.DateStart);
                }
            }
            AverageTime = sum.TotalDays / Applications.Count;
            return AverageTime;
        }
        public int GetApplicationsCount()
        {
            return Applications.Count;
        }
        public string GetDefectsStatistics()
        {
            if (Applications.Count == 0)
                return null;
            string result = "";
            int i, maxI = 0;
            foreach (var app in Applications)
            {
                i = 0;
                foreach (var app2 in Applications)
                {
                    if (app2.Defect == app.Defect) i++;
                }
                if(i > maxI)
                {
                    maxI = i;
                    result = app.Defect;
                }
            }
            return result;
        }
    }
}
