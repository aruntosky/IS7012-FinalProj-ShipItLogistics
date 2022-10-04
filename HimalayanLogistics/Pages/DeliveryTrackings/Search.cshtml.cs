﻿using System;
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
    public class SearchModel : PageModel
    {
        private readonly HimalayanLogistics.Data.ApplicationDbContext _context;

        public SearchModel(HimalayanLogistics.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<DeliveryTracking> DeliveryTracking { get;set; } = default!;
        public bool SearchCompleted { get; set; }
        public string Query { get; set; }
        public async Task OnGetAsync(string query)
        {
            Query = query;
            if (!string.IsNullOrWhiteSpace(query))
            {
                SearchCompleted = true;
                DeliveryTracking = await _context.DeliveryTracking
                                   .Where(x => x.TrackingNumber.StartsWith(query))
                                   .Include(d => d.Shipment)
                                   .ToListAsync();
            }
            else
            {
                SearchCompleted = false;
                DeliveryTracking = new List<DeliveryTracking>();
            }
        }
    }
}
