using Application.Common.Dto.Result;
using Application.Common.Helpers;
using Application.Services.Order.ProductOrderOrderSrv.Dto;
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
    public class ProductOrderController : ControllerBase
    {
        private IProductOrderService productOrderService;
        private readonly long _storeId;
        /// <summary>
        /// مدیریت سفارش ها
        /// </summary>
        ///
        public ProductOrderController(IProductOrderService productOrder, IHttpContextAccessor httpContextAccessor)
        {
            productOrderService = productOrder;
            _storeId = HttpContextHelper.GetStoreId(httpContextAccessor.HttpContext);
        }
        /// <summary>
        ///  اطلاعات آیتم 
        /// </summary>
        /// <param name="id">شناسه دسته بندی</param>
        /// <returns>
        /// </returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(BaseResultDto<ProductOrderVDto>), 200)]
        public async Task<IActionResult> Get(string id)
        {
            var productOrder = await productOrderService.FindAsyncVDto(id);
            return Ok(productOrder);
        }
        /// <summary>
        ///  جستجو
        /// </summary>

        /// <returns></returns> 

        [HttpGet()]
        [ProducesResponseType(typeof(BaseSearchDto<ProductOrderVDto>), 200)]
        public IActionResult Get([FromQuery] ProductOrderInputDto dto)
        {
            dto.StoreId = _storeId;
            var productOrders = productOrderService.Search(dto);
            return Ok(productOrders);
        }

    }
}
