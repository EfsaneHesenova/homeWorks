using Hospitaltask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospitaltask.Models
{
    public class Appointment
    {
        private static int _id = 0;
        public int Id { get; set; }
        public string PatientName { get; set; }
        public string DoctorName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public Appointment(string patientName, string doctorName)
        {
            Id = _id;
            _id++;
            EndDate = null;
            StartDate = DateTime.Now;
            PatientName = patientName;
            DoctorName = doctorName;
        }
    }
    
}
 