using Application.Common.Dto.Result;
using Application.Common.Interface;
using Application.Services.Setting.MapKeyService.Dto;
using Entities.Entities;
using System.Threading.Tasks;

namespace Application.Services.Setting.MapKeyService.Iface
{
    public interface IMapKeyService : ICommonSrv<MapKey, MapKeyDto>
    {
        MapKeySearchDto Search(MapKeyInputDto baseSearchDto);
        Task<BaseResultDto<MapKeyVDto>> FindAsyncVDto(long id);

    }
}
