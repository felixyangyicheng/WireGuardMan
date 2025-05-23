using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace WireGuardMan.API.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<WireGuardProfile> WireGuardProfiles { get; set; }
    }

    public class WireGuardProfile
    {
        public int Id { get; set; }
        public string PublicKey { get; set; } = "";
        public string ConfigContent { get; set; } = "";

        [ForeignKey("User")]
        public string UserId { get; set; } = "";
        public ApplicationUser User { get; set; } = new();
    }
}
