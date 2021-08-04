using GETWAYAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GETWAYAPI.Servis
{
 interface IOrServices
    {
        Task<List<Order>> OrderCustomerGetir(Guid customerId);
    }
}
