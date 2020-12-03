using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalRecordBook.BusinessLayer
{
    public class Appointment
    {
        public int AppointmentID { get; set; }

        public string AppointmentTitle { get; set; }

        public string Description { get; set; }

        public int PatientID { get; set; }

        public Patient Patient { get; set; }
    }
}
