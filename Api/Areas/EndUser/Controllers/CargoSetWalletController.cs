using Application.Common.Dto.Result;
using Application.Services.Content.CargoSrv.Dto;
using Application.Services.Content.CargoSrv.Iface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Areas.EndUser.Controllers
{
    /// <summary>
    /// مدیریت تغییر وضعیت کیف پول کارگو
    /// </summary>
    /// 
    [Area("EndUser")]
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Authorize]
    public class CargoSetWalletController : ControllerBase
    {
        private readonly ICargoService _cargoService;
        public CargoSetWalletController(ICargoService cargoService)
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
        public async Task<IActionResult> Put(CargoSetWalletDto dto)
        {
            var companion = await _cargoService.SetWalletAsyncDto(dto);
            return Ok(companion);
        }
    }
}
