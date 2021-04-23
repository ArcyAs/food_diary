using System;
using System.Collections.Generic;
using System.Text;
using FoodDiary.Entities;
using FoodDiary.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

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