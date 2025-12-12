using Application.Common.Dto.Result;
using Application.Common.Interface;
using Application.Services.CompanionSrvs.CompanionAssistancePackagePictureSrv.Dto;
using Application.Services.CompanionSrvs.CompanionAssistancePackagePictureSrv.Iface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    /// <summary>
    /// مدیریت تصویر پکیج ها
    /// </summary>
    /// 
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CompanionAssistancePackagePictureController : ControllerBase
    {
        private readonly ICompanionAssistancePackagePictureService companionassistancepackagePictureService;
        /// <summary>
        /// مدیریت تصویر محصول ها
        /// </summary>

        public CompanionAssistancePackagePictureController(ICompanionAssistancePackagePictureService companionassistancepackagePictureService)
        {
            this.companionassistancepackagePictureService = companionassistancepackagePictureService;
        }
        /// <summary>
        /// اطلاعات آیتم
        /// </summary>
        /// 
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(BaseResultDto<CompanionAssistancePackagePictureDto>), 200)]
        public async Task<IActionResult> Get(long id)
        {
            var companionassistancepackagePicture = await companionassistancepackagePictureService.FindAsyncDto(id);
            return Ok(companionassistancepackagePicture);
        }
        /// <summary>
        /// جستجو
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(CompanionAssistancePackagePictureSearchDto), 200)]
        public IActionResult Get([FromQuery] CompanionAssistancePackagePictureInputDto dto)
        {
            var companionassistancepackagePicture = companionassistancepackagePictureService.SearchDto(dto);
            return Ok(companionassistancepackagePicture);
        }
    }
}
