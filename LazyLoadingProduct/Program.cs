using System;
using System.Linq;
using BLL;

namespace LazyLoadingProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new CustomerOrder();
            var customer = order.GetCustomer();
            var orders = customer.Orders;

            Console.WriteLine(orders.FirstOrDefault()?.Title);
            Console.ReadKey();
        }
    }
}
