using Application.Common.Dto.Result;
using Application.Services.CompanionSrvs.CompanionInsurancePackageSaleSrv.Dto;
using Application.Services.CompanionSrvs.CompanionInsurancePackageSaleSrv.Iface;
using Application.Services.Content.CargoSrv.Dto;
using Application.Services.Content.CargoSrv.Iface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Areas.EndUser.Controllers
{
    /// <summary>
    /// مدیریت تغییر وضعیت کیف پول بیمه
    /// </summary>
    /// 
    [Area("EndUser")]
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Authorize]
    public class CompanionInsurancePackageSaleSetWalletController : ControllerBase
    {
        private readonly ICompanionInsurancePackageSaleService _CompanionInsurancePackageSaleService;
        public CompanionInsurancePackageSaleSetWalletController(ICompanionInsurancePackageSaleService CompanionInsurancePackageSaleService)
        {
            _CompanionInsurancePackageSaleService = CompanionInsurancePackageSaleService;
        }

        /// <summary>
        ///  ویرایش آیتم 
        /// </summary>
        /// <returns>
        /// </returns>
        [HttpPut]
        [ProducesResponseType(typeof(BaseResultDto), 200)]
        public async Task<IActionResult> Put(CompanionInsurancePackageSaleSetWalletDto dto)
        {
            var companion = await _CompanionInsurancePackageSaleService.SetWalletAsyncDto(dto);
            return Ok(companion);
        }
    }
}
