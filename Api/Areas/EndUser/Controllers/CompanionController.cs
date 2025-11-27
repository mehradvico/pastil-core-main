using Application.Common.Dto.Result;
using Application.Services.CompanionSrvs.CompanionSrv.Dto;
using Application.Services.CompanionSrvs.CompanionSrv.Iface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Areas.EndUser.Controllers
{
    /// <summary>
    /// مدیریت همکاران
    /// </summary>
    /// 
    [Area("EndUser")]
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Authorize]
    public class CompanionController : ControllerBase
    {
        private readonly ICompanionService _companionService;
        public CompanionController(ICompanionService companionService)
        {
            this._companionService = companionService;
        }


        /// <summary>
        /// جستجو
        /// </summary>
        /// <returns></returns> 
        [HttpGet()]
        [ProducesResponseType(typeof(CompanionSearchDto), 200)]
        public IActionResult Get([FromQuery] CompanionInputDto dto)
        {
            var search = _companionService.Search(dto);
            return Ok(search);
        }


        /// <summary>
        /// اطلاعات آیتم 
        /// </summary>
        /// <param name="id">شناسه همکار</param>
        /// <returns>
        /// </returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(BaseResultDto<CompanionVDto>), 200)]
        public async Task<IActionResult> Get(long id)
        {
            var companion = await _companionService.FindAsyncVDto(id);
            return Ok(companion);
        }
    }
}
