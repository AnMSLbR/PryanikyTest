namespace PryanikyTest.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }

        public Product(int id, string code, string name, string category, int price)
        {
            Id = id;
            Code = code;
            Name = name;
            Category = category;
            Price = price;
        }
    }
}
