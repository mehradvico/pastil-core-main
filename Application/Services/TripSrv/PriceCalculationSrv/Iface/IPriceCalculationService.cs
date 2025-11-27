using Application.Common.Dto.Result;
using Application.Common.Interface;
using Application.Services.TripSrv.PriceCalculationSrv.Dto;
using Application.Services.TripSrv.TripSrv.Dto;
using Entities.Entities;
using System.Threading.Tasks;

namespace Application.Services.TripSrv.PriceCalculationSrv.Iface
{
    public interface IPriceCalculationService : ICommonSrv<PriceCalculation, PriceCalculationDto>
    {
        PriceCalculationSearchDto Search(PriceCalculationInputDto baseSearchDto);
        Task<BaseResultDto<PriceCalculationVDto>> FindAsyncVDto(long id);
        Task<PriceCalculationVDto> GetForNow();
        Task<double> CalculateTripPrice(TripDto tripDto);

    }
}
