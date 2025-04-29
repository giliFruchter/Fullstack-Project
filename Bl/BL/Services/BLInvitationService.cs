using BL.Api;
using Dal.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Services
{
    public class BLInvitationService : IBLInvitation
    {
        IInvitation invitation;
        public BLInvitationService(IDal dal)
        {
            invitation = dal.invitations;
        }
        public async Task<List<int>> GetBusyDatesPerMonth(int month, int year)
        {
            var invitationList = await invitation.Read();
            var busyDates = new List<DateOnly>();

            foreach (var invitation in invitationList)
            {
                if (month == invitation.Date.Month&& year==invitation.Date.Year)
                {
                    busyDates.Add(invitation.Date);
                }
            }
            var busyDays = new List<int>();

            foreach (var date in busyDates)
            {
               
               busyDays.Add(date.Day);
                
            }

            return busyDays;
        }

        
    }
}
