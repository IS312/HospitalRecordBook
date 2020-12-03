using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalRecordBook.BusinessLayer
{
    public class Patient
    {
        public int PatientID { get; set; }

        public string PatientName { get; set; }

        public string Gender { get; set; }

        public int Phone { get; set; }

        public int Age { get; set; }
    }
}
