using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebEventuresUser.Data.Domain;

namespace WebEventuresUser.Data
{
    public class ApplicationDbContext : IdentityDbContext<EventuresUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            this.Database.EnsureCreated();
        }
    }
}