using Application.Common.Dto.Result;
using Application.Services.CompanionSrvs.CompanionSrv.Dto;
using Application.Services.CompanionSrvs.CompanionSrv.Iface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Areas.Admin.Controllers
{
    /// <summary>
    /// آپدیت همکار نقره ای
    /// </summary>
    /// 
    [Area("Admin")]
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Authorize]
    public class CompanionUpdateSilverAccountController : ControllerBase
    {
        private readonly ICompanionService _companionService;
        public CompanionUpdateSilverAccountController(ICompanionService companionService)
        {
            this._companionService = companionService;
        }

        /// <summary>
        ///  ویرایش آیتم 
        /// </summary>
        /// <returns>
        /// </returns>
        [HttpPut]
        [ProducesResponseType(typeof(BaseResultDto), 200)]
        public IActionResult Put(CompanionSilverAccountDto dto)
        {
            var companion = _companionService.UpdateSilverAccountDto(dto);
            return Ok(companion);
        }
    }
}
