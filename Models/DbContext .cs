using Microsoft.EntityFrameworkCore;
namespace P2Psample1.Models
{
    
    

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ContactForm> ContactForms { get; set; }
    }

}
