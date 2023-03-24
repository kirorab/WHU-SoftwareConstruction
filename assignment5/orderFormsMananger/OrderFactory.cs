namespace orderFormsMananger
{
    public class OrderFactory
    {
        private static Customer CreateCustomer(string name)
        {
            Customer customer = new Customer();
            customer.Name = name;
            return customer;
        }
        
        private static OrderDetails CreateOrderDetails(int price, string productName, string customerName)
        {
            Customer customer = CreateCustomer(customerName);
            return new OrderDetails(price, productName, customer);
        }
        
        
        public static Order CreateOrder()
        {
            return new Order();
        }
    }
}