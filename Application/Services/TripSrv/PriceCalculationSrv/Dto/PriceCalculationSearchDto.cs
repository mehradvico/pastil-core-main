using Application.Common.Dto.Result;
using Application.Services.TripSrv.PriceCalculationSrv.Iface;
using AutoMapper;
using Entities.Entities;
using System.Linq;

namespace Application.Services.TripSrv.PriceCalculationSrv.Dto
{
    public class PriceCalculationSearchDto : BaseSearchDto<PriceCalculation, PriceCalculationVDto>, IPriceCalculationSearchFields
    {
        public PriceCalculationSearchDto(PriceCalculationInputDto dto, IQueryable<PriceCalculation> list, IMapper mapper) : base(dto, list, mapper)
        {
        }
    }
}
