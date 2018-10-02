using System;
using System.Collections.Generic;
using Entities;

namespace DAL
{
    public class CustomerManager : ICustomerManager
    {
        public Customer GetCustomer(int customerId)
        {
            var person = new Customer(new Lazy<IEnumerable<Order>>(() => GetOrders(customerId)))
            {
                Id = customerId,
                Name = $"Customer-{customerId}"
            };
            return person;
        }

        public IEnumerable<Order> GetOrders(int customerId)
        {
            return new List<Order>
            {
                new Order
                {
                    Id = 2,
                    Title = $"Order-{customerId}"
                }
            };
        }
    }
}
