using Microsoft.EntityFrameworkCore;
using SocialMediaAPP.Models;

namespace SocialMediaAPP.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options) {
            
        }
        public DbSet<Race> Races { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Address> Addresss { get; set; }    
        public DbSet<AppUser> AppUsers { get; set; }

    }
}
