using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ModelLayer;


namespace DataLayer
{
    public class CustomerRepository : ICustomerRepository
    {
        public void Delete(Customer customer)
        {
            using (INFODYNAMICSEntities db = new INFODYNAMICSEntities())
            {
                db.Customers.Attach(customer);
                db.Customers.Remove(customer);
                db.SaveChanges();
            }
        }

        public List<Customer> GetAll()
        {
            using (INFODYNAMICSEntities db = new INFODYNAMICSEntities())
            {
                return db.Customers.ToList();
            }
        }

        public Customer GetById(int id)
        {
            using (INFODYNAMICSEntities db = new INFODYNAMICSEntities())
            {
                return db.Customers.Find(id);
            }
        }

        public Customer Insert(Customer customer)
        {
            using (INFODYNAMICSEntities db = new INFODYNAMICSEntities())
            {
                db.Customers.Add(customer);
                db.SaveChanges();
                return customer;
            }
        }

        public void Update(Customer customer)
        {
            using (INFODYNAMICSEntities db = new INFODYNAMICSEntities())
            {
                db.Customers.Attach(customer);
                db.Entry(customer).State = EntityState.Modified;
                db.SaveChanges();

            }
        }
    }
}
