using Application.Common.Dto.Result;
using Application.Services.Accounting.UserPerRecordSrv.Dto;
using Application.Services.Accounting.UserPerRecordSrv.Iface;
using Application.Services.Accounting.UserPetSrv.Dto;
using Application.Services.Accounting.UserPetSrv.Iface;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    /// <summary>
    /// مدیریت پت های کاربر
    /// </summary>
    ///
    [Route("api/[controller]")]
    [ApiController]
    public class UserPetController : ControllerBase
    {
        private IUserPetService _petService;
        /// <summary>
        /// مدیریت پت های کاربر
        /// </summary>
        ///
        public UserPetController(IUserPetService petService)
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
        [ProducesResponseType(typeof(BaseResultDto<UserPetDto>), 200)]
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
        [ProducesResponseType(typeof(UserPetInputDto), 200)]
        public IActionResult Get([FromQuery] UserPetInputDto dto)
        {
            var searchDto = _petService.Search(dto);
            return Ok(searchDto);
        }
    }
}
