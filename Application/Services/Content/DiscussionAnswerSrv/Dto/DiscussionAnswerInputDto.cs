using Application.Common.Dto.Input;
using Application.Services.Content.DiscussionAnswerSrv.Iface;

namespace Application.Services.Content.DiscussionAnswerSrv.Dto
{
    public class DiscussionAnswerInputDto : BaseInputDto, IDiscussionAnswerSearchFields
    {
        public long? UserId { get; set; }
        public long? DiscussionQuestionId { get; set; }
    }
}
