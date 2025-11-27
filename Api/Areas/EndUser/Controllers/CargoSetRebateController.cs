using Application.Common.Dto.Result;
using Application.Services.Content.CargoSrv;
using Application.Services.Content.CargoSrv.Dto;
using Application.Services.Content.CargoSrv.Iface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Areas.EndUser.Controllers
{
    /// <summary>
    /// مدیریت افزودن تخفیف کارگو
    /// </summary>
    /// 
    [Area("EndUser")]
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Authorize]
    public class CargoSetRebateController : ControllerBase
    {
        private readonly ICargoService _cargoService;
        public CargoSetRebateController(ICargoService cargoService)
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
        public async Task<IActionResult> Put(CargoSetRebateCodeDto dto)
        {
            var companion = await _cargoService.SetRebateCodeAsyncDto(dto);
            return Ok(companion);
        }
    }
}
