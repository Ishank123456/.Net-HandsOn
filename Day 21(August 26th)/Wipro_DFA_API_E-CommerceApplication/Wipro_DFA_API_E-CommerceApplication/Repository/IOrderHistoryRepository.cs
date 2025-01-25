using Wipro_DFA_API_E_CommerceApplication.Models;

namespace Wipro_DFA_API_E_CommerceApplication.Repository
{
    public interface IOrderHistoryRepository
    {
        IEnumerable<OrderHistory> GetAllOrderHistories();
        OrderHistory SearchOrderHistory(int orderId);
        OrderHistory CreateOrder(OrderHistory order);
        OrderHistory UpdateOrder(OrderHistory order);
        bool DeleteOrder(int orderId);
    }
}
