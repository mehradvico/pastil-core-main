using Application.Common.Dto.Input;
using Application.Services.CompanionSrvs.AssistanceQuestionnaireSrv.Iface;

namespace Application.Services.CompanionSrvs.AssistanceQuestionnaireSrv.Dto
{
    public class AssistanceQuestionnaireInputDto : BaseInputDto, IAssistanceQuestionnaireSearchFields
    {
        public long? AssistanceId { get; set; }
    }
}
