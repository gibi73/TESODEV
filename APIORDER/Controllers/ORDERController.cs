using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIORDER.Model;
using APIORDER.Servis;

namespace APIORDER.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ORDERController : ControllerBase
    {
        private readonly IServicesOrder dataservicesOrder;
        public ORDERController(IServicesOrder contservicesOrder) => dataservicesOrder = contservicesOrder;

        [HttpGet("GetirOrderCustomer/{customerId}")]
        public async Task<List<Order>> GetirOrderCustomer(int customerId)
        {
            var customerIds = Guid.NewGuid();
            return await dataservicesOrder.OrderCustomerByGetir(customerIds);
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
