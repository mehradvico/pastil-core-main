using System;

namespace Application.Services.Content.DiscussionQuestionSrv.Iface
{
    public interface IDiscussionQuestionSearchFields
    {
        public bool? Active { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public bool? AdminConfirm { get; set; }
        public long? ProductId { get; set; }
    }
}
