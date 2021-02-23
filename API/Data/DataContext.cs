using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    //the class that acts as a bridge between our code and our database
    public class DataContext : DbContext
    {
        public DataContext (DbContextOptions options ) : base (options)
        {

        }
        //a prop of DbSet, it takes the type of the class that we want to create a database set for
        public DbSet<AppUser> Users { get; set; }
    }
}