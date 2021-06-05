using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Ecommerce.Data;
using System;
using System.Linq;

namespace Ecommerce.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new EcommerceDbContext(
                    serviceProvider.GetRequiredService<DbContextOptions<EcommerceDbContext>>()))
            {
                if (context.Products.Any()) return;

                context.Products.AddRange(
                new Product
                {
                    Name = "FT2232",
                    SKU = "11111",
                    Price = 30M,
                    Description = "Gumbo beet greens corn soko endive gumbo gourd.",
                    ImgUrl = "/Assets/qark1.png",
                },

                new Product
                {
                    Name = "A4988",
                    SKU = "22222",
                    Price = 10M,
                    Description = "Parsley shallot courgette tatsoi pea sprouts fava bean collard greens dandelion okra wakame tomato.",
                    ImgUrl = "/Assets/qark2.png",
                },

                new Product
                {
                    Name = "AS988V2",
                    SKU = "33333",
                    Price = 4.20M,
                    Description = "Bunya nuts black-eyed pea prairie turnip leek lentil turnip greens parsnip.",
                    ImgUrl = "/Assets/qark3.png",
                },

                new Product
                {
                    Name = "0EV8525",
                    SKU = "44444",
                    Price = 2.50M,
                    Description = "Dandelion cucumber earthnut pea peanut soko zucchini.",
                    ImgUrl = "/Assets/qark4.png",
                },

                new Product
                {
                    Name = "DRV2522",
                    SKU = "55555",
                    Price = .75M,
                    Description = "Dandelion cucumber earthnut pea peanut soko zucchini.",
                    ImgUrl = "/Assets/qark5.png",
                }

               );

                context.SaveChanges();
            }
        }
    }
}