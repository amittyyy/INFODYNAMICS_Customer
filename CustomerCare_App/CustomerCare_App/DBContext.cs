using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CustomerCare_App
{
    public class DbContext
    {
        private readonly SqlConnection _connString = new SqlConnection("Data Source=DESKTOP-NPQQVLU;Initial Catalog=INFODYNAMICS;Integrated Security=True");
        

        public DataTable GetCusotmerList()   //Fill customer table
        {
            DataTable dtCustomer = new DataTable();
            String selectQuery = "select *from customer";
            using (SqlCommand cmd = new SqlCommand(selectQuery, _connString))
            {
                _connString.Open();
                SqlDataReader sqlReader = cmd.ExecuteReader();
                dtCustomer.Load(sqlReader);
            }

            return dtCustomer;
        }

        public DataTable SearchCustomer(string name)   //Search Custoemr by Name;
        {
            String searchQuery = "select *from Customer where name like '" + name +"%'";
            DataTable dtSearchCutomer = new DataTable();
            using (SqlCommand cmd = new SqlCommand(searchQuery,_connString))
            {
                _connString.Open();
                SqlDataReader sqlSearch = cmd.ExecuteReader();
                dtSearchCutomer.Load(sqlSearch);
            }
            return dtSearchCutomer;
        }
        
    }
}
