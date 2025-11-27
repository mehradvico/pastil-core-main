using Application.Common.Dto.Input;
using Application.Common.Dto.Result;
using Application.Services.ProductSrvs.DiscountGroupSrv.Dto;
using Application.Services.ProductSrvs.DiscountGroupSrv.Iface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Areas.Seller.Controllers
{
    /// <summary>
    /// مدیریت گروه تخفیف
    /// </summary>
    ///
    [Area("Seller")]
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Authorize]
    public class DiscountGroupController : ControllerBase
    {
        private IDiscountGroupService discountGroupService;
        /// <summary>
        /// مدیریت گروه تخفیف
        /// </summary>
        ///
        public DiscountGroupController(IDiscountGroupService discountGroupService)
        {
            this.discountGroupService = discountGroupService;
        }
        /// <summary>
        ///  اطلاعات آیتم 
        /// </summary>
        /// <param name="id">شناسه دسته بندی</param>
        /// <returns>
        /// </returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(BaseResultDto<DiscountGroupDto>), 200)]
        public async Task<IActionResult> Get(long id)
        {
            var role = await discountGroupService.FindAsyncDto(id);
            return Ok(role);
        }
        /// <summary>
        ///  جستجو
        /// </summary>
        /// <returns></returns> 

        [HttpGet]
        [ProducesResponseType(typeof(BaseResultDto<DiscountGroupDto>), 200)]
        public IActionResult Get([FromQuery] BaseInputDto dto)
        {
            var searchDto = discountGroupService.Search(dto);
            return Ok(searchDto);
        }

    }
}
