using Application.Common.Dto.Result;
using Application.Common.Interface;
using Application.Services.TripSrv.TripStopSrv.Dto;
using Entities.Entities;
using System.Threading.Tasks;

namespace Application.Services.TripSrv.TripStopSrv.Iface
{
    public interface ITripStopService : ICommonSrv<TripStop, TripStopDto>
    {
        TripStopSearchDto Search(TripStopInputDto baseSearchDto);
        Task<BaseResultDto<TripStopVDto>> FindAsyncVDto(long id);
        Task<TripStop> FindAsync(long id);
    }
}
