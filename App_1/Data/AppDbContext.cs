using Microsoft.EntityFrameworkCore;

namespace App_1
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { 

        }
       
    }
}
