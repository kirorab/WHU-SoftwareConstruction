﻿using System.Collections.Generic;

namespace orderFormsMananger
{
    public class Order
    {
        private HashSet<OrderDetails> Details;
        public int OrderId { get; }
        private static int _orderCount;
        public string TimeStamp { get; set; }
        public Customer Customer { get; set; }

        public Order()
        {
            OrderId = _orderCount;
            _orderCount++;
            TimeStamp = System.DateTime.Now.ToString();
        }

        public void AddOrderDetails(OrderDetails orderDetails)
        {
            Details.Add(orderDetails);
        }

        public void RemoveOrderDetails(OrderDetails orderDetails)
        {
            if (Details.Contains(orderDetails))
            {
                Details.Remove(orderDetails);
            }
        }

        public int GetTotalPrice()
        {
            int totalPrice = 0;
            if (Details.Count != 0)
            {
                foreach (var orderDetails in Details)
                {
                    totalPrice += orderDetails.GetTotalPrice();
                }
            }
            return totalPrice;
        }
        
        public override int GetHashCode()
        {
            return (OrderId + TimeStamp.GetHashCode() + Customer.GetHashCode() + Details.GetHashCode()).GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            Order order = (Order)obj;
            return order.OrderId == this.OrderId;
        }

        public override string ToString()
        {
            return $"Order ID: {OrderId}, TimeStamp: {TimeStamp}, Customer: {Customer}, Details: {Details}";
        }
    }
}