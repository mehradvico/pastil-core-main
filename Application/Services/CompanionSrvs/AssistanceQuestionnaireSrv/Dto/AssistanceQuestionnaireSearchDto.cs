using Application.Common.Dto.Result;
using Application.Services.CompanionSrvs.AssistanceQuestionnaireSrv.Iface;
using AutoMapper;
using Entities.Entities;
using System.Linq;

namespace Application.Services.CompanionSrvs.AssistanceQuestionnaireSrv.Dto
{
    public class AssistanceQuestionnaireSearchDto : BaseSearchDto<AssistanceQuestionnaire, AssistanceQuestionnaireVDto>, IAssistanceQuestionnaireSearchFields
    {
        public AssistanceQuestionnaireSearchDto(AssistanceQuestionnaireInputDto dto, IQueryable<AssistanceQuestionnaire> list, IMapper mapper) : base(dto, list, mapper)
        {
            this.AssistanceId = dto.AssistanceId;
        }
        public long? AssistanceId { get; set; }

    }
}
