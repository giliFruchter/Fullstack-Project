using Dal.Api;
using Dal.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Service
{
    public class CustomerService : ICustomer
    {
        DatabaseManager db;
        public CustomerService(DatabaseManager db)
        {
            this.db = db;
        }
        public void Create(Customer castomer)
        {
          
            db.Add(castomer);
            db.SaveChanges();
        }

        public void Delete(Customer item)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Customer>> Read()
        {
            return await db.Customers.ToListAsync();
        }


        public void UpDate(Customer item)
        {
            throw new NotImplementedException();
        }
        
    }
}
