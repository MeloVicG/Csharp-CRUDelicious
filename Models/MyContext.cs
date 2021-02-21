//allows us to mess with DB
using Microsoft.EntityFrameworkCore;

namespace Crudelicious.Models
{ 
    // the MyContext class representing a session with our MySQL 
    // database allowing us to query for or save data
    public class MyContext : DbContext 
    { 
        //in class is constructor
                                                    //arguement options being passed to baseclass
        public MyContext(DbContextOptions options) : base(options) { }
        // the "Monsters" table name will come from the DbSet variable name
        public DbSet<Dish> Dishes { get; set; }
    }
}

