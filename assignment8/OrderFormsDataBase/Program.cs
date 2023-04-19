using System;
using OrderFormsDataBase.order;

namespace OrderFormsDataBase
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int newOrderId = 0;
            int newCustomerId = 0;
            //add orders
            using (var context = new OrderSeviceContext())
            {
                var order1 = new Order()
                {
                    Id = newOrderId,
                    Customer = new Customer()
                    {
                        Id = newCustomerId,
                        Name = "Customer1"
                    },
                    CreateTime = DateTime.Now
                };
                order1.AddDetails(new OrderDetail()
                {
                    Goods = new Goods()
                    {
                        Name = "apple",
                        Price = 5.5f
                    },
                    Quantity = 10
                });
                context.Orders.Add(order1);
                context.SaveChanges();
                newOrderId++;
                newCustomerId++;
            }
        }
    }
}