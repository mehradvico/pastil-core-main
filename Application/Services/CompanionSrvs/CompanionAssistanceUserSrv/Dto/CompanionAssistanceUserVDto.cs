using Application.Common.Dto.Field;
using Application.Services.CompanionSrv.CompanionAssistanceSrv.Dto;
using Application.Services.Dto;

namespace Application.Services.CompanionSrv.CompanionAssistanceUserSrv.Dto
{
    public class CompanionAssistanceUserVDto : Id_FieldDto
    {
        public bool Active { get; set; }
        public string ActivationValue { get; set; }
        public long CompanionAssistanceId { get; set; }
        public long UserId { get; set; }
        public UserVDto User { get; set; }
        public CompanionAssistanceVDto CompanionAssistance { get; set; }
    }
}
