namespace Application.Services.Content.DiscussionAnswerSrv.Iface
{
    public interface IDiscussionAnswerSearchFields
    {
        public long? UserId { get; set; }
        public long? DiscussionQuestionId { get; set; }
    }
}
