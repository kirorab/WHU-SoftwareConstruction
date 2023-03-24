namespace orderFormsMananger
{
    public class Product
    {
        public int price { get; set; }
        public string productName { get; set; }
        public Product(int price, string productName)
        {
            this.price = price;
            this.productName = productName;
        }
    }
}