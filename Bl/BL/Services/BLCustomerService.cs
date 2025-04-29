using BL.Api;
using Dal.Api;
using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace BL.Services
{
    public class BLCustomerService:IBLcustomer
    {
        ICustomer Cast;
        public BLCustomerService(IDal dal) {
            Cast = dal.customers;
        }
        //public async Task Create(Customer cas)
        //{
        //    Customer? c = (await Cast.Read()).Find(c => c.Id == cas.Id);
        //    if (c != null) throw new Exception("עובד קיים");
        //    await Cast.Create(cas);
        //}

        public async Task<List<Customer>> GetAll()
        {
            return await Cast.Read();
        }

    }
}
