using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Api
{
    public interface IBLInvitation
    {
        public Task<List<int>> GetBusyDatesPerMonth(int month, int year);
    }
}
