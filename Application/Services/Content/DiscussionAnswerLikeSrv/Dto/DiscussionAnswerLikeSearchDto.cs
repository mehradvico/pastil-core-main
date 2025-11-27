using Application.Common.Dto.Result;
using Application.Services.Content.DiscussionAnswerLikeSrv.Iface;
using Application.Services.Content.DiscussionAnswerSrv.Dto;
using AutoMapper;
using Entities.Entities;
using System.Linq;

namespace Application.Services.Content.DiscussionAnswerLikeSrv.Dto
{
    public class DiscussionAnswerLikeSearchDto : BaseSearchDto<DiscussionAnswer, DiscussionAnswerVDto>, IDiscussionAnswerLikeSearchFields
    {
        public DiscussionAnswerLikeSearchDto(DiscussionAnswerLikeInputDto dto, IQueryable<DiscussionAnswer> list, IMapper mapper) : base(dto, list, mapper)
        {
            DiscussionAnswerId = dto.DiscussionAnswerId;
        }

        public long? DiscussionAnswerId { get; set; }
    }
}
