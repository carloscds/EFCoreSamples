using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LazyLoading
{
    public class Orders
    {
        [Key]
        public int OrderID {get; set;}
        public string CustomerID {get; set;}
        public virtual Customers Customers {get; set;}
        public DateTime OrderDate {get; set;}
    }
}