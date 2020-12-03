using HospitalRecordBook.BusinessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalRecordBook.Data
{
    public class PlacementDataContext : DbContext
    {
        public PlacementDataContext(DbContextOptions<PlacementDataContext> options) : base(options)
        {

        } 

        public DbSet<Specialization> Specializations { get; set; }

        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<Patient> Patients { get; set; }

        public DbSet<Appointment> Appointments { get; set; }
    }
}
