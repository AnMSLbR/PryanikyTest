using PryanikyTest.Interfaces;

namespace PryanikyTest.Models
{
    public class Products : IProducts
    {
        public List<Product> List { get; set; }
        public Products()
        {
            List = new List<Product>
            {
                new Product(1, "2424-8874", "Samsung Galaxy S23", "Electronics", 65900),
                new Product(2, "5528-6548", "MSI GF63 Thin 11UD-206XRU", "Electronics", 74990),
                new Product(3, "0122-3254", "Кастрюля Appetite Healthy Food", "Kitchen", 403),
                new Product(4, "3344-2977", "Кровать Морена 140", "Furniture", 4137),
                new Product(5, "3879-3248", "Стул для кухни DSW Style", "Furniture", 1700),
            };
        }
    }
}
