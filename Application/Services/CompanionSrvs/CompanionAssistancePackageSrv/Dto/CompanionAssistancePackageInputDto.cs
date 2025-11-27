using Application.Common.Dto.Input;
using Application.Services.CompanionSrv.CompanionAssistancePackageSrv.Iface;

namespace Application.Services.CompanionSrv.CompanionAssistancePackageSrv.Dto
{
    public class CompanionAssistancePackageInputDto : BaseInputDto, ICompanionAssistancePackageSearchFields
    {
        public long? CompanionAssistanceId { get; set; }
    }
}
