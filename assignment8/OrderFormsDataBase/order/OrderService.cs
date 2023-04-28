using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderFormsDataBase.order {

    public class OrderService {

        public int OrderServiceId { get; set; }

        public OrderService() {
        }

        private static Order FixOrder(Order order) {
            if (order == null)
            {
                throw new ApplicationException("order is null!");
            }
            order.CustomerId = order.Customer.Id;
            order.Customer = null;
            return order;
        }
        
        //添加订单
        public void AddOrder(Order order) {
            using (var db = new OrderSeviceContext())
            {
                if (db.Orders.Count() == 0)
                {
                    order.Id = 1;
                }
                else
                {
                    order.Id = db.Orders.Max(o => o.Id) + 1;
                }
                db.Orders.Add(FixOrder(order));
                db.SaveChanges();
            }
        }

        //更新订单
        public void Update(Order order) {
            using (var db = new OrderSeviceContext())
            {
                db.Entry(order).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            
        }

        //根据Id查询订单
        public Order GetById(int orderId) {
            using (var db = new OrderSeviceContext())
            {
                return db.Orders.Where(o => o.Id == orderId).FirstOrDefault();
            }
        }

        //根据Id删除订单
        public void RemoveOrder(int orderId) {
            using (var db = new OrderSeviceContext())
            {
                db.Orders.Remove(db.Orders.Where(o => o.Id == orderId).FirstOrDefault());
                db.SaveChanges();
            } 
        }

        //查询所有订单
        public List<Order> QueryAll() {
            var orders = new List<Order>();
            using (var db = new OrderSeviceContext())
            {
                db.Orders.ToList().ForEach(o => orders.Add(o));
            }
            return orders;
        }

        //根据客户名查询
        public List<Order> QueryByCustomerName(string customerName) {
            var query = orders
                .Where(o => o.Customer.Name == customerName)
                .OrderBy(o => o.TotalPrice);
            return query.ToList();
        }

        //根据货物名查询
        public List<Order> QueryByGoodsName(string goodsName) {
            var query = orders.Where(
              o => o.Details.Any(d => d.Goods.Name == goodsName))
                .OrderBy(o => o.TotalPrice);
            return query.ToList();

            /** 其他方法
            var query2 = orders.Where(
              o => o.Details.Exists(d => d.Goods.Name == goodsName))
                .OrderBy(o => o.TotalPrice);

            var query3 = orders.Where(
             o => o.Details.Where(d => d.Goods.Name == goodsName).Count()>0)
               .OrderBy(o => o.TotalPrice);

            var query4 = orders.Where(
             o => HasGoods(o,goodsName)) //写一个HasGoods方法，来检查o中是否包含名为goodName的货物
               .OrderBy(o => o.TotalPrice); 
            **/
        }

        //根据总价查询
        public List<Order> QueryByTotalPrice(float totalPrice) {
            var query = orders.Where(o => o.TotalPrice >= totalPrice)
                .OrderBy(o => o.TotalPrice);
            return query.ToList();
        }


        //对orders中的数据进行排序
        public void Sort(Comparison<Order> comparison) {
            orders.Sort(comparison);
        }

        //根据传入的条件进行查询
        public IEnumerable<Order> Query(Predicate<Order> condition) {
            return orders.Where(o => condition(o)).OrderBy(o=>o.TotalPrice);
        }

    }
}
