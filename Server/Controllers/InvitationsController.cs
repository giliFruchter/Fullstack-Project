using BL.Api;
using Dal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvitationsController : ControllerBase
    {
        IBLInvitation invitationActions;
        public InvitationsController(IBlManager bl)
        {
            invitationActions = bl.BlInvitation;
        }
        //[HttpPost]
        //public ActionResult<Customer> CreateNewCustomer([FromBody] Customer customer)
        //{
        //    {
        //        customerActions.Create(customer);
        //        return customer;
        //    }
        //}
        [HttpGet("{monthNum}/{yearNum}")]
        public async Task<ActionResult<List<int>>> GetBusyDates(int monthNum, int yearNum)
        {
            var busyDates = await invitationActions.GetBusyDatesPerMonth(monthNum,yearNum); // הנחתי ששינית את השיטה לאסינכרונית
            if (busyDates == null || busyDates.Count == 0)
                return new List<int>();

            return busyDates;
        }

    }
}