using Application.Services.CommonSrv.CommentSrv.Dto;
using Application.Services.CompanionSrvs.CompanionReserveCommentRateSrv.Dto;
using System.Collections.Generic;

namespace Application.Services.CompanionSrvs.CompanionReserveCommentSrv.Dto
{
    public class CompanionReserveCommentDto : CommentDto
    {
        public long CompanionReserveId { get; set; }
        public List<CompanionReserveCommentRateDto> CompanionReserveCommentRates { get; set; } = new List<CompanionReserveCommentRateDto>();
    }
}
