using System.Collections.Generic;

namespace orderFormsMananger
{
    public class OrderDetails
    {
        private List<Product> Products;
        public Customer Customer { get; set; }
        
        public OrderDetails() { }
        
        public void AddProduct(Product product)
        {
            Products.Add(product);
        }
        
        public void RemoveProduct(Product product)
        {
            Products.Remove(product);
        }
        
        public int GetTotalPrice()
        {
            int totalPrice = 0;
            Products.ForEach(product => totalPrice += product.Price);
            return totalPrice;
        }
        
    }
}