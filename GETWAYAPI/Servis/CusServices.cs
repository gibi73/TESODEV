using GETWAYAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GETWAYAPI.Servis
{
    public class CusServices:ICusServices
    {
        private readonly HttpClient httpClient;
        public CusServices(HttpClient cusClient)=> httpClient=cusClient;
        public async Task<Customer>CustomerGetir(Guid customerId)
        {
            var deger = await httpClient.GetAsync("CustomerGet/{customerId}");
            return await deger.Content.ReadAsAsync<Customer>();
        }
    }
}
