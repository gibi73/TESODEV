using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIORDER.Model;

namespace APIORDER.InfraStructure
{
   public interface IOrderServices
    {
        Task GuncelleOrder(Guid Id, string status);
        Task<List<Order>> OrderCustomerByGetir(Guid Id);
        Task SilOrder(Guid Id);
        
        Task YeniOrder(int quantity, double price, Address address, string status, Product product);
    }
}
