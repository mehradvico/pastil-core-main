using Application.Common.Dto.Result;
using Application.Common.Interface;
using Application.Services.Accounting.UserPerRecordSrv.Dto;
using Application.Services.Accounting.UserPerRecordSrv.Iface;
using Application.Services.Accounting.UserPetSrv;
using Application.Services.Accounting.UserPetSrv.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    /// <summary>
    /// مدیریت تاریخچه پت ها
    /// </summary>
    ///
    [Route("api/[controller]")]
    [ApiController]
    public class UserPetRecordController : ControllerBase
    {
        private IUserPetRecordService _petService;
        /// <summary>
        /// مدیریت تاریخچه پت ها
        /// </summary>
        ///
        public UserPetRecordController(IUserPetRecordService petService)
        {
            _petService = petService;
        }
        /// <summary>
        ///  اطلاعات پت 
        /// </summary>
        /// <param name="id">شناسه</param>
        /// <returns>
        /// </returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(BaseResultDto<UserPetRecordDto>), 200)]
        public async Task<IActionResult> Get(long id)
        {
            var role = await _petService.FindAsyncDto(id);
            return Ok(role);
        }
        /// <summary>
        ///  جستجو
        /// </summary>
        /// <returns></returns> 

        [HttpGet]
        [ProducesResponseType(typeof(UserPetRecordInputDto), 200)]
        public IActionResult Get([FromQuery] UserPetRecordInputDto dto)
        {
            var searchDto = _petService.Search(dto);
            return Ok(searchDto);
        }
    }
}
