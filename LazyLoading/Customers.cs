using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LazyLoading
{
    public class Customers
    {

        [Key]
        public string CustomerID {get; set;}
        public string CompanyName {get; set;}
        public string ContactName {get; set;}
        public virtual ICollection<Orders> Orders {get; set;}

        public Customers()
        {
            Orders = new List<Orders>();

        }
    }
}