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
    public class IndexModel : PageModel
    {
        private readonly HimalayanLogistics.Data.ApplicationDbContext _context;

        public IndexModel(HimalayanLogistics.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Shipment> Shipment { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Shipment != null)
            {
                Shipment = await _context.Shipment
                .Include(s => s.Customer)
                .Include(s => s.Employee).ToListAsync();
            }
        }
    }
}
