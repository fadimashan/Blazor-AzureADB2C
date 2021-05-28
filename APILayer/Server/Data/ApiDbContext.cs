using APILayer.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace APILayer.Server.Data
    {
    public class ApiDbContext : DbContext
    {
        public DbSet<Machine> Machine  { get; set; }
    
        
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
          
        }
    }
}
