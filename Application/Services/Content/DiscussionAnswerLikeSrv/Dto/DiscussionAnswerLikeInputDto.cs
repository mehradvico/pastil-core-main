using Application.Common.Dto.Input;
using Application.Services.Content.DiscussionAnswerLikeSrv.Iface;

namespace Application.Services.Content.DiscussionAnswerLikeSrv.Dto
{
    public class DiscussionAnswerLikeInputDto : BaseInputDto, IDiscussionAnswerLikeSearchFields
    {
        public long? DiscussionAnswerId { get; set; }
    }
}
