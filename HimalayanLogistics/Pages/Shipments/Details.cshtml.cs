using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HimalayanLogistics.Data;
using HimalayanLogistics.Models;

namespace HimalayanLogistics.Pages.Shipments
{
    public class DetailsModel : PageModel
    {
        private readonly HimalayanLogistics.Data.ApplicationDbContext _context;

        public DetailsModel(HimalayanLogistics.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public Shipment Shipment { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Shipment == null)
            {
                return NotFound();
            }

            var shipment = await _context.Shipment
                                                  .Include( x => x.Customer)
                                                  .Include( y => y.Employee)
                                                  .FirstOrDefaultAsync(m => m.ShipmentId == id);
            if (shipment == null)
            {
                return NotFound();
            }
            else 
            {
                Shipment = shipment;
            }
            return Page();
        }
    }
}
