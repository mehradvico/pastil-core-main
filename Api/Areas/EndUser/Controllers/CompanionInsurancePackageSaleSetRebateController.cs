using Application.Common.Dto.Result;
using Application.Services.CompanionSrvs.CompanionInsurancePackageSaleSrv.Dto;
using Application.Services.CompanionSrvs.CompanionInsurancePackageSaleSrv.Iface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Areas.EndUser.Controllers
{
    /// <summary>
    /// مدیریت افزودن تخفیف بیمه
    /// </summary>
    /// 
    [Area("EndUser")]
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Authorize]
    public class CompanionInsurancePackageSaleSetRebateController : ControllerBase
    {
        private readonly ICompanionInsurancePackageSaleService _companionInsurancePackageSaleService;
        public CompanionInsurancePackageSaleSetRebateController(ICompanionInsurancePackageSaleService companionInsurancePackageSaleService)
        {
            _companionInsurancePackageSaleService = companionInsurancePackageSaleService;
        }

        /// <summary>
        ///  ویرایش آیتم 
        /// </summary>
        /// <returns>
        /// </returns>
        [HttpPut]
        [ProducesResponseType(typeof(BaseResultDto), 200)]
        public async Task<IActionResult> Put(CompanionInsurancePackageSaleSetRebateCodeDto dto)
        {
            var companion = await _companionInsurancePackageSaleService.SetRebateCodeAsyncDto(dto);
            return Ok(companion);
        }
    }
}
