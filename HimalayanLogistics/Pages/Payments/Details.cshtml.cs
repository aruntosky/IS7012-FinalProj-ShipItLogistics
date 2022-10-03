using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HimalayanLogistics.Data;
using HimalayanLogistics.Models;

namespace HimalayanLogistics.Pages.Payments
{
    public class DetailsModel : PageModel
    {
        private readonly HimalayanLogistics.Data.ApplicationDbContext _context;

        public DetailsModel(HimalayanLogistics.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public Payment Payment { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Payment == null)
            {
                return NotFound();
            }

            var payment = await _context.Payment.FirstOrDefaultAsync(m => m.PaymentId == id);
            if (payment == null)
            {
                return NotFound();
            }
            else 
            {
                Payment = payment;
            }
            return Page();
        }
    }
}
