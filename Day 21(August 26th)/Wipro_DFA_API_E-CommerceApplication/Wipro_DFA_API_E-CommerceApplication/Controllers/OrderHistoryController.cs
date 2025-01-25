using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wipro_DFA_API_E_CommerceApplication.Models;
using Wipro_DFA_API_E_CommerceApplication.Repository;

namespace Wipro_DFA_API_E_CommerceApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderHistoryController : ControllerBase
    {
        private readonly IOrderHistoryRepository iOrderHistoryRepository;
        public OrderHistoryController(IOrderHistoryRepository _iOrderHistoryRepository)
        {
            iOrderHistoryRepository = _iOrderHistoryRepository;
        }

        [HttpPost("CreateOrder")]
        public ActionResult CreateOrder(OrderHistory order)
        {
            return Ok(iOrderHistoryRepository.CreateOrder(order));
        }

        [HttpGet("GetAllOrderHistories")]
        public ActionResult GetAllOrderHistories()
        {
            return Ok(iOrderHistoryRepository.GetAllOrderHistories());
        }

        [HttpGet("SearchOrderHistory")]
        public ActionResult SearchOrder(int orderId)
        {
            return Ok(iOrderHistoryRepository.SearchOrderHistory(orderId));
        }

        [HttpPut("UpdateOrderHistory")]
        public ActionResult UpdateOrder(OrderHistory order)
        {
            return Ok(iOrderHistoryRepository.UpdateOrder(order));
        }

        [HttpDelete("DeleteOrderHistory")]
        public ActionResult DeleteOrder(int orderId)
        {
            return Ok(iOrderHistoryRepository.DeleteOrder(orderId));
        }
    }
}
