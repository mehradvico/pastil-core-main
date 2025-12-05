using Application.Common.Dto.Result;
using Application.Services.CompanionSrvs.CompanionCommentSrv.Iface;
using AutoMapper;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CompanionSrvs.CompanionCommentSrv.Dto
{
    public class CompanionCommentSearchDto : BaseSearchDto<CompanionComment, CompanionCommentVDto>, ICompanionCommentSearchFields
    {
        public CompanionCommentSearchDto(CompanionCommentInputDto dto, IQueryable<CompanionComment> list, IMapper mapper) : base(dto, list, mapper)
        {
            this.CompanionId = dto.CompanionId;
            this.AllStatus = dto.AllStatus;
        }
        public long? CompanionId { get; set; }
        public bool? AllStatus { get; set; }

    }
}
