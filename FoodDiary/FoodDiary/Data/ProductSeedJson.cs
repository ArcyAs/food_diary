namespace FoodDiary.Data
{
    internal class ProductSeedJson
    {
        public string GetProductsJson()
        {
            return @"[
    {
        ""id"": ""coles-muslie-almond"",
        ""name"": ""Muesli (Almond)"",
        ""nutrition-per-100g"": {
            ""energy"": 1560,
            ""protein"": 12.3,
            ""fat"": 9.9,
            ""saturated-fat"": 2.8,
            ""carbohydrate"": 51.7,
            ""sugars"": 19.7,
            ""dietary-fibre"": 13,
            ""sodium"": 6
        },
        ""tags"": [""grain"", ""carb""]
    },
    {
        ""id"": ""coles-rolled-oats-wholegrain"",
        ""name"": ""Wholegrain Rolled Oats"",
        ""nutrition-per-100g"": {
            ""energy"": 1680,
            ""protein"": 13.3,
            ""fat"": 9.8,
            ""saturated-fat"": 1.7,
            ""carbohydrate"": 60.3,
            ""sugars"": 1.2,
            ""dietary-fibre"": 0.0086,
            ""sodium"": 7,
            ""potassium"": 313
        },
        ""tags"": [""grain"", ""carb""]
    },
    {
        ""id"": ""sanitarium-almond-milk"",
        ""name"": ""Almond Milk"",
        ""nutrition-per-100ml"": {
            ""energy"": 130,
            ""protein"": 0.5,
            ""fat"": 1.2,
            ""saturated-fat"": 0.1,
            ""trans-fat"": 0,
            ""polyunsaturated-fat"": 0.3,
            ""monounsaturated-fat"": 0.8,
            ""carbohydrate"": 4.6,
            ""sugars"": 4.4,
            ""dietary-fibre"": 0.3,
            ""sodium"": 35,
            ""potassium"": 15,
            ""calcium"": 75,
            ""vitamin-e"": 0.4
        },
        ""tags"": [""snack""]
    },
    {
        ""id"": ""coles-soy-milk-regular"",
        ""name"": ""Soy Milk"",
        ""nutrition-per-100ml"": {
            ""energy"": 244,
            ""protein"": 3.1,
            ""fat"": 3.0,
            ""saturated-fat"": 0.2,
            ""trans-fat"": 0.2,
            ""polyunsaturated-fat"": 1,
            ""monounsaturated-fat"": 1.8,
            ""carbohydrate"": 4.7,
            ""sugars"": 1.6,
            ""dietary-fibre"": 0,
            ""sodium"": 47
        },
        ""contains"": [
            ""canola-oil"",
            ""maltodextrin""
        ]
    },
    {
        ""id"": ""simply-better-organic-tofu-plain-firm"",
        ""name"": ""Firm Tofu"",
        ""nutrition-per-100g"": {
            ""energy"": 615,
            ""protein"": 15.9,
            ""fat"": 8.8,
            ""saturated-fat"": 2.7,
            ""trans-fat"": 0.1,
            ""polyunsaturated-fat"": 6.9,
            ""monounsaturated-fat"": 3.0,
            ""carbohydrate"": 0.3,
            ""sugars"": 0.3,
            ""sodium"": 17
        }
    },
    {
        ""id"": ""sss-hummus-dip"",
        ""name"": ""Hummus"",
        ""nutrition-per-100g"": {
            ""energy"": 709,
            ""protein"": 8.4,
            ""fat"": 10.8,
            ""saturated-fat"": 1.8,
            ""dietary-fibre"": 11,
            ""carbohydrate"": 4.6,
            ""sugars"": 0.6,
            ""sodium"": 378
        },
        ""tags"": [""legume"", ""snack""]
    },
    {
        ""id"": ""coles-hummus-lite"",
        ""name"": ""Hummus (Lite)"",
        ""nutrition-per-100g"": {
            ""energy"": 696,
            ""protein"": 5.0,
            ""fat"": 9.3,
            ""saturated-fat"": 1.0,
            ""carbohydrate"": 15.7,
            ""sugars"": 0.6,
            ""sodium"": 354
        },
        ""tags"": [""legume"", ""snack""]
    },
    {
        ""id"": ""coles-hummus"",
        ""name"": ""Hummus"",
        ""nutrition-per-100g"": {
            ""energy"": 1091,
            ""protein"": 5.6,
            ""fat"": 19.2,
            ""saturated-fat"": 2,
            ""carbohydrate"": 16.8,
            ""sugars"": 0.6,
            ""sodium"": 347
        },
        ""tags"": [""legume"", ""snack""]
    },
    {
        ""id"": ""sanitarium-natural-peanut-butter-crunchy"",
        ""name"": ""Peanut Butter"",
        ""nutrition-per-100g"": {
            ""energy"": 2580,
            ""protein"": 28,
            ""fat"": 50,
            ""saturated-fat"": 6,
            ""trans-fat"": 0,
            ""polyunsaturated-fat"": 5,
            ""monounsaturated-fat"": 39,
            ""carbohydrate"": 12,
            ""sugars"": 5.0,
            ""dietary-fibre"": 6,
            ""sodium"": 8,
            ""potassium"": 700,
            ""vitamin-b3"": 12,
            ""magnesium"": 150
        },
        ""tags"": [""snack"", ""nut""]
    },
    {
        ""id"": ""macro-organic-peanut-butter-crunchy"",
        ""name"": ""Peanut Butter"",
        ""nutrition-per-100g"": {
            ""energy"": 2670,
            ""protein"": 28.4,
            ""fat"": 50.9,
            ""saturated-fat"": 10.2,
            ""trans-fat"": 0.1,
            ""polyunsaturated-fat"": 15.9,
            ""monounsaturated-fat"": 22.7,
            ""carbohydrate"": 18,
            ""sugars"": 5.5,
            ""sodium"": 1
        },
        ""tags"": [""snack"", ""nut""]
    },
    {
        ""id"": ""macro-organic-tahini-unhulled"",
        ""name"": ""Tahini"",
        ""nutrition-per-100g"": {
            ""energy"": 2760,
            ""protein"": 25.6,
            ""fat"": 57.3,
            ""saturated-fat"": 8.3,
            ""trans-fat"": 0.1,
            ""polyunsaturated-fat"": 23.8,
            ""monounsaturated-fat"": 22.9,
            ""carbohydrate"": 12,
            ""sugars"": 1,
            ""sodium"": 7
        },
        ""tags"": [""seed""]
    },
    {
        ""id"": ""coles-butter-beans-organic"",
        ""name"": ""Butter Beans"",
        ""nutrition-per-100g"": {
            ""energy"": 384,
            ""protein"": 7.4,
            ""fat"": 0.9,
            ""saturated-fat"": 0.9,
            ""carbohydrate"": 15.2,
            ""sugars"": 0.9,
            ""dietary-fibre"": 7,
            ""sodium"": 300
        },
        ""tags"": [""legume""]
    },
    {
        ""id"": ""coles-red-kidney-beans-organic"",
        ""name"": ""Kidney Beans"",
        ""nutrition-per-100g"": {
            ""energy"": 370,
            ""protein"": 5.2,
            ""fat"": 0.4,
            ""saturated-fat"": 0.3,
            ""carbohydrate"": 16.1,
            ""sugars"": 0.7,
            ""dietary-fibre"": 7.3,
            ""sodium"": 268
        },
        ""tags"": [""legume""]
    },
    {
        ""id"": ""coles-chick-peas-organic"",
        ""name"": ""Chickpeas"",
        ""nutrition-per-100g"": {
            ""energy"": 391,
            ""protein"": 8,
            ""fat"": 0.5,
            ""saturated-fat"": 0.5,
            ""carbohydrate"": 15,
            ""sugars"": 1.2,
            ""dietary-fibre"": 7,
            ""sodium"": 295
        },
        ""tags"": [""legume""]
    },
    {
        ""id"": ""coles-lentils"",
        ""name"": ""Lentils"",
        ""nutrition-per-100g"": {
            ""energy"": 290,
            ""protein"": 4.2,
            ""fat"": 0.9,
            ""saturated-fat"": 0.1,
            ""carbohydrate"": 11.3,
            ""sugars"": 0.9,
            ""dietary-fibre"": 2.8,
            ""sodium"": 293
        },
        ""tags"": [""legume""]
    },
    {
        ""id"": ""edgell-cannellini-beans"",
        ""name"": ""Cannellini Beans"",
        ""nutrition-per-100g"": {
            ""energy"": 438,
            ""protein"": 7.4,
            ""fat"": 0.8,
            ""saturated-fat"": 0.1,
            ""carbohydrate"": 14,
            ""sugars"": 1,
            ""dietary-fibre"": 5.6,
            ""sodium"": 298
        },
        ""tags"": [""legume""]
    },
    {
        ""id"": ""beans"",
        ""name"": ""Beans"",
        ""nutrition-per-100g"": {
            ""energy"": 325,
            ""protein"": 7.4,
            ""fat"": 0.8,
            ""saturated-fat"": 0.1,
            ""carbohydrate"": 14,
            ""sugars"": 1,
            ""dietary-fibre"": 5.6,
            ""sodium"": 298
        },
        ""tags"": [""legume""]
    },
    {
        ""id"": ""fruit-kiwifruit-fresh-raw"",
        ""name"": ""Kiwifruit"",
        ""nutrition-per-100g"": {
            ""energy"": 61,
            ""carbohydrate"": 14.66,
            ""sugars"": 8.99,
            ""dietary-fibre"": 3.0,
            ""fat"": 0.52,
            ""protein"": 1.14
        },
        ""tags"": [""fruit""]
    },
    {
        ""id"": ""fruit-apple-granny-smith-fresh-raw"",
        ""name"": ""Apple (Granny Smith)"",
        ""nutrition-per-100g"": {
            ""energy"": 218,
            ""carbohydrate"": 13.81,
            ""sugars"": 10.39,
            ""dietary-fibre"": 2.4,
            ""fat"": 0.17,
            ""protein"": 0.26,
            ""vitamin-b1"": 0.017,
            ""vitamin-b2"": 0.026,
            ""vitamin-b3"": 0.091,
            ""vitamin-b5"": 0.061,
            ""vitamin-b6"": 0.041,
            ""vitamin-b9"": 0.003,
            ""vitamin-c"": 4.6,
            ""calcium"": 6,
            ""iron"": 0.12,
            ""magnesium"": 5,
            ""phosphorus"": 11,
            ""potassium"": 107,
            ""zinc"": 0.04
        },
        ""tags"": [""fruit""]
    },
    {
        ""id"": ""fruit-apple-pink-lady-fresh-raw"",
        ""name"": ""Apple (Pink Lady)"",
        ""nutrition-per-100g"": {
            ""energy"": 218,
            ""carbohydrate"": 13.81,
            ""sugars"": 10.39,
            ""dietary-fibre"": 2.4,
            ""fat"": 0.17,
            ""protein"": 0.26
        },
        ""tags"": [""fruit""]
    }]";
        }
    }
}