using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HospitalRecordBook.BusinessLayer;
using HospitalRecordBook.Data;

namespace HospitalRecordBook.Specializations
{
    public class DetailsModel : PageModel
    {
        private readonly HospitalRecordBook.Data.PlacementDataContext _context;

        public DetailsModel(HospitalRecordBook.Data.PlacementDataContext context)
        {
            _context = context;
        }

        public Specialization Specialization { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Specialization = await _context.Specializations.FirstOrDefaultAsync(m => m.SpecializationID == id);

            if (Specialization == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
