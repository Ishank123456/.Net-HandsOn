using Wipro_DFA_API_ECommerceService.EntityFramework;
using Wipro_DFA_API_ECommerceService.Models;

namespace Wipro_DFA_API_ECommerceService.Repository
{
    public class OrderTableInfoRepository : IOrderTableInfoRepository
    {
        private readonly WiproDfa26082024Context orderInfoDbContext;
        public OrderTableInfoRepository(WiproDfa26082024Context _orderInfoDbContext)
        {
            orderInfoDbContext = _orderInfoDbContext;
        }

        public OrderTableInfo CreateOrder(OrderTableInfo order)
        {
            var result = orderInfoDbContext.OrderTableInfos.Add(order);
            orderInfoDbContext.SaveChanges();
            return result.Entity;
        }

        public bool DeleteOrder(int orderId)
        {
            var filterOrderInfoData = orderInfoDbContext.OrderTableInfos.Where(o => o.OrderId == orderId).FirstOrDefault();
            var result = orderInfoDbContext.OrderTableInfos.Remove(filterOrderInfoData);
            orderInfoDbContext.SaveChanges();
            return result != null ? true : false;
        }

        public IEnumerable<OrderTableInfo> GetAllOrderTableInfo()
        {
            return orderInfoDbContext.OrderTableInfos.ToList();
        }

        public OrderTableInfo SearchOrderInfo(int orderId)
        {
            return orderInfoDbContext.OrderTableInfos.SingleOrDefault(o => o.OrderId == orderId);
        }

        public OrderTableInfo UpdateOrder(OrderTableInfo order)
        {
            if (order == null)
            {
                throw new ArgumentNullException("Entity Missing");
            }
            var result = orderInfoDbContext.OrderTableInfos.Update(order);
            orderInfoDbContext.SaveChanges();
            return result.Entity;
        }
    }
}
