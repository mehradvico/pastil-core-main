using Application.Common.Dto.Result;
using Application.Common.Interface;
using Application.Services.PansionSrvs.PansionPetSrv.Dto;
using Application.Services.PansionSrvs.PansionPetSrv.Iface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Areas.Companion.Controllers
{
    /// <summary>
    /// مدیریت پت های پانسیون
    /// </summary>
    /// 
    [Area("Companion")]
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Authorize]
    public class PansionPetController : ControllerBase
    {
        private readonly IPansionPetService _PansionPetService;
        private readonly ICurrentUserHelper _currentUser;
        public PansionPetController(IPansionPetService PansionPetService, ICurrentUserHelper currentUser)
        {
            this._PansionPetService = PansionPetService;
            this._currentUser = currentUser;
        }

        /// <summary>
        ///  جستجو
        /// </summary>
        /// <returns></returns> 
        [HttpGet()]
        [ProducesResponseType(typeof(PansionPetSearchDto), 200)]
        public IActionResult Get([FromQuery] PansionPetInputDto dto)
        {
            dto.CompanionId = _currentUser.CurrentUser.CompanionId;
            var search = _PansionPetService.Search(dto);
            return Ok(search);
        }

        /// <summary>
        ///  اطلاعات آیتم 
        /// </summary>
        /// <param name="id">شناسه خدمات</param>
        /// <returns>
        /// </returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(BaseResultDto<PansionPetDto>), 200)]
        public async Task<IActionResult> Get(long id)
        {
            var agency = await _PansionPetService.FindAsyncDto(id);
            return Ok(agency);
        }

        /// <summary>
        /// آیتم جدید
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(typeof(BaseResultDto<PansionPetDto>), 200)]
        public async Task<IActionResult> Post(PansionPetDto dto)
        {
            var result = await _PansionPetService.InsertAsyncDto(dto);
            return Ok(result);
        }

        /// <summary>
        ///  ویرایش آیتم 
        /// </summary>
        /// <returns>
        /// </returns>
        [HttpPut]
        [ProducesResponseType(typeof(BaseResultDto), 200)]
        public IActionResult Put(PansionPetDto dto)
        {
            var agency = _PansionPetService.UpdateDto(dto);
            return Ok(agency);
        }

        /// <summary>
        ///  حذف آیتم 
        /// </summary>  
        [HttpDelete]
        [ProducesResponseType(typeof(BaseResultDto), 200)]
        public IActionResult Delete(long id)
        {
            var dto = _PansionPetService.DeleteDto(id);
            return Ok(dto);
        }
    }
}
