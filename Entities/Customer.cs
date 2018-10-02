using System;
using System.Collections.Generic;

namespace Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private Lazy<IEnumerable<Order>> orders;

        public Customer() { }

        public Customer(Lazy<IEnumerable<Order>> orders)
        {
            this.orders = orders;
        }

        public IEnumerable<Order> Orders
        {
            get => orders?.Value;
            set
            {
                orders = new Lazy<IEnumerable<Order>>(() => value);
            }
        }
    }
}
