using Application.Common.Dto.Result;
using Application.Services.CompanionSrvs.CompanionInsurancePackageSaleSrv.Iface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Areas.EndUser.Controllers
{
    /// <summary>
    /// مدیریت حذف تخفیف بیمه
    /// </summary>
    /// 
    [Area("EndUser")]
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Authorize]
    public class CompanionInsurancePackageSaleRemoveRebateController : ControllerBase
    {
        private readonly ICompanionInsurancePackageSaleService _companionInsurancePackageSaleService;
        public CompanionInsurancePackageSaleRemoveRebateController(ICompanionInsurancePackageSaleService companionInsurancePackageSaleService)
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
        public async Task<IActionResult> Put(long id)
        {
            var companion = await _companionInsurancePackageSaleService.ClearRebateCodeAsync(id);
            return Ok(companion);
        }
    }
}
