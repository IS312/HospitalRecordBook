using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HospitalRecordBook.BusinessLayer;
using HospitalRecordBook.Data;

namespace HospitalRecordBook.Doctors
{
    public class DetailsModel : PageModel
    {
        private readonly HospitalRecordBook.Data.PlacementDataContext _context;

        public DetailsModel(HospitalRecordBook.Data.PlacementDataContext context)
        {
            _context = context;
        }

        public Doctor Doctor { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Doctor = await _context.Doctors
                .Include(s => s.Specialization).FirstOrDefaultAsync(m => m.DoctorID == id);

            if (Doctor == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
