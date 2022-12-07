using BlazorApp.Models;
using System.Collections.Immutable;

namespace BlazorApp.Services
{
    public class ProductService
    {
        public static readonly List<Product> Products = new List<Product>()
        {
            new()
            {
                Id = 1,
                Name = "Iphone 14 Pro Max",
                Description = "The iPhone 14 Pro Max display has rounded corners that follow a beautiful curved design, and these corners are within a standard rectangle. ",
                Price =  1199.00
            },
            new()
            {
                Id = 2,
                Name = "Huawei Mate X3",
                Description = "The Huawei Mate X3 consists of 6 GB and 8 GB RAM with 128 GB internal storage. ",
                Price = 1090.00
            },
            new()
            {
                Id = 3,
                Name = "Samsung S22 Ultra",
                Description = "The Samsung Galaxy S22 Ultra is the headliner of the S22 series. It's the first S series phone to include Samsung's S Pen.",
                Price = 916.00
            },
        };
    }
}
