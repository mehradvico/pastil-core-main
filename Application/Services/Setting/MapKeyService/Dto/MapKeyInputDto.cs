using Application.Common.Dto.Input;
using Application.Services.Setting.MapKeyService.Iface;

namespace Application.Services.Setting.MapKeyService.Dto
{
    public class MapKeyInputDto : BaseInputDto, IMapKeySearchFields
    {
        public long? TypeId { get; set; }
    }
}
