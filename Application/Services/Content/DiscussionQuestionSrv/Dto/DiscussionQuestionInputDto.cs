using Application.Common.Dto.Input;
using Application.Services.Content.DiscussionQuestionSrv.Iface;
using System;

namespace Application.Services.Content.DiscussionQuestionSrv.Dto
{
    public class DiscussionQuestionInputDto : BaseInputDto, IDiscussionQuestionSearchFields
    {
        public bool? Active { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public bool? AdminConfirm { get; set; }
        public long? ProductId { get; set; }

    }
}
