using FoodDiary.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Repositories.Entities;

namespace FoodDiary.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public DbSet<UserDetailsEntity> UserDetailsEntities { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}