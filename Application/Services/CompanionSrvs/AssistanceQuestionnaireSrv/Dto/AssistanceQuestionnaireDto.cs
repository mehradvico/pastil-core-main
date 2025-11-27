using Application.Common.Dto.Field;

namespace Application.Services.CompanionSrvs.AssistanceQuestionnaireSrv.Dto
{
    public class AssistanceQuestionnaireDto : Name_FieldDto
    {
        public int Priority { get; set; }
        public bool Active { get; set; }
        public long AssistanceId { get; set; }
    }
}
