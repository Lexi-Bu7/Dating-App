using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        //constructor
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        //Dbset<TEntity> properties
        public DbSet<AppUser> Users { get; set; }
    }
}