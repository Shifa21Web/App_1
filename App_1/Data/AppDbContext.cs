using Microsoft.EntityFrameworkCore;

namespace App_1
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { 

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Currency>().HasData(
                new Currency() { Id=1,Title = "INR",Description = "Indian INR"},
                new Currency() { Id=2,Title = "Dollar",Description = "Dollar" },
                new Currency() { Id=3,Title = "Euro",Description = "Euro" },
                new Currency() { Id=4,Title = "Dinar",Description = "Dinar" }
                );

            modelBuilder.Entity<Language>().HasData(
               new Currency() { Id = 1, Title = "English", Description = "English" },
               new Currency() { Id = 2, Title = "Hindi", Description = "Hindi" },
               new Currency() { Id = 3, Title = "Marathi", Description = "Marathi" },
               new Currency() { Id = 4, Title = "Punjabi", Description = "Punjabi" },
               new Currency() { Id = 5, Title = "Tamil", Description = "Tamil" },
               new Currency() { Id = 6, Title = "Urdu", Description = "Urdu" }
               );
        }


        public DbSet<Book> Book {  get; set; }    
        public DbSet<Language> Language {  get; set; }    
        public DbSet<BookPrice> BookPrice {  get; set; }    
        public DbSet<Currency> Currency {  get; set; }    
    }
}
