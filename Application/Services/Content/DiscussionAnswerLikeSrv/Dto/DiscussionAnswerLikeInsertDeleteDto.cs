namespace Application.Services.Content.DiscussionAnswerLikeSrv.Dto
{
    public class DiscussionAnswerLikeInsertDeleteDto
    {
        public bool? IsLike { get; set; }
        public long DiscussionAnswerId { get; set; }
    }
}
