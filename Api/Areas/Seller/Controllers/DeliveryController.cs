using Application.Common.Dto.Input;
using Application.Common.Dto.Result;
using Application.Common.Helpers;
using Application.Common.Interface;
using Application.Services.Order.DeliverySrv.Dto;
using Application.Services.Order.DeliverySrv.iface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Areas.Seller.Controllers
{
    /// <summary>
    /// مدیریت حمل و نقل
    /// </summary>
    ///
    [Area("Seller")]
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Authorize]
    public class DeliveryController : ControllerBase
    {
        private IDeliveryService DeliveryService;
        private readonly ICurrentUserHelper _currentUser;

        /// <summary>
        /// مدیریت حمل و نقل
        /// </summary>
        ///
        public DeliveryController(IDeliveryService DeliveryService, ICurrentUserHelper currentUser)
        {
            this.DeliveryService = DeliveryService;
            this._currentUser = currentUser;
        }
        /// <summary>
        ///  اطلاعات آیتم 
        /// </summary>
        /// <param name="id">شناسه</param>
        /// <returns>
        /// </returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(BaseResultDto<DeliveryDto>), 200)]
        public async Task<IActionResult> Get(long id)
        {
            var role = await DeliveryService.FindAsyncDto(id);
            return Ok(role);
        }
        /// <summary>
        ///  جستجو
        /// </summary>
        /// <returns></returns> 

        [HttpGet]
        [ProducesResponseType(typeof(BaseInputDto), 200)]
        public IActionResult Get([FromQuery] DeliveryInputDto dto)
        {
            dto.StoreId = _currentUser.CurrentUser.StoreId;
            var searchDto = DeliveryService.Search(dto);
            return Ok(searchDto);
        }
        /// <summary>
        /// آیتم جدید
        /// </summary>  
        [HttpPost]
        [ProducesResponseType(typeof(BaseResultDto<DeliveryDto>), 200)]
        public async Task<IActionResult> Post(DeliveryDto deliveryDto)
        {
            deliveryDto.StoreId = _currentUser.CurrentUser.StoreId;
            var dto = await DeliveryService.InsertAsyncDto(deliveryDto);
            return Ok(dto);
        }
        /// <summary>
        /// ویرایش آیتم
        /// </summary>

        [HttpPut]
        [ProducesResponseType(typeof(BaseResultDto), 200)]
        public IActionResult Put(DeliveryDto DeliveryDto)
        {
            DeliveryDto.StoreId = _currentUser.CurrentUser.StoreId;
            var dto = DeliveryService.UpdateDto(DeliveryDto);
            return Ok(dto);
        }
        /// <summary>
        /// حذف آیتم
        /// </summary>
        ///
        [HttpDelete]
        [ProducesResponseType(typeof(BaseResultDto), 200)]
        public IActionResult Delete(long id)
        {
            var dto = DeliveryService.DeleteDto(id);
            return Ok(dto);
        }
    }
}
