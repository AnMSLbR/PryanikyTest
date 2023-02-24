using PryanikyTest.Interfaces;

namespace PryanikyTest.Models
{
    public class Orders : IOrders
    {
        public List<Product> OrderedProducts { get; set; }
        public Orders()
        {
            OrderedProducts = new List<Product>();
        }
    }
}
