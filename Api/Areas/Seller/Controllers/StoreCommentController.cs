using Application.Common.Dto.Result;
using Application.Common.Helpers;
using Application.Services.ProductSrvs.StoreCommentSrv.Dto;
using Application.Services.ProductSrvs.StoreCommentSrv.Iface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Areas.Seller.Controllers
{
    /// <summary>
    /// مدیریت نظرات فروشگاه ها
    /// </summary>
    ///
    [Area("Seller")]
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Authorize]
    public class StoreCommentController : ControllerBase
    {
        private IStoreCommentService _storeCommentService;
        private readonly long _storeId;
        /// <summary>
        /// مدیریت نظرات فروشگاه ها
        /// </summary>
        ///
        public StoreCommentController(IStoreCommentService storeCommentService, IHttpContextAccessor httpContextAccessor)
        {
            this._storeCommentService = storeCommentService;
            _storeId = HttpContextHelper.GetStoreId(httpContextAccessor.HttpContext);
        }
        /// <summary>
        /// اطلاعات آیتم
        /// </summary>
        /// <param name="id">شناسه دسته بندی</param>
        /// <returns>
        /// </returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(BaseResultDto<StoreCommentDto>), 200)]
        public async Task<IActionResult> Get(long id)
        {
            var role = await _storeCommentService.FindAsyncDto(id);
            return Ok(role);
        }
        /// <summary>
        ///  جستجو
        /// </summary>
        /// <returns></returns> 

        [HttpGet]
        [ProducesResponseType(typeof(BaseResultDto<StoreCommentDto>), 200)]
        public IActionResult Get([FromQuery] StoreCommentInputDto dto)
        {
            dto.StoreId = _storeId;
            var searchDto = _storeCommentService.Search(dto);
            return Ok(searchDto);
        }

        /// <summary>
        /// ویرایش نظرات
        /// </summary>

        [HttpPut]
        [ProducesResponseType(typeof(BaseResultDto), 200)]
        public IActionResult Put(StoreCommentDto storeCommentDto)
        {
            storeCommentDto.StoreId = _storeId;
            var dto = _storeCommentService.UpdateDto(storeCommentDto);
            return Ok(dto);
        }

    }
}
