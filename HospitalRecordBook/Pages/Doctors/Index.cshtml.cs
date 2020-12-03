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
    public class IndexModel : PageModel
    {
        private readonly HospitalRecordBook.Data.PlacementDataContext _context;

        public IndexModel(HospitalRecordBook.Data.PlacementDataContext context)
        {
            _context = context;
        }

        public IList<Doctor> Doctor { get;set; }

        public async Task OnGetAsync()
        {
            Doctor = await _context.Doctors
                .Include(s => s.Specialization).ToListAsync();
        }
    }
}
