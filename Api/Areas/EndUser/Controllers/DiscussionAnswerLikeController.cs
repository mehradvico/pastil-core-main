using Application.Common.Dto.Result;
using Application.Common.Interface;
using Application.Services.Content.DiscussionAnswerLikeSrv.Dto;
using Application.Services.Content.DiscussionAnswerLikeSrv.Iface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Areas.EndUser.Controllers
{
    /// <summary>
    /// مرتبط با لایک پاسخ ها
    /// </summary>
    /// 
    [Area("EndUser")]
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Authorize]
    public class DiscussionAnswerLikeController : ControllerBase
    {
        private readonly IDiscussionAnswerLikeService _DiscussionAnswerLikeService;
        private readonly ICurrentUserHelper _currentUser;
        /// <summary>
        /// مرتبط با لایک پاسخ ها
        /// </summary>
        ///
        public DiscussionAnswerLikeController(IDiscussionAnswerLikeService DiscussionAnswerLikeService, ICurrentUserHelper currentUser)
        {
            this._DiscussionAnswerLikeService = DiscussionAnswerLikeService;
            this._currentUser = currentUser;
        }

        /// <summary>
        /// آیتم جدید
        /// </summary>  
        [HttpPost]
        [ProducesResponseType(typeof(BaseResultDto<DiscussionAnswerLikeDto>), 200)]
        public async Task<IActionResult> Post(DiscussionAnswerLikeInsertDeleteDto DiscussionAnswerlike)
        {
            var dto = await _DiscussionAnswerLikeService.InsertOrDeleteAsync(DiscussionAnswerlike);
            return Ok(dto);
        }
    }
}
