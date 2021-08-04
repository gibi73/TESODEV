using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIORDER.Model;

namespace APIORDER.Servis
{
    public interface IServicesOrder
    {
        Task<List<Order>> OrderCustomerByGetir(Guid customerId);
    }
}
