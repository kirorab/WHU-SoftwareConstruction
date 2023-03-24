using System;

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
        
        /* 接受一个Customer对象，一个Product对象，一个数量，用product和quantity
            创建一个OrderDetails对象，将传入的Customer作为所创建Order的customer，
            创建的OrderDetails作为该Order的第一个Detail */
        public static Order CreateOrder(Customer customer, Product product, int quantity)
        {
            if (customer == null)
            {
                throw new ArgumentNullException(nameof(customer), "Customer cannot be null.");
            }
            var firstDetails = CreateOrderDetails(product, quantity);
            Order order = new Order();
            order.Customer = customer;
            order.AddOrderDetails(firstDetails);
            return order;
        }
    }
}