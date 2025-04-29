using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BL.Api;
using BL.Services;
using Dal;
using Dal.Api;
using Microsoft.Extensions.DependencyInjection;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BlManager : IBlManager
    {
        // מיצגת את השכבה
        public IBLcustomer? BlCustomer { get; }
        public IBLInvitation? BlInvitation { get; }

        public BlManager()
        {
            ServiceCollection services = new ServiceCollection();
            services.AddSingleton<IDal, DalManager>();
            services.AddSingleton<IBLcustomer, BLCustomerService>();
            services.AddSingleton<IBLInvitation, BLInvitationService>();
            ServiceProvider serviceProvider = services.BuildServiceProvider();
            BlCustomer = serviceProvider.GetService<IBLcustomer>();
            BlInvitation=serviceProvider.GetService<IBLInvitation>();
        }
    }
}