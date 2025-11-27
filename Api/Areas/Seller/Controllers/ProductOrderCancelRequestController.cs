using Application.Common.Dto.Result;
using Application.Services.Order.ProductOrderSrv.Dto;
using Application.Services.Order.ProductOrderSrv.Iface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Areas.Seller.Controllers
{
    /// <summary>
    /// مدیریت سفارش ها
    /// </summary>
    ///
    [Area("Seller")]
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductOrderCancelRequestController : ControllerBase
    {
        private IProductOrderService productOrderService;

        /// <summary>
        /// مدیریت سفارش ها
        /// </summary>
        ///
        public ProductOrderCancelRequestController(IProductOrderService productOrder)
        {
            productOrderService = productOrder;
        }
        /// <summary>
        ///  اطلاعات آیتم 
        /// </summary>
        /// <returns>
        /// </returns>
        [HttpPost]
        [ProducesResponseType(typeof(BaseResultDto), 200)]
        public async Task<IActionResult> Post(ProductOrderDto productOrder)
        {
            productOrder.CancelRequest = DateTime.Now;
            var dto = await productOrderService.SetCancelRequestAsync(productOrder);
            return Ok(dto);
        }
    }
}
