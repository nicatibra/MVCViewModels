namespace NVCModels.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Image { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountPrice { get; set; }
        public string Category { get; set; }
        public string Color { get; set; }

        public Product(int id, string image, string name, string description, decimal price, decimal discountprice, string category, string color)
        {
            Id = id;
            Image = image;
            Name = name;
            Description = description;
            Price = price;
            DiscountPrice = discountprice;
            Category = category;
            Color = color;
        }
    }
}
