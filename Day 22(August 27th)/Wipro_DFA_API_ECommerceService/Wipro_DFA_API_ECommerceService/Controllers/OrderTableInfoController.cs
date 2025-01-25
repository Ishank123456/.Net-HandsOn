using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wipro_DFA_API_ECommerceService.Models;
using Wipro_DFA_API_ECommerceService.Repository;

namespace Wipro_DFA_API_ECommerceService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderTableInfoController : ControllerBase
    {
        private readonly IOrderTableInfoRepository iOrderTableInfoRepository;
        public OrderTableInfoController(IOrderTableInfoRepository _iOrderTableInfoRepository)
        {
            iOrderTableInfoRepository = _iOrderTableInfoRepository;
        }

        [HttpPost("CreateOrder")]
        public ActionResult CreateOrder(OrderTableInfo order)
        {
            return Ok(iOrderTableInfoRepository.CreateOrder(order));
        }

        [HttpGet("GetAllOrderTableInfo")]
        public ActionResult GetAllOrderHistories()
        {
            return Ok(iOrderTableInfoRepository.GetAllOrderTableInfo());
        }

        [HttpGet("SearchOrderTableInfo")]
        public ActionResult SearchOrder(int orderId)
        {
            return Ok(iOrderTableInfoRepository.SearchOrderInfo(orderId));
        }

        [HttpPut("UpdateOrderTableInfo")]
        public ActionResult UpdateOrder(OrderTableInfo order)
        {
            return Ok(iOrderTableInfoRepository.UpdateOrder(order));
        }

        [HttpDelete("DeleteOrderTableInfo")]
        public ActionResult DeleteOrder(int orderId)
        {
            return Ok(iOrderTableInfoRepository.DeleteOrder(orderId));
        }
    }
}
