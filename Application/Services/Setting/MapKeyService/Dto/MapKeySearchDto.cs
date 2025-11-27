using Application.Common.Dto.Result;
using Application.Services.Setting.MapKeyService.Iface;
using AutoMapper;
using Entities.Entities;
using System.Linq;

namespace Application.Services.Setting.MapKeyService.Dto
{
    public class MapKeySearchDto : BaseSearchDto<MapKey, MapKeyVDto>, IMapKeySearchFields
    {
        public MapKeySearchDto(MapKeyInputDto dto, IQueryable<MapKey> list, IMapper mapper) : base(dto, list, mapper)
        {

            this.TypeId = dto.TypeId;
        }

        public long? TypeId { get; set; }
    }
}
