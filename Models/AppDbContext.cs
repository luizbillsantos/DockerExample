using Microsoft.EntityFrameworkCore;
using mvc.Models;

namespace mvc.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        { }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Produto> Produtos { get; set; }

    }
}