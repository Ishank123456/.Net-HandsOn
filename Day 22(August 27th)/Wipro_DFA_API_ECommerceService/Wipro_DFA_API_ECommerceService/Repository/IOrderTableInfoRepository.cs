using Wipro_DFA_API_ECommerceService.Models;

namespace Wipro_DFA_API_ECommerceService.Repository
{
    public interface IOrderTableInfoRepository
    {
        IEnumerable<OrderTableInfo> GetAllOrderTableInfo();
        OrderTableInfo SearchOrderInfo(int orderId);
        OrderTableInfo CreateOrder(OrderTableInfo orderInfo);
        OrderTableInfo UpdateOrder(OrderTableInfo orderInfo);
        bool DeleteOrder(int orderId);
    }
}
