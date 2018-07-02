using System;

namespace LazyLoading
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new Contexto();

            var cliente = db.Customers;
            foreach(var c in cliente)
            {
                Console.WriteLine($"{c.CompanyName} - Orders: {c.Orders.Count}");
            }
        }
    }
}
