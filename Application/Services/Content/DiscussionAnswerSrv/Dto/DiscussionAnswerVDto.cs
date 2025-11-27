using Application.Common.Dto.Field;
using Application.Services.Dto;
using System;

namespace Application.Services.Content.DiscussionAnswerSrv.Dto
{
    public class DiscussionAnswerVDto : Id_FieldDto
    {
        public string Content { get; set; }
        public long DiscussionQuestionId { get; set; }
        public long UserId { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Active { get; set; }
        public int LikeCount { get; set; }
        public int DisLikeCount { get; set; }
        public bool? UserIsLike { get; set; }

        public UserVDto User { get; set; }
    }
}
