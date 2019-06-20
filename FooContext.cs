using Microsoft.EntityFrameworkCore;

namespace ef_error
{
    public class FooContext : DbContext
    {
        public FooContext(DbContextOptions<FooContext> options) : base(options)
        {
            
        }
        public DbSet<Foo> Foo { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Foo>();
        }
    }
}