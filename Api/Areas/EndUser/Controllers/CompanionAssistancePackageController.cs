
using Application.Services.CompanionSrv.CompanionAssistancePackageSrv.Dto;
using Application.Services.CompanionSrv.CompanionAssistancePackageSrv.Iface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Areas.EndUser.Controllers
{
    /// <summary>
    /// مدیریت پکیج های خدماتی همکاران
    /// </summary>
    /// 
    [Area("EndUser")]
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Authorize]
    public class CompanionAssistancePackageController : ControllerBase
    {
        private readonly ICompanionAssistancePackageService _companionAssistancePackageService;
        public CompanionAssistancePackageController(ICompanionAssistancePackageService companionAssistancePackageService)
        {
            this._companionAssistancePackageService = companionAssistancePackageService;
        }

        /// <summary>
        /// جستجو
        /// </summary>
        /// <returns></returns> 
        [HttpGet()]
        [ProducesResponseType(typeof(CompanionAssistancePackageSearchDto), 200)]
        public IActionResult Get([FromQuery] CompanionAssistancePackageInputDto dto)
        {
            var search = _companionAssistancePackageService.Search(dto);
            return Ok(search);
        }
    }
}
