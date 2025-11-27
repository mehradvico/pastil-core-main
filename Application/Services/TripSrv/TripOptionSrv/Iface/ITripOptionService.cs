using Application.Common.Dto.Result;
using Application.Common.Interface;
using Application.Services.TripSrv.TripOptionSrv.Dto;
using Entities.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Services.TripSrv.TripOptionSrv.Iface
{
    public interface ITripOptionService : ICommonSrv<TripOption, TripOptionDto>
    {
        TripOptionSearchDto Search(TripOptionInputDto baseSearchDto);
        Task<BaseResultDto<TripOptionVDto>> FindAsyncVDto(long id);
        Task<List<TripOption>> GetListAsync(List<long> Ids);
    }
}
