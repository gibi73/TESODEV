using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using APICUSTOMER.Model;

namespace APICUSTOMER.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CUSTOMERController : ControllerBase
    {
        private readonly APICUSTOMER.Servis.IServicesCustomer servicesCustomer;
        public CUSTOMERController(APICUSTOMER.Servis.IServicesCustomer services) => servicesCustomer = services;

        [HttpGet("getirCustomer/{customerId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<Customer> GetirCustomer(Guid customerId)
        {
            return await servicesCustomer.GetirCustomer(customerId);
        }

        [HttpGet("{id}")]
       
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
    
        public void Post([FromBody] string value)
        {
        }

        [HttpPut("{id}")]
       
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
       
        public void Delete(int id)
        {
        }
    }
}
