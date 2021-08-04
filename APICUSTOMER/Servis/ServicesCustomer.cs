using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APICUSTOMER.Model;
using APICUSTOMER.InfraStructure;


namespace APICUSTOMER.Servis
{
    public class ServicesCustomer:IServicesCustomer
    {
        private readonly ICustomerServices iletcustomerServices;
        public ServicesCustomer(ICustomerServices customerServices) => iletcustomerServices = customerServices;
        public async Task<Customer> GetirCustomer(Guid customerId)
        {
            return await iletcustomerServices.CustomerGetir(customerId);
        }
    }
}
