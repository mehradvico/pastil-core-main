using Application.Common.Enumerable;
using Application.Services.Accounting.PetSrv.Dto;
using Application.Services.Accounting.PetSrv.Iface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    /// <summary>
    /// مدیریت پت ها
    /// </summary>
    ///
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class PetController : ControllerBase
    {
        private IPetService _petService;
        /// <summary>
        /// مدیریت پت ها
        /// </summary>
        ///
        public PetController(IPetService petService)
        {
            _petService = petService;
        }

        /// <summary>
        ///  جستجو
        /// </summary>
        /// <returns></returns> 

        [HttpGet]
        [CustomOutputCache(CacheTypeEnum.PetSearch)]
        [ProducesResponseType(typeof(PetInputDto), 200)]
        public IActionResult Get([FromQuery] PetInputDto dto)
        {
            dto.Available = true;
            var searchDto = _petService.Search(dto);
            return Ok(searchDto);
        }

    }
}
