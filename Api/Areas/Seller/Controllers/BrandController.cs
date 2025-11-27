using Application.Common.Helpers;
using Application.Services.ProductSrvs.BrandSrv.Dto;
using Application.Services.ProductSrvs.BrandSrv.Iface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Areas.Seller.Controllers
{
    /// <summary>
    /// مدیریت برندها
    /// </summary>
    ///
    [Area("Seller")]
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Authorize]
    public class BrandController : ControllerBase
    {
        private IBrandService brandService;
        private readonly long _storeId;

        /// <summary>
        /// مدیریت برند ها
        /// </summary>
        ///
        public BrandController(IBrandService brandService, IHttpContextAccessor httpContextAccessor)
        {
            this.brandService = brandService;
            _storeId = HttpContextHelper.GetStoreId(httpContextAccessor.HttpContext);

        }

        [HttpGet]
        [ProducesResponseType(typeof(BrandSearchDto), 200)]
        public IActionResult Get([FromQuery] BrandInputDto dto)
        {
            dto.StoreId = _storeId;
            var searchDto = brandService.Search(dto);
            return Ok(searchDto);
        }

    }
}
