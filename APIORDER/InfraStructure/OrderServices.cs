using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIORDER.Model;

namespace APIORDER.InfraStructure
{
    public class OrderServices: IOrderServices
    {
        private readonly DBContextAPI dbContextAPI;
        public OrderServices(DBContextAPI contextAPI) => dbContextAPI = contextAPI;
        public async Task GuncelleOrder(Guid Id, string status)
        {
            var order = dbContextAPI.Orders.FirstOrDefault(p => p.Id == Id);
            order.Status = status;
            await dbContextAPI.SaveChangesAsync();
        }
        public async Task SilOrder(Guid Id)
        {
            var order = dbContextAPI.Orders.FirstOrDefault(p => p.Id == Id);
            dbContextAPI.Orders.Remove(order);
            await dbContextAPI.SaveChangesAsync();
        }
        public async Task YeniOrder(int quantity, double price, Address address, string status, Product product)
        {
            var veri = new Order
            {
                Quantity = quantity,
                Price = price,
                Status = status,
                Address = address,
                Product = product,
                CreatedAt = DateTime.Now,
                UpdateAt = DateTime.Now
            };

            await dbContextAPI.AddAsync(veri);
            await dbContextAPI.SaveChangesAsync();
        }
              

        public async Task<List<Order>> OrderCustomerByGetir(Guid Id)
        {
            var veri = dbContextAPI.Orders.Where(p => p.CustomerId == Id).ToList();
            return veri;
        }

        



    }
}
