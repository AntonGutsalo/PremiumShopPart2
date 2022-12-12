using Microsoft.EntityFrameworkCore;
using Shop_Test.Infrastructure;
using Shop_Test.Models;
namespace Shop_Test.Infrastructure
{
    public class SeedData
    {
        public static void SeedDatabase(DataContext context)
        {
            //context.Database.Migrate();

            if (!context.Products.Any())
            {
                Category shoes = new Category { Name = "Shoes", Slug = "shoes" };
                Category hoodie = new Category { Name = "Hoodie", Slug = "hoodie" };

                context.Products.AddRange(
                        new Product
                        {
                            Name = "AirForceWhite",
                            Slug = "AirForceWhite",
                            Description = "white",
                            Price = 150M,
                            Category = shoes,
                            Image = "AirForceWhite.jpg"
                        },
                        new Product
                        {
                            Name = "AirForceGray",
                            Slug = "AirForceGray",
                            Description = "grey",
                            Price = 150M,
                            Category = shoes,
                            Image = "AirForceGray.jpg"
                        },
                        new Product
                        {
                            Name = "AirForceBlack",
                            Slug = "AirForceBlack",
                            Description = "black",
                            Price = 150M,
                            Category = shoes,
                            Image = "AirForceBlack.jpg"
                        },
                        new Product
                        {
                            Name = "AirForceRed",
                            Slug = "AirForceRed",
                            Description = "red",
                            Price = 150M,
                            Category = shoes,
                            Image = "AirForceRed.jpg"
                        },
                        new Product
                        {
                            Name = "TNFWhite",
                            Slug = "TNFWhite",
                            Description = "white",
                            Price = 5.99M,
                            Category = hoodie,
                            Image = "TNFWhite.jpg"
                        },
                        new Product
                        {
                            Name = "TNFGray",
                            Slug = "TNFGray",
                            Description = "gray",
                            Price = 5.99M,
                            Category = hoodie,
                            Image = "TNFGray.jpg"
                        },
                        new Product
                        {
                            Name = "TNFBlack",
                            Slug = "TNFBlack",
                            Description = "black",
                            Price = 5.99M,
                            Category = hoodie,
                            Image = "TNFBlack.jpg"
                        },
                        new Product
                        {
                            Name = "TNFRed",
                            Slug = "TNFRed",
                            Description = "red",
                            Price = 5.99M,
                            Category = hoodie,
                            Image = "TNFRed.jpg"
                        }
                );

                context.SaveChanges();
            }
        }
    }
}