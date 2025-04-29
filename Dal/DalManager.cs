using Dal.Api;
using Dal.Models;
using Dal.Service;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class DalManager : IDal
    {
        public ICustomer customers { get; set; }
        public IInvitation invitations { get; set; }
        public DalManager()
        {
            ServiceCollection service = new ServiceCollection();
            service.AddSingleton<DatabaseManager>(); // שינוי ל-Scoped
            service.AddSingleton<ICustomer,CustomerService>();
            service.AddSingleton<IInvitation, InvitationService>();
            ServiceProvider serviceProvider = service.BuildServiceProvider();
            customers = serviceProvider.GetService<ICustomer>();
            invitations = serviceProvider.GetService<IInvitation>();
        }
    }
}
