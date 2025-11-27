using Application.Common.Helpers;
using Application.Common.Interface;
using Application.Services.ProductSrv.Dto;
using Application.Services.ProductSrvs.ProductSrv.Iface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Areas.Seller.Controllers
{
    /// <summary>
    /// مدیریت فروشگاه ها
    /// </summary>
    ///
    [Area("Seller")]
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly ICurrentUserHelper _currentUserHelper;
        private readonly long _storeId;
        /// <summary>
        /// مدیریت فروشگاه ها
        /// </summary>
        ///
        public ProductController(IProductService productService, ICurrentUserHelper currentUserHelper, IHttpContextAccessor httpContextAccessor)
        {
            this._productService = productService;
            this._currentUserHelper = currentUserHelper;
            _storeId = HttpContextHelper.GetStoreId(httpContextAccessor.HttpContext);
        }
        /// <summary>
        /// جستجو
        /// </summary>
        [HttpGet]
        [ProducesResponseType(typeof(ProductSearchDto), 200)]
        public IActionResult Get([FromQuery] ProductInputDto dto)
        {
            dto.StoreId = _storeId;
            dto.Available = true;
            var Product = _productService.Search(dto);
            return Ok(Product);
        }

    }
}
