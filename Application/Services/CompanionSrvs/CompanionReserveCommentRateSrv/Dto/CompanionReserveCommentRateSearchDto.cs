using Application.Common.Dto.Result;
using Application.Services.CompanionSrvs.CompanionReserveCommentRateSrv.Iface;
using AutoMapper;
using Entities.Entities;
using System.Linq;

namespace Application.Services.CompanionSrvs.CompanionReserveCommentRateSrv.Dto
{
    public class CompanionReserveCommentRateSearchDto : BaseSearchDto<CompanionReserveCommentRate, CompanionReserveCommentRateVDto>, ICompanionReserveCommentRateSearchFields
    {
        public CompanionReserveCommentRateSearchDto(CompanionReserveCommentRateInputDto dto, IQueryable<CompanionReserveCommentRate> list, IMapper mapper) : base(dto, list, mapper)
        {
            this.AssistanceQuestionnaireId = dto.AssistanceQuestionnaireId;
            this.CompanionReserveCommentId = dto.CompanionReserveCommentId;
        }
        public long? AssistanceQuestionnaireId { get; set; }
        public long? CompanionReserveCommentId { get; set; }
    }
}
