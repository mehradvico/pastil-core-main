using Application.Common.Enumerable;
using Application.Services.Content.StoryGroupSrv.Dto;
using Application.Services.Content.StoryGroupSrv.Iface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    /// <summary>
    /// مرتبط با استوری ها
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class StoryGroupController : ControllerBase
    {
        private IStoryGroupService StoryGroupService;
        public StoryGroupController(IStoryGroupService StoryGroupService)
        {
            this.StoryGroupService = StoryGroupService;
        }


        /// <summary>
        /// جستجو
        /// </summary>
        [HttpGet]
        [CustomOutputCache(CacheTypeEnum.StoryGroupSearch)]
        [ProducesResponseType(typeof(StoryGroupSearchDto), 200)]
        public IActionResult Get([FromQuery] StoryGroupInputDto dto)
        {
            dto.Available = true;
            var post = StoryGroupService.Search(dto);
            return Ok(post);
        }
    }
}
