using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using HimalayanLogistics.Data;
using HimalayanLogistics.Models;

namespace HimalayanLogistics.Pages.DeliveryTrackings
{
    public class CreateModel : PageModel
    {
        private readonly HimalayanLogistics.Data.ApplicationDbContext _context;

        public CreateModel(HimalayanLogistics.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["ShipmentId"] = new SelectList(_context.Shipment, "ShipmentId", "Destination");
            return Page();
        }

        [BindProperty]
        public DeliveryTracking DeliveryTracking { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.DeliveryTracking.Add(DeliveryTracking);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
