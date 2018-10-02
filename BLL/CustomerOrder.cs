using DAL;
using Entities;

namespace BLL
{
    public class CustomerOrder : ICustomerOrder
    {
        public Customer GetCustomer()
        {
            return new CustomerManager().GetCustomer(1);
        }
    }
}
