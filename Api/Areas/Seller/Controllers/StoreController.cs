using Application.Common.Dto.Result;
using Application.Services.ProductSrvs.StoreSrv.Dto;
using Application.Services.StoreSrv.Iface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Areas.Seller.Controllers
{
    /// <summary>
    /// مدیریت فروشنده ها
    /// </summary>
    [Area("Seller")]
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Authorize]
    public class StoreController : ControllerBase
    {
        private readonly IStoreService StoreService;
        public StoreController(IStoreService StoreService)
        {
            this.StoreService = StoreService;
        }

        /// <summary>
        /// اطلاعات آیتم
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// 

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(BaseResultDto<StoreDto>), 200)]
        public async Task<IActionResult> Get(long id)
        {
            var Store = await StoreService.FindAsyncDto(id);
            return Ok(Store);
        }
        /// <summary>
        /// ویرایش آیتم
        /// </summary>
        /// 
        [HttpPut]
        [ProducesResponseType(typeof(BaseResultDto<StoreDto>), 200)]
        public IActionResult Put(StoreDto StoreDto)
        {
            var item = StoreService.UpdateDto(StoreDto);
            return Ok(item);
        }
    }
}
