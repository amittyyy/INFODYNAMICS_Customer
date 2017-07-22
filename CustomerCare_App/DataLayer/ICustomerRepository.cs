using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;

namespace DataLayer
{
    public interface ICustomerRepository
    {
        List<Customer> GetAll();

        Customer GetById(int id);

        Customer Insert(Customer customer);

        void Update(Customer customer);

        void Delete(Customer customer);

    }
}
