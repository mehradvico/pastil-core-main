using Application.Common.Dto.Field;
using Application.Services.CompanionSrvs.AssistanceQuestionnaireSrv.Dto;

namespace Application.Services.CompanionSrvs.CompanionReserveCommentRateSrv.Dto
{
    public class CompanionReserveCommentRateVDto : Id_FieldDto
    {
        public int Rate { get; set; }
        public long AssistanceQuestionnaireId { get; set; }
        public long CompanionReserveCommentId { get; set; }
        public AssistanceQuestionnaireVDto AssistanceQuestionnaire { get; set; }
    }
}
