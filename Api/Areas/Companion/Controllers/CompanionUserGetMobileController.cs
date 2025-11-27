using Application.Common.Dto.Result;
using Application.Services.Accounting.UserSrv.Iface;
using Application.Services.CompanionSrvs.CompanionUserSrv.Dto;
using Application.Services.CompanionSrvs.CompanionUserSrv.Iface;
using Application.Services.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Areas.Companion.Controllers
{
    /// <summary>
    /// دریافت تلفن همراه کاربر
    /// </summary>
    /// 
    [Area("Companion")]
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Authorize]
    public class CompanionUserGetMobileController : ControllerBase
    {
        private readonly IUserService _userService;
        /// <summary>
        /// دریافت تلفن همراه کاربر
        /// </summary>

        public CompanionUserGetMobileController(IUserService userService)
        {
            this._userService = userService;
        }
        /// <summary>
        /// اطلاعات آیتم
        /// </summary>
        /// 
        [HttpGet("{mobile}")]
        [ProducesResponseType(typeof(BaseResultDto<UserDto>), 200)]
        public IActionResult Get(string mobile)
        {
            var CompanionUser = _userService.GetUserByMobile(mobile);
            return Ok(CompanionUser);
        }
    }
}
