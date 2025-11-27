using Application.Common.Dto.Field;

namespace Application.Services.Content.DiscussionAnswerSrv.Dto
{
    public class DiscussionAnswerDto : Id_FieldDto
    {
        public string Content { get; set; }
        public long DiscussionQuestionId { get; set; }
        public long UserId { get; set; }
        public bool Active { get; set; }
    }
}
