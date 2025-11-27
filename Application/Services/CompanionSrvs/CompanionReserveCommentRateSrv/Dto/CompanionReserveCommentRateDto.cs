using Application.Common.Dto.Field;

namespace Application.Services.CompanionSrvs.CompanionReserveCommentRateSrv.Dto
{
    public class CompanionReserveCommentRateDto : Id_FieldDto
    {
        public int Rate { get; set; }
        public long AssistanceQuestionnaireId { get; set; }
        public long CompanionReserveCommentId { get; set; }
    }
}
