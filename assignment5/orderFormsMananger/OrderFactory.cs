namespace orderFormsMananger
{
    public class OrderFactory
    {
        private static Customer CreateCustomer(string name, string location)
        {
            return new Customer(name, location);
        }
        
        private static Product CreateProduct(int price, string productName)
        {
            return new Product(price, productName);
        }

        private static OrderDetails CreateOrderDetails(Product product, int quantity)
        {
            return new OrderDetails(product, quantity);
        }
        
        
        public static Order CreateOrder()
        {
            return new Order();
        }
    }
}