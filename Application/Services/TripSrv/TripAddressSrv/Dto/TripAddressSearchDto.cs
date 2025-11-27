using Application.Common.Dto.Result;
using Application.Services.TripSrv.PriceCalculationSrv.Iface;
using Application.Services.TripSrv.TripAddressSrv.Iface;
using AutoMapper;
using Entities.Entities;
using System.Linq;

namespace Application.Services.TripSrv.PriceCalculationSrv.Dto
{
    public class TripAddressSearchDto : BaseSearchDto<TripAddress, TripAddressVDto>, ITripAddressSearchFields
    {
        public TripAddressSearchDto(TripAddressInputDto dto, IQueryable<TripAddress> list, IMapper mapper) : base(dto, list, mapper)
        {
            this.UserId = dto.UserId;
        }
        public long? UserId { get; set; }
    }
}
