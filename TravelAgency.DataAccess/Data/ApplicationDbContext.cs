using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TravelAgency.Models;

namespace TravelAgency.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<GeneralAdmin> GeneralAdmins { get; set; }

        public DbSet<Street> Streets { get; set; }

        //public DbSet<Tourist> Tourists { get; set; }

        //public DbSet<Seller> Sellers { get; set; }

        //public DbSet<Sucursal> Sucursals { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }



    }
}