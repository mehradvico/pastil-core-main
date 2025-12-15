using Application.Common.Dto.Result;
using Application.Common.Interface;
using Application.Services.PansionSrvs.PansionPictureSrv.Dto;
using Application.Services.PansionSrvs.PansionPictureSrv.Iface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Areas.Companion.Controllers
{
    /// <summary>
    /// مدیریت تصویر پانسیون ها
    /// </summary>
    /// 
    [Area("Companion")]
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Authorize]
    public class PansionPictureController : ControllerBase
    {
        private readonly IPansionPictureService PansionPictureService;
        private readonly ICurrentUserHelper _currentUser;

        public PansionPictureController(IPansionPictureService PansionPictureService, ICurrentUserHelper currentUser)
        {
            this.PansionPictureService = PansionPictureService;
            this._currentUser = currentUser;
        }
        /// <summary>
        /// اطلاعات آیتم
        /// </summary>
        /// 
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(BaseResultDto<PansionPictureVDto>), 200)]
        public async Task<IActionResult> Get(long id)
        {
            var PansionPicture = await PansionPictureService.FindAsyncVDto(id);
            return Ok(PansionPicture);
        }
        /// <summary>
        /// جستجو
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(PansionPictureSearchDto), 200)]
        public IActionResult Get([FromQuery] PansionPictureInputDto dto)
        {
            dto.CompanionId = _currentUser.CurrentUser.CompanionId;
            var PansionPicture = PansionPictureService.Search(dto);
            return Ok(PansionPicture);
        }

        /// <summary>
        /// آیتم جدید
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(typeof(BaseResultDto<PansionPictureDto>), 200)]
        public async Task<IActionResult> Pansion(PansionPictureDto PansionPictureDto)
        {
            var result = await PansionPictureService.InsertAsyncDto(PansionPictureDto);
            return Ok(result);
        }
        /// <summary>
        /// ویرایش آیتم
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpPut]
        [ProducesResponseType(typeof(BaseResultDto<PansionPictureDto>), 200)]
        public IActionResult Put(PansionPictureDto PansionPictureDto)
        {
            var result = PansionPictureService.UpdateDto(PansionPictureDto);
            return Ok(result);
        }

        /// <summary>
        /// حذف آیتم
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpDelete]
        [ProducesResponseType(typeof(BaseResultDto<PansionPictureDto>), 200)]
        public IActionResult Delete(long id)
        {
            var result = PansionPictureService.DeleteDto(id);
            return Ok(result);
        }
    }
}
