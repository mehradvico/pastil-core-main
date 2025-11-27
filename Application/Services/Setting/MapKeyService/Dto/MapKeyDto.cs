using Application.Common.Dto.Field;

namespace Application.Services.Setting.MapKeyService.Dto
{
    public class MapKeyDto : Id_FieldDto
    {
        public long TypeId { get; set; }
        public string Key { get; set; }
        public bool Active { get; set; }
    }
}
