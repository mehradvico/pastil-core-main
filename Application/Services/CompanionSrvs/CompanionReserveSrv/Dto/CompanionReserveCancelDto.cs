using Application.Common.Dto.Field;

namespace Application.Services.CompanionSrvs.CompanionReserveSrv.Dto
{
    public class CompanionReserveCancelDto : Id_FieldDto
    {
        public bool IsCancel { get; set; }
        public string CancelDetail { get; set; }
    }
}
