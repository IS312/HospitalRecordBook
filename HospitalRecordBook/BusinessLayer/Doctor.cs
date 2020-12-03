using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalRecordBook.BusinessLayer
{
    public class Doctor
    {
        public int DoctorID { get; set; }

        public string DoctorName { get; set; }

        public string Gender { get; set; }

        public string Degree { get; set; }

        public int SpecializationID { get; set; }

        public Specialization Specialization { get; set; }

        public float Fee { get; set; }

        
    }
}
