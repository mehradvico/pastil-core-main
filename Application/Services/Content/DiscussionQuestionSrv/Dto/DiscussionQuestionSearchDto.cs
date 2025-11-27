using Application.Common.Dto.Result;
using Application.Services.Content.DiscussionQuestionSrv.Iface;
using AutoMapper;
using Entities.Entities;
using System;
using System.Linq;

namespace Application.Services.Content.DiscussionQuestionSrv.Dto
{
    public class DiscussionQuestionSearchDto : BaseSearchDto<DiscussionQuestion, DiscussionQuestionVDto>, IDiscussionQuestionSearchFields
    {
        public DiscussionQuestionSearchDto(DiscussionQuestionInputDto dto, IQueryable<DiscussionQuestion> list, IMapper mapper) : base(dto, list, mapper)
        {
            this.AdminConfirm = dto.AdminConfirm;
            this.Active = dto.Active;
            this.FromDate = dto.FromDate;
            this.ToDate = dto.ToDate;
            this.ProductId = dto.ProductId;
        }
        public bool? Active { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public bool? AdminConfirm { get; set; }
        public long? ProductId { get; set; }

    }
}
