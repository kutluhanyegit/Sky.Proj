using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Sky.Entities.Concrate;

namespace Sky.DataAccess.Concrate.EntityFramework
{
    public class appDbContext:IdentityDbContext<appUser,appRole,string>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = deneme.db");
        }

        public DbSet<OrderModel> OrderModels { get; set; }
    }
}