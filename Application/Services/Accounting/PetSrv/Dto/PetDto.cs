using Application.Common.Dto.Field;

namespace Application.Services.Accounting.PetSrv.Dto
{
    public class PetDto : Name_FieldDto
    {
        public bool Active { get; set; }
        public int Priority { get; set; }
    }
}
