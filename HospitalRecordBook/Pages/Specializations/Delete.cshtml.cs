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
    public class DeleteModel : PageModel
    {
        private readonly HospitalRecordBook.Data.PlacementDataContext _context;

        public DeleteModel(HospitalRecordBook.Data.PlacementDataContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Specialization = await _context.Specializations.FindAsync(id);

            if (Specialization != null)
            {
                _context.Specializations.Remove(Specialization);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
