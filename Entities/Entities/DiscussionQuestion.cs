using Entities.Entities.CommonField;
using Entities.Entities.Security;
using System;
using System.Collections.Generic;

namespace Entities.Entities
{
    public class DiscussionQuestion : Id_Field
    {
        public string Content { get; set; }
        public DateTime CreateDate { get; set; }
        public long ProductId { get; set; }
        public long UserId { get; set; }
        public bool? AdminConfirm { get; set; }
        public bool Deleted { get; set; }
        public bool Active { get; set; }
        public int AnswerCount { get; set; }
        public Product Product { get; set; }
        public User User { get; set; }
        public ICollection<DiscussionAnswer> DiscussionAnswers { get; set; }
    }
}
