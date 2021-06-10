using FoodDiary.Models;
using FoodDiary.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using FoodDiary.Repositories.Implementations;

namespace FoodDiary.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public DbSet<UserDetailsEntity> UserDetailsEntities { get; set; }
        public DbSet<ProductEntity> ProductEntities { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
       
      
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //var productsJson = new ProductSeedJson().GetProductsJson();
            var productsJson = new ProductSeedJson().GetProductsJson();
            var model = JsonConvert.DeserializeObject<IEnumerable<Root>>(productsJson);

            foreach (var data in model.Where(d => d.NutritionPer100g != null).ToList())
            {
                builder.Entity<ProductEntity>().HasData(new ProductEntity
                {
                    Id = Guid.NewGuid(),
                    ProductName = data?.name ?? "Wrong entry",
                    Carb = Convert.ToInt32(data?.NutritionPer100g?.carbohydrate ?? 0),
                    Protein = Convert.ToInt32(data?.NutritionPer100g?.protein ?? 0),
                    Fat = Convert.ToInt32(data?.NutritionPer100g?.fat ?? 0),
                    Kcal = KcalCalculator(data.NutritionPer100g.carbohydrate, data.NutritionPer100g.protein, data.NutritionPer100g.fat),

                });

            }


        }

        private int KcalCalculator(double carb, double protein, double fat)
        {
            return Convert.ToInt32(carb * 4 + protein * 4 + fat * 9);
        }

    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class NutritionPer100g
    {
        public double energy { get; set; }
        public double protein { get; set; }
        public double fat { get; set; }

        [JsonProperty("saturated-fat")]
        public double SaturatedFat { get; set; }
        public double carbohydrate { get; set; }
        public double sugars { get; set; }

        [JsonProperty("dietary-fibre")]
        public double DietaryFibre { get; set; }
        public double sodium { get; set; }
        public int? potassium { get; set; }

        [JsonProperty("trans-fat")]
        public double? TransFat { get; set; }

        [JsonProperty("polyunsaturated-fat")]
        public double? PolyunsaturatedFat { get; set; }

        [JsonProperty("monounsaturated-fat")]
        public double? MonounsaturatedFat { get; set; }

        [JsonProperty("vitamin-b3")]
        public double? VitaminB3 { get; set; }
        public int? magnesium { get; set; }

        [JsonProperty("vitamin-b1")]
        public double? VitaminB1 { get; set; }

        [JsonProperty("vitamin-b2")]
        public double? VitaminB2 { get; set; }

        [JsonProperty("vitamin-b5")]
        public double? VitaminB5 { get; set; }

        [JsonProperty("vitamin-b6")]
        public double? VitaminB6 { get; set; }

        [JsonProperty("vitamin-b9")]
        public double? VitaminB9 { get; set; }

        [JsonProperty("vitamin-c")]
        public double? VitaminC { get; set; }
        public int? calcium { get; set; }
        public double? iron { get; set; }
        public int? phosphorus { get; set; }
        public double? zinc { get; set; }
        public double? manganese { get; set; }

        [JsonProperty("vitamin-e")]
        public double? VitaminE { get; set; }

        [JsonProperty("vitamin-k")]
        public double? VitaminK { get; set; }

        [JsonProperty("vitamin-a")]
        public int? VitaminA { get; set; }
        public double? starch { get; set; }

        [JsonProperty("omega-3-fatty-acid")]
        public double? Omega3FattyAcid { get; set; }
    }

    public class NutritionPer100ml
    {
        public int energy { get; set; }
        public double protein { get; set; }
        public double fat { get; set; }

        [JsonProperty("saturated-fat")]
        public double SaturatedFat { get; set; }

        [JsonProperty("trans-fat")]
        public double TransFat { get; set; }

        [JsonProperty("polyunsaturated-fat")]
        public double PolyunsaturatedFat { get; set; }

        [JsonProperty("monounsaturated-fat")]
        public double MonounsaturatedFat { get; set; }
        public double carbohydrate { get; set; }
        public double sugars { get; set; }

        [JsonProperty("dietary-fibre")]
        public double DietaryFibre { get; set; }
        public int sodium { get; set; }
        public int potassium { get; set; }
        public int calcium { get; set; }

        [JsonProperty("vitamin-e")]
        public double VitaminE { get; set; }
    }

    public class Root
    {
        public string id { get; set; }
        public string name { get; set; }

        [JsonProperty("nutrition-per-100g")]
        public NutritionPer100g NutritionPer100g { get; set; }
        public List<string> tags { get; set; }

        [JsonProperty("nutrition-per-100ml")]
        public NutritionPer100ml NutritionPer100ml { get; set; }
        public List<string> contains { get; set; }
    }
}

