using Application.Common.Dto.Result;
using Application.Services.Content.PostCommentSrv.Dto;
using Application.Services.Content.PostCommentSrv.Iface;
using Application.Services.PansionSrvs.PansionCommentSrv.Iface;
using AutoMapper;
using Entities.Entities;
using Entities.Entities.PansionField;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.PansionSrvs.PansionCommentSrv.Dto
{
    public class PansionCommentSearchDto : BaseSearchDto<PansionComment, PansionCommentVDto>, IPansionCommentSearchFields
    {
        public PansionCommentSearchDto(PansionCommentInputDto dto, IQueryable<PansionComment> list, IMapper mapper) : base(dto, list, mapper)
        {
            this.PansionId = dto.PansionId;
            this.IsReserved = dto.IsReserved;
            this.UserId = dto.UserId;
            this.AllStatus = dto.AllStatus;
        }
        public long? PansionId { get; set; }
        public bool? IsReserved { get; set; }
        public long? UserId { get; set; }
        public bool? AllStatus { get; set; }

    }
}
