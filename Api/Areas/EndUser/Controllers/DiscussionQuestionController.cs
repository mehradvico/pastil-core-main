using Application.Common.Dto.Result;
using Application.Common.Interface;
using Application.Services.Content.DiscussionQuestionSrv.Dto;
using Application.Services.Content.DiscussionQuestionSrv.Iface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Areas.EndUser.Controllers
{
    /// <summary>
    /// مدیریت موضوع های گفت و گو
    /// </summary>
    ///
    [Area("EndUser")]
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Authorize]
    public class DiscussionQuestionController : ControllerBase
    {
        private readonly ICurrentUserHelper _currentUserHelper;
        private IDiscussionQuestionService _DiscussionQuestionService;
        /// <summary>
        /// مدیریت موضوع گفت و گو
        /// </summary>
        ///
        public DiscussionQuestionController(IDiscussionQuestionService DiscussionQuestionService, ICurrentUserHelper currentUserHelper)
        {
            _DiscussionQuestionService = DiscussionQuestionService;
            _currentUserHelper = currentUserHelper;
        }
        /// <summary>
        ///  اطلاعات آیتم 
        /// </summary>
        /// <param name="id">شناسه</param>
        /// <returns>
        /// </returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(BaseResultDto<DiscussionQuestionDto>), 200)]
        public async Task<IActionResult> Get(long id)
        {

            var dto = await _DiscussionQuestionService.FindAsyncDto(id);
            return Ok(dto);
        }
        /// <summary>
        ///  جستجو
        /// </summary>
        /// <returns></returns> 

        [HttpGet]
        [ProducesResponseType(typeof(DiscussionQuestionInputDto), 200)]
        public IActionResult Get([FromQuery] DiscussionQuestionInputDto dto)
        {
            var searchDto = _DiscussionQuestionService.Search(dto);
            return Ok(searchDto);
        }
        /// <summary>
        /// آیتم جدید
        /// </summary>  
        [HttpPost]
        [ProducesResponseType(typeof(BaseResultDto<DiscussionQuestionDto>), 200)]
        public async Task<IActionResult> Post(DiscussionQuestionDto DiscussionQuestionDto)
        {
            DiscussionQuestionDto.UserId = _currentUserHelper.CurrentUser.UserId;
            var dto = await _DiscussionQuestionService.InsertAsyncDto(DiscussionQuestionDto);
            return Ok(dto);
        }
    }
}
