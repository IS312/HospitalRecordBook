using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HospitalRecordBook.BusinessLayer;
using HospitalRecordBook.Data;

namespace HospitalRecordBook.Appointments
{
    public class DetailsModel : PageModel
    {
        private readonly HospitalRecordBook.Data.PlacementDataContext _context;

        public DetailsModel(HospitalRecordBook.Data.PlacementDataContext context)
        {
            _context = context;
        }

        public Appointment Appointment { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Appointment = await _context.Appointments
                .Include(j => j.Patient).FirstOrDefaultAsync(m => m.AppointmentID == id);

            if (Appointment == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
