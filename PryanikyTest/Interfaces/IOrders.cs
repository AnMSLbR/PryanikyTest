using PryanikyTest.Models;

namespace PryanikyTest.Interfaces
{
    public interface IOrders
    {
        List<Product> OrderedProducts { get; set; }
    }
}
