using System.Collections.Generic;

namespace OrderFormsDataBase.order {

  /**
   **/
  public class OrderDetail {

    public Goods Goods { get; set; }

    public int Quantity { get; set; }

    public float TotalPrice {
      get => Goods.Price * Quantity;
    }

    public OrderDetail() {}

    public OrderDetail(Goods goods, int quantity) {
      this.Goods = goods;
      this.Quantity = quantity;
    }

    public override bool Equals(object obj) {
      var detail = obj as OrderDetail;
      return detail != null &&
             EqualityComparer<Goods>.Default.Equals(Goods, detail.Goods);
    }

    public override int GetHashCode() {
      return 785010553 + EqualityComparer<Goods>.Default.GetHashCode(Goods);
    }

    public override string ToString() {
      return $"OrderDetail:{Goods},{Quantity}";
    }
  }
}
