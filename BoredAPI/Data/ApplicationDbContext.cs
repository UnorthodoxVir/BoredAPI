using BoredAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BoredAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }


        public DbSet<Activity> Activities { get; set; }


    }
}
