using Wipro_DFA_API_E_CommerceApplication.EntityFramework;
using Wipro_DFA_API_E_CommerceApplication.Models;

namespace Wipro_DFA_API_E_CommerceApplication.Repository
{
    public class OrderHistoryRepository : IOrderHistoryRepository
    {
        private readonly WiproDfa26082024Context orderHistoryDbContext;
        public OrderHistoryRepository(WiproDfa26082024Context _orderHistoryDbContext)
        {
            orderHistoryDbContext = _orderHistoryDbContext;
        }

        public OrderHistory CreateOrder(OrderHistory order)
        {
            var result = orderHistoryDbContext.OrderHistories.Add(order);
            orderHistoryDbContext.SaveChanges();
            return result.Entity;
        }

        public bool DeleteOrder(int orderId)
        {
            var filterOrderHistoryData = orderHistoryDbContext.OrderHistories.Where(o => o.OrderId == orderId).FirstOrDefault();
            var result = orderHistoryDbContext.OrderHistories.Remove(filterOrderHistoryData);
            orderHistoryDbContext.SaveChanges();
            return result != null ? true : false;
        }

        public IEnumerable<OrderHistory> GetAllOrderHistories()
        {
            return orderHistoryDbContext.OrderHistories.ToList();
        }

        public OrderHistory SearchOrderHistory(int orderId)
        {
            return orderHistoryDbContext.OrderHistories.SingleOrDefault(o => o.OrderId == orderId);
        }

        public OrderHistory UpdateOrder(OrderHistory order)
        {
            if (order == null)
            {
                throw new ArgumentNullException("Entity Missing");
            }
            var result = orderHistoryDbContext.OrderHistories.Update(order);
            orderHistoryDbContext.SaveChanges();
            return result.Entity;
        }
    }
}
