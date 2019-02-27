using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AngularNetStore.Models
{
    public class AplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options)
        : base(options)
        {

        }

        //Creatin Roles for or appLocation
       
        protected override void OnModelCreating(ModelBuilder builder) 
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(
                    new { Id = "1", Name = "Admin", NormalizedName = "ADMIN" },
                    new { Id = "2", Name = "Customer", NormalizedName = "CUSTOMER" },
                    new { Id = "3", Name = "Moderator", NormalizedName = "MODERATOR" }
                );
        }

        public DbSet<ProductModel> Products{get; set;}
       // public DbSet<Persona> Personas { get; set; }
    }
}