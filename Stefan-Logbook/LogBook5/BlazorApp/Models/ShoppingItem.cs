using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Models
{
    public class ShoppingItem
    {
        public int Id { get; set; }

        public Product Product { get; set; }

        [Range(1, 10)]
        public int Quantity { get; set; } = 1;

        [Range(1.00, 2000.00)]
        public double PurchasePrice { get; set; } = 0.00;
    }
}