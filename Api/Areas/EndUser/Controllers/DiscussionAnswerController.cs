using Application.Common.Dto.Result;
using Application.Common.Interface;
using Application.Services.Content.DiscussionAnswerSrv.Dto;
using Application.Services.Content.DiscussionAnswerSrv.Iface;
using Application.Services.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Areas.EndUser.Controllers
{
    /// <summary>
    /// مدیریت پاسخ های گفت و گو
    /// </summary>
    ///
    [Area("EndUser")]
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Authorize]
    public class DiscussionAnswerController : ControllerBase
    {
        private readonly CurrentUserDto _currentUser;
        private IDiscussionAnswerService _discussionAnswerService;
        /// <summary>
        /// مدیریت پاسخ گفت و گو
        /// </summary>
        ///
        public DiscussionAnswerController(IDiscussionAnswerService discussionAnswerService, ICurrentUserHelper currentUserHelper)
        {
            _discussionAnswerService = discussionAnswerService;
            _currentUser = currentUserHelper.CurrentUser;
        }
        /// <summary>
        /// آیتم جدید
        /// </summary>  
        [HttpPost]
        [ProducesResponseType(typeof(BaseResultDto<DiscussionAnswerDto>), 200)]
        public async Task<IActionResult> Post(DiscussionAnswerDto discussionAnswerDto)
        {
            discussionAnswerDto.UserId = _currentUser.UserId;
            var dto = await _discussionAnswerService.InsertAsyncDto(discussionAnswerDto);
            return Ok(dto);
        }

        /// <summary>
        ///  جستجو
        /// </summary>
        /// <returns></returns> 

        [HttpGet]
        [AllowAnonymous]
        [ProducesResponseType(typeof(DiscussionAnswerInputDto), 200)]
        public IActionResult Get([FromQuery] DiscussionAnswerInputDto dto)
        {
            dto.Available = true;
            if (_currentUser != null)
            {
                dto.UserId = _currentUser.UserId;
            }
            var searchDto = _discussionAnswerService.Search(dto);
            return Ok(searchDto);
        }
    }
}
