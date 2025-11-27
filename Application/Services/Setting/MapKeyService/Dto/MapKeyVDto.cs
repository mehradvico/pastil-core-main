using Application.Services.Setting.CodeSrv.Dto;
using Entities.Entities.CommonField;

namespace Application.Services.Setting.MapKeyService.Dto
{
    public class MapKeyVDto : Id_Field
    {
        public long TypeId { get; set; }
        public string Key { get; set; }
        public bool Active { get; set; }
        public CodeVDto Type { get; set; }
    }
}
