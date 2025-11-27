using Application.Common.Dto.Input;
using Application.Services.CompanionSrvs.CompanionUserSrv.Iface;

namespace Application.Services.CompanionSrvs.CompanionUserSrv.Dto
{
    public class CompanionUserInputDto : BaseInputDto, ICompanionUserSearchFields
    {
        public long? CompanionId { get; set; }
        public long? UserId { get; set; }
        public bool? UserAccept { get; set; }
        public bool? Active { get; set; }
        public bool AllUserAccept { get; set; }

    }
}
