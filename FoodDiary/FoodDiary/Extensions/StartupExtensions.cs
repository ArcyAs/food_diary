using System.Reflection;
using System.Threading.Tasks;
using FoodDiary.Data;
using FoodDiary.MapperProfiles;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FoodDiary.Extensions
{
    public static class StartupExtensions
    {
        public static IApplicationBuilder CreateDatabase(this IApplicationBuilder app)
        {
            using var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>()?.CreateScope();
            var context = serviceScope?.ServiceProvider.GetRequiredService<ApplicationDbContext>();
            context?.Database.Migrate();

            return app;
        }

        public static IServiceCollection ConfigureDependencies(this IServiceCollection services)
        {
            services.AddMediatR(typeof(Startup));
            services.AddAutoMapper(Assembly.GetAssembly(typeof(IdentityUsersMapperProfile)));

            return services;
        }

        public static IServiceCollection ConfigureDatabaseContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlite(
                    configuration.GetConnectionString("DefaultConnection")));
            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>();

            return services;
        }

        public static void SeedData(this IApplicationBuilder app)
        {
            SeedDefaultUsers(app);
        }
        
        private static void SeedDefaultUsers(IApplicationBuilder app)
        {
            using var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>()?.CreateScope();
            var roleManager = serviceScope?.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = serviceScope?.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();
            Task<IdentityResult> roleResult;
            const string email = "user@user.com";

            var hasAdminRole = roleManager.RoleExistsAsync("User").Result;

            if (!hasAdminRole)
            {
                roleResult = roleManager.CreateAsync(new IdentityRole("User"));
                roleResult.Wait();
            }

            var testUser = userManager.FindByEmailAsync(email).Result;

            if (testUser != null) return;
            var administrator = new IdentityUser {Email = email, UserName = email, EmailConfirmed = true};

            var newUser = userManager.CreateAsync(administrator, "zaq1@WSX");
            newUser.Wait();

            if (!newUser.Result.Succeeded) return;
            var newUserRole = userManager.AddToRoleAsync(administrator, "User");
            newUserRole.Wait();
        }
    }
}