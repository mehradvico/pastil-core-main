using Application.Common.Helpers;
using Application.Common.Interface;
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
        private readonly ICurrentUserHelper _currentUser;

        /// <summary>
        /// مدیریت برند ها
        /// </summary>
        ///
        public BrandController(IBrandService brandService, ICurrentUserHelper currentUser)
        {
            this.brandService = brandService;
            this._currentUser = currentUser;

        }

        [HttpGet]
        [ProducesResponseType(typeof(BrandSearchDto), 200)]
        public IActionResult Get([FromQuery] BrandInputDto dto)
        {
            dto.StoreId = _currentUser.CurrentUser.StoreId;
            var searchDto = brandService.Search(dto);
            return Ok(searchDto);
        }

    }
}
