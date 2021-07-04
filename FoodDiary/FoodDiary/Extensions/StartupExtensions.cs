using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using FoodDiary.Builders;
using FoodDiary.Data;
using FoodDiary.Factories;
using FoodDiary.MapperProfiles;
using FoodDiary.Models;
using FoodDiary.Repositories.Abstract;
using FoodDiary.Repositories.Entities;
using FoodDiary.Repositories.Implementations;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

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

            services.AddTransient<IUserNameBuilder, UserNameBuilder>();
            services.AddTransient<IBmiBmrFactory, BmiBmrFactory>();
            services.AddTransient<IRepositoryFactory, RepositoriesFactory>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IProductsRepository, ProductsRepository>();

            return services;
        }

        public static IServiceCollection ConfigureDatabaseContext(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlite(
                    configuration.GetConnectionString("DefaultConnection")));
            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddDefaultIdentity<AppUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>();

            return services;
        }

        public static void SeedData(this IApplicationBuilder app)
        {
            SeedDefaultUsers(app);
            SeedProducts(app);
        }

        private static void SeedProducts(IApplicationBuilder app)
        {
            using var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>()?.CreateScope();
            var context = serviceScope?.ServiceProvider.GetRequiredService<ApplicationDbContext>();

            var productsJson = new ProductSeedJson().GetProductsJson();
            var model = JsonConvert.DeserializeObject<IEnumerable<Root>>(productsJson);

            foreach (var data in model.Where(d => d.NutritionPer100g != null).ToList())
            {
                Debug.Assert(context != null, nameof(context) + " != null");
                var result = context.ProductEntities.Where(x => x.ProductName == data.name);

                if (!result.Any())
                    if (data != null)
                    {
                        Debug.Assert(data.NutritionPer100g != null, "data.NutritionPer100g != null");
                        context?.ProductEntities.Add(new ProductEntity
                        {
                            Id = Guid.NewGuid(),
                            ProductName = data?.name ?? "Wrong entry",
                            Carb = Convert.ToInt32(data?.NutritionPer100g?.carbohydrate ?? 0),
                            Protein = Convert.ToInt32(data?.NutritionPer100g?.protein ?? 0),
                            Fat = Convert.ToInt32(data?.NutritionPer100g?.fat ?? 0),
                            Kcal = KcalCalculator(data.NutritionPer100g.carbohydrate, data.NutritionPer100g.protein,
                                data.NutritionPer100g.fat)
                        });
                    }
            }

            context?.SaveChanges();
        }

        private static void SeedDefaultUsers(IApplicationBuilder app)
        {
            using var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>()?.CreateScope();
            var roleManager = serviceScope?.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = serviceScope?.ServiceProvider.GetRequiredService<UserManager<AppUser>>();
            const string email = "user@user.com";

            Debug.Assert(roleManager != null, nameof(roleManager) + " != null");
            var hasAdminRole = roleManager.RoleExistsAsync("User").Result;

            if (!hasAdminRole)
            {
                var roleResult = roleManager.CreateAsync(new IdentityRole("User"));
                roleResult.Wait();
            }

            var testUser = userManager.FindByEmailAsync(email).Result;

            if (testUser != null) return;
            var administrator = new AppUser {Email = email, UserName = email, EmailConfirmed = true};

            var newUser = userManager.CreateAsync(administrator, "zaq1@WSX");
            newUser.Wait();

            if (!newUser.Result.Succeeded) return;
            var newUserRole = userManager.AddToRoleAsync(administrator, "User");
            newUserRole.Wait();
        }

        private static int KcalCalculator(double carb, double protein, double fat)
        {
            return Convert.ToInt32(carb * 4 + protein * 4 + fat * 9);
        }
    }
}