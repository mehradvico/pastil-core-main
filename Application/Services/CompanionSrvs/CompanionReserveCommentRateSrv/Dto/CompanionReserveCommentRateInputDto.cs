using Application.Common.Dto.Input;
using Application.Services.CompanionSrvs.CompanionReserveCommentRateSrv.Iface;

namespace Application.Services.CompanionSrvs.CompanionReserveCommentRateSrv.Dto
{
    public class CompanionReserveCommentRateInputDto : BaseInputDto, ICompanionReserveCommentRateSearchFields
    {
        public long? AssistanceQuestionnaireId { get; set; }
        public long? CompanionReserveCommentId { get; set; }
    }
}
