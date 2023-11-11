﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Dedea_Alexandra_Lab2.Data;
using Dedea_Alexandra_Lab2.Models;

namespace Dedea_Alexandra_Lab2.Pages.Borrowings
{
    public class DetailsModel : PageModel
    {
        private readonly Dedea_Alexandra_Lab2.Data.Dedea_Alexandra_Lab2Context _context;

        public DetailsModel(Dedea_Alexandra_Lab2.Data.Dedea_Alexandra_Lab2Context context)
        {
            _context = context;
        }

      public Borrowing Borrowing { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Borrowing = await _context.Borrowing
                .Include(b => b.Member)
                .Include(b => b.Book)
                .FirstOrDefaultAsync(m => m.ID == id);

            if (Borrowing == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}