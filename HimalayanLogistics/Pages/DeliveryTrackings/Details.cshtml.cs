using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HimalayanLogistics.Data;
using HimalayanLogistics.Models;

namespace HimalayanLogistics.Pages.DeliveryTrackings
{
    public class DetailsModel : PageModel
    {
        private readonly HimalayanLogistics.Data.ApplicationDbContext _context;

        public DetailsModel(HimalayanLogistics.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public DeliveryTracking DeliveryTracking { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.DeliveryTracking == null)
            {
                return NotFound();
            }

            var deliverytracking = await _context.DeliveryTracking.FirstOrDefaultAsync(m => m.DeliveryTrackingId == id);
            if (deliverytracking == null)
            {
                return NotFound();
            }
            else 
            {
                DeliveryTracking = deliverytracking;
            }
            return Page();
        }
    }
}
