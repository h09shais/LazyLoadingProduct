using System.Collections.Generic;
using Entities;

namespace DAL
{
    interface ICustomerManager
    {
        Customer GetCustomer(int customerId);
        IEnumerable<Order> GetOrders(int customerId);
    }
}
