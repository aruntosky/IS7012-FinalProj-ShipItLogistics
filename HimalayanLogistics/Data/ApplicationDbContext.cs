using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using HimalayanLogistics.Models;

namespace HimalayanLogistics.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<HimalayanLogistics.Models.Customer> Customer { get; set; }
        public DbSet<HimalayanLogistics.Models.DeliveryTracking> DeliveryTracking { get; set; }
        public DbSet<HimalayanLogistics.Models.Employee> Employee { get; set; }
        public DbSet<HimalayanLogistics.Models.Payment> Payment { get; set; }
        public DbSet<HimalayanLogistics.Models.Shipment> Shipment { get; set; }
    }
}