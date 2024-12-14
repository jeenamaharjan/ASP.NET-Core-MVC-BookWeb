using Microsoft.EntityFrameworkCore;
using BookWeb.Models;

namespace BookWeb.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { 
        }

        public DbSet<Categoryt> Categoryts {  get; set; }
    }
}
