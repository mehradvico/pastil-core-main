using Application.Services.CompanionSrvs.CompanionInsurancePackageSaleSrv.Dto;
using Application.Services.CompanionSrvs.CompanionInsurancePackageSaleSrv.Iface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Areas.Companion.Controllers
{
    /// <summary>
    ///  پرداخت دستی بیمه ها
    /// </summary>
    ///
    [Area("Companion")]
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Authorize]
    public class CompanionInsuranceManualPayController : ControllerBase
    {
        private ICompanionInsurancePackageSaleService _tripService;
        public CompanionInsuranceManualPayController(ICompanionInsurancePackageSaleService tripService)
        {
            _tripService = tripService;
        }
        /// <summary>
        ///  پرداخت دستی بیمه ها
        /// </summary>
        /// 
        [HttpPut]
        [ProducesResponseType(typeof(CompanionInsurancePackageSaleManualPayDto), 200)]
        public async Task<IActionResult> Put(CompanionInsurancePackageSaleManualPayDto dto)
        {
            var result = await _tripService.CompanionInsurancePackageSaleManualPayAsync(dto);
            return Ok(result);
        }
    }
}
