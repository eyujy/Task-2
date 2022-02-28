using System;
namespace OrderApi.Models
{
    public class Order
    {
        public string OrderId { get; set; }

        public string ProductId { get; set; }

        public double ProductPrice { get; set; }

        public string Total { get; set; }

        public string OrderStatus { get; set; }

        public int CartId { get; set; }


    }
}
