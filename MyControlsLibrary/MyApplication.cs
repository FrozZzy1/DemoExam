using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyControlsLibrary
{
    public class MyApplication
    {
        public int Id { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public string Equipment { get; set; }
        public string Defect { get; set; }
        public string Client { get; set; }
        public string Status { get; set; }
        public string Responsible { get; set; }
        public string ProblemDescription { get; set; }

        public MyApplication(int id, DateTime date, string equipment, string defect, string client, 
            string problemDescription)
        {
            Id = id;
            DateStart = date;
            DateEnd = new DateTime();
            Equipment = equipment;
            Defect = defect;
            Client = client;
            Status = "Not completed";
            Responsible = "";
            ProblemDescription = problemDescription;
        }
    }
}
