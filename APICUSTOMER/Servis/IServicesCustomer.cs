using APICUSTOMER.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICUSTOMER.Servis
{
   public interface IServicesCustomer
    {
        Task<Customer> GetirCustomer(Guid customerId);
    }
}
