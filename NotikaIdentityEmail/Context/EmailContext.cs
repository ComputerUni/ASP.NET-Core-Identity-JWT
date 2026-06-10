using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace NotikaIdentityEmail.Context
{
    public class EmailContext : IdentityDbContext<AppUser>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-213H3J8\\SQLEXPRESS;Initial Catalog=EmailNotikaDb;Integrated Security=True;TrustServerCertificate=True;");
        }
    }
}
