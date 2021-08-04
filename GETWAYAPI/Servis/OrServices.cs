using GETWAYAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GETWAYAPI.Servis
{
    public class OrServices: IOrServices
    {
        private readonly HttpClient httpClient;
        public OrServices(HttpClient cusClient) => httpClient = cusClient;
        public async Task<List<Order>> OrderCustomerGetir(Guid customerId)
        {
            var deger = await httpClient.GetAsync("OrderCusGet/{customerId}");
            return await deger.Content.ReadAsAsync<List<Order>>();
        }

       
    }
}
