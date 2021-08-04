using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIORDER.Model;
using APIORDER.InfraStructure;
namespace APIORDER.Servis
{
    public class ServicesOrder: IServicesOrder
    {
        private readonly IOrderServices orderServices;
        public ServicesOrder(IOrderServices alorderServices) => orderServices = alorderServices;
        public async Task<List<Order>> OrderCustomerByGetir(Guid customerId)
        {
            return await orderServices.OrderCustomerByGetir(customerId);
        }
    }
}
