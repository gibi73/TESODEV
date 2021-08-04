using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APICUSTOMER.Model;

namespace APICUSTOMER.InfraStructure
{
    public class CustomerServices:ICustomerServices
    {
        private readonly DBContextAPI dBContextAPI;

        public CustomerServices(DBContextAPI CustomerContext) => dBContextAPI = CustomerContext;
        public async Task YeniCustomer(string name, string email, Address address)
        {
            var veri = new Customer
            {
                Name = name,
                Email = email,
                Address = address,
                CreatedAt = DateTime.Now,
                UpdateAt = DateTime.Now
            };

            await dBContextAPI.AddAsync(veri);
            await dBContextAPI.SaveChangesAsync();

        }
        public async Task SilCustomer(Guid Id)
        {

            var veri = dBContextAPI.Customers.FirstOrDefault(p => p.Id == Id);
            dBContextAPI.Customers.Remove(veri);
            await dBContextAPI.SaveChangesAsync();
        }

        public async Task GuncelleCustomer(Guid customerId, string email)
        {
            var veri = dBContextAPI.Customers.FirstOrDefault(p => p.Id == customerId);
            veri.Email = email;
            await dBContextAPI.SaveChangesAsync();
        }


        public async Task<Customer> CustomerGetir(Guid customerId)
        {
            var veri = dBContextAPI.Customers.FirstOrDefault(p => p.Id == customerId);
            return veri;

        }
    }
}
