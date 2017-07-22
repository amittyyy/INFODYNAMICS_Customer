using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using ModelLayer;


namespace BusinessLayer
{
    public static class CustomerServices
    {
        static  ICustomerRepository repository;

        static CustomerServices()
        {
            repository = new CustomerRepository();
        }

        public static List<Customer> GetAll()
        {
            return repository.GetAll();
        }

        public static Customer GetById(int id)
        {
            return repository.GetById(id);
        }

        public static Customer Insert(Customer customer)
        {
            return repository.Insert(customer);
        }

        public static void Update(Customer customer)
        {
            repository.Update(customer);
        }

        public static void Delete(Customer customer)
        {
            repository.Delete(customer);
        }
    }
}
