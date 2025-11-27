using Application.Services.CommonSrv.CommentSrv.Dto;
using Application.Services.CompanionSrv.CompanionReserveSrv.Dto;
using Application.Services.CompanionSrvs.CompanionReserveCommentRateSrv.Dto;
using Entities.Entities;
using System.Collections.Generic;

namespace Application.Services.CompanionSrvs.CompanionReserveCommentSrv.Dto
{
    public class CompanionReserveCommentVDto : CommentVDto
    {
        public long CompanionReserveId { get; set; }
        public CompanionReserveVDto CompanionReserve { get; set; }

        public List<CompanionReserveCommentRateVDto> CompanionReserveCommentRates { get; set; }

    }
}
