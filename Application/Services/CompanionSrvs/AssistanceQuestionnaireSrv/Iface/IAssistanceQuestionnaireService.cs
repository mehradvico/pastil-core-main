using Application.Common.Dto.Result;
using Application.Common.Interface;
using Application.Services.CompanionSrvs.AssistanceQuestionnaireSrv.Dto;
using Entities.Entities;
using System.Threading.Tasks;

namespace Application.Services.CompanionSrvs.AssistanceQuestionnaireSrv.Iface
{
    public interface IAssistanceQuestionnaireService : ICommonSrv<AssistanceQuestionnaire, AssistanceQuestionnaireDto>
    {
        AssistanceQuestionnaireSearchDto Search(AssistanceQuestionnaireInputDto baseSearchDto);
        Task<BaseResultDto<AssistanceQuestionnaireVDto>> FindAsyncVDto(long id);

    }
}
