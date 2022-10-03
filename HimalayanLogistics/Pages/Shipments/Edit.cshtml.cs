﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HimalayanLogistics.Data;
using HimalayanLogistics.Models;

namespace HimalayanLogistics.Pages.Shipments
{
    public class EditModel : PageModel
    {
        private readonly HimalayanLogistics.Data.ApplicationDbContext _context;

        public EditModel(HimalayanLogistics.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Shipment Shipment { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Shipment == null)
            {
                return NotFound();
            }

            var shipment =  await _context.Shipment.FirstOrDefaultAsync(m => m.ShipmentId == id);
            if (shipment == null)
            {
                return NotFound();
            }
            Shipment = shipment;
           ViewData["CustomerId"] = new SelectList(_context.Customer, "CustomerId", "CustomerId");
           ViewData["EmployeeId"] = new SelectList(_context.Employee, "EmployeeId", "EmployeeId");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Shipment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ShipmentExists(Shipment.ShipmentId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ShipmentExists(int id)
        {
          return _context.Shipment.Any(e => e.ShipmentId == id);
        }
    }
}
