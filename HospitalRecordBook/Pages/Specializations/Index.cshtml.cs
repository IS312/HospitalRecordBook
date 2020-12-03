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
    public class IndexModel : PageModel
    {
        private readonly HospitalRecordBook.Data.PlacementDataContext _context;

        public IndexModel(HospitalRecordBook.Data.PlacementDataContext context)
        {
            _context = context;
        }

        public IList<Specialization> Specialization { get;set; }

        public async Task OnGetAsync()
        {
            Specialization = await _context.Specializations.ToListAsync();
        }
    }
}
