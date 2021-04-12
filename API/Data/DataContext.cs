using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

// A DbSet represents the collection of all entities in the context, or that can be queried from the database, of a given type. 
// DbSet objects are created from a DbContext using the DbContext.Set method.
// Further explain : https://stackoverflow.com/questions/13627829/about-dbset-and-dbcontext
        public DbSet<AppUser> Users { get; set; }
    }
}