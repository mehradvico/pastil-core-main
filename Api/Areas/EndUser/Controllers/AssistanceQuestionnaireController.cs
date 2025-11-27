using Application.Services.CompanionSrvs.AssistanceQuestionnaireSrv.Dto;
using Application.Services.CompanionSrvs.AssistanceQuestionnaireSrv.Iface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Areas.EndUser.Controllers
{
    /// <summary>
    /// مدیریت  خدمات
    /// </summary>
    /// 
    [Area("EndUser")]
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Authorize]
    public class AssistanceQuestionnaireController : ControllerBase
    {
        private readonly IAssistanceQuestionnaireService _AssistanceQuestionnaireService;
        public AssistanceQuestionnaireController(IAssistanceQuestionnaireService AssistanceQuestionnaireService)
        {
            this._AssistanceQuestionnaireService = AssistanceQuestionnaireService;
        }

        /// <summary>
        ///  جستجو
        /// </summary>
        /// <returns></returns> 
        [HttpGet()]
        [ProducesResponseType(typeof(AssistanceQuestionnaireSearchDto), 200)]
        public IActionResult Get([FromQuery] AssistanceQuestionnaireInputDto dto)
        {
            var search = _AssistanceQuestionnaireService.Search(dto);
            return Ok(search);
        }
    }
}
