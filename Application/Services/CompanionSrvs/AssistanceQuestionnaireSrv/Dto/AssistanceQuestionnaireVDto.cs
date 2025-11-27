using Application.Common.Dto.Field;
using Application.Services.CompanionSrvs.AssistanceSrv.Dto;

namespace Application.Services.CompanionSrvs.AssistanceQuestionnaireSrv.Dto
{
    public class AssistanceQuestionnaireVDto : Name_FieldDto
    {
        public int Priority { get; set; }
        public bool Active { get; set; }
        public long AssistanceId { get; set; }
        public AssistanceVDto Assistance { get; set; }
    }
}
