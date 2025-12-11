using Application.Common.Dto.Result;
using Application.Services.Setting.PushMessageSrv.Dto;
using Application.Services.Setting.PushMessageSrv.Iface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Areas.Public.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribeController : ControllerBase
    {
        private readonly IPushService _pushService;

        public SubscribeController(IPushService pushService)
        {
            _pushService = pushService;
        }

        /// <summary>
        /// ذخیره اشتراک Push Notification
        /// </summary>
        [HttpPost("register")]
        [ProducesResponseType(typeof(BaseResultDto), 200)]
        public async Task<IActionResult> Register([FromBody] PushSubscriptionDto dto)
        {
            await _pushService.RegisterAsync(dto);
            return Ok(dto);
        }
    }
}
