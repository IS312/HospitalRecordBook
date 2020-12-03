﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using HospitalRecordBook.BusinessLayer;
using HospitalRecordBook.Data;

namespace HospitalRecordBook.Doctors
{
    public class CreateModel : PageModel
    {
        private readonly HospitalRecordBook.Data.PlacementDataContext _context;

        public CreateModel(HospitalRecordBook.Data.PlacementDataContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["SpecializationID"] = new SelectList(_context.Specializations, "SpecializationID", "SpecializationName");
            return Page();
        }

        [BindProperty]
        public Doctor Doctor { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Doctors.Add(Doctor);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
