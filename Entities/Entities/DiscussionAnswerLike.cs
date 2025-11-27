using Entities.Entities.CommonField;
using Entities.Entities.Security;
using System;

namespace Entities.Entities
{
    public class DiscussionAnswerLike : Id_Field
    {
        public bool IsLike { get; set; }
        public long UserId { get; set; }
        public DateTime CreateDate { get; set; }
        public long DiscussionAnswerId { get; set; }
        public DiscussionAnswer DiscussionAnswer { get; set; }
        public User User { get; set; }

    }
}
