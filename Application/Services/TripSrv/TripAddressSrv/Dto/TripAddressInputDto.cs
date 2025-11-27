using Application.Common.Dto.Input;
using Application.Services.TripSrv.PriceCalculationSrv.Iface;
using Application.Services.TripSrv.TripAddressSrv.Iface;

namespace Application.Services.TripSrv.PriceCalculationSrv.Dto
{
    public class TripAddressInputDto : BaseInputDto, ITripAddressSearchFields
    {
        public long? UserId { get; set; }
    }
}
