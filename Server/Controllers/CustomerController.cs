using BL.Api;
//using BL.Models;
using BL.Services;
using Dal.Api;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Dal.Models;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        IBLcustomer  customerActions;
        public CustomerController(IBlManager bl) {
            customerActions = bl.BlCustomer ;
        }
        //[HttpPost]
        //public ActionResult<Customer> CreateNewCustomer([FromBody] Customer customer)
        //{
        //    customerActions.Create(customer);
        //    return customer;
        //}

        [HttpGet]
        public async Task<IActionResult> GetAllCustomers()
        {
            var allCustomers = await customerActions.GetAll(); // הוספת await
            if (allCustomers == null || allCustomers.Count == 0)
            {
                return NotFound("ERROR!! there are no available customers!!");
            }
            return Ok(allCustomers);
        }
    }
}
