using Application.Services.CommonSrv.PushBroadcastSrv.Dto;
using Application.Services.CommonSrv.PushBroadcastSrv.Iface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Authorize]
    public class PushAdminController : ControllerBase
    {
        private readonly IPushBroadcastService _broadcast;

        public PushAdminController(IPushBroadcastService broadcast)
        {
            _broadcast = broadcast;
        }

        [HttpPost]
        public async Task<IActionResult> Broadcast([FromBody] PushBroadcastDto dto)
        {
            var res = await _broadcast.BroadcastAsync(dto);
            return Ok(res);
        }
    }
}
