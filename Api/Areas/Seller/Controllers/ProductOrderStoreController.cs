using Application.Common.Helpers;
using Application.Common.Interface;
using Application.Services.Order.ProductOrderStoreOrderSrv.Dto;
using Application.Services.Order.ProductOrderStoreSrv.Dto;
using Application.Services.Order.ProductOrderStoreSrv.Iface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Areas.Seller.Controllers
{
    /// <summary>
    /// مدیریت  آیتم سفارش ها
    /// </summary>
    ///
    [Area("Seller")]
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductOrderStoreController : ControllerBase
    {
        private readonly IProductOrderStoreService _productOrderStoreService;
        private readonly ICurrentUserHelper _currentUser;

        /// <summary>
        /// مدیریت  آیتم سفارش ها
        /// </summary>
        ///
        public ProductOrderStoreController(IProductOrderStoreService productOrderStoreService, ICurrentUserHelper currentUser)
        {
            this._productOrderStoreService = productOrderStoreService;
            this._currentUser = currentUser;

        }

        /// <summary>
        ///  جستجو
        /// </summary>
        /// <returns></returns> 
        [HttpGet()]
        [ProducesResponseType(typeof(ProductOrderStoreSearchDto), 200)]
        public IActionResult Get([FromQuery] ProductOrderStoreInputDto dto)
        {
            dto.StoreId = _currentUser.CurrentUser.StoreId;
            var productOrderItems = _productOrderStoreService.Search(dto);
            return Ok(productOrderItems);
        }

    }
}
