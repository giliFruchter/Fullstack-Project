using Dal.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Api
{
    public interface IBlManager
    {
        public IBLcustomer BlCustomer { get; }
        public IBLInvitation BlInvitation { get; }
    }
}
