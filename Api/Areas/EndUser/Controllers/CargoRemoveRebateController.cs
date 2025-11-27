using Application.Common.Dto.Result;
using Application.Services.Content.CargoSrv.Iface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Areas.EndUser.Controllers
{
    /// <summary>
    /// مدیریت حذف تخفیف کارگو
    /// </summary>
    /// 
    [Area("EndUser")]
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Authorize]
    public class CargoRemoveRebateController : ControllerBase
    {
        private readonly ICargoService _cargoService;
        public CargoRemoveRebateController(ICargoService cargoService)
        {
            _cargoService = cargoService;
        }

        /// <summary>
        ///  ویرایش آیتم 
        /// </summary>
        /// <returns>
        /// </returns>
        [HttpPut]
        [ProducesResponseType(typeof(BaseResultDto), 200)]
        public async Task<IActionResult> Put(long id)
        {
            var companion = await _cargoService.ClearRebateCodeAsync(id);
            return Ok(companion);
        }
    }
}
