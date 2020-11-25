using System;

namespace MusicStore.Models
{
    public class Order
    {

        public int OrderID { get; set; }

        public int CustomerID { get; set; }

        public int ProductID { get; set; }

        public int OrderNumber { get; set; }

        public DateTime OrderDate { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Product Product { get; set; }

    }
}