using APICUSTOMER.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICUSTOMER.InfraStructure
{
   public interface ICustomerServices
    {
        Task YeniCustomer(string name, string email, Address address);
        Task SilCustomer(Guid customerid);
        Task GuncelleCustomer(Guid customerId, string email);
        Task<Customer> CustomerGetir(Guid customerid);
    }
}
