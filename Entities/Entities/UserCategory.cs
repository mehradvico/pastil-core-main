using Entities.Entities.CommonField;
using Entities.Entities.Security;
using System;

namespace Entities.Entities
{
    public class UserCategory : Id_Field
    {
        public long CategoryId { get; set; }
        public long UserId { get; set; }
        public DateTime ExpireDate { get; set; }
        public DateTime CreateDate { get; set; }
        public Category Category { get; set; }
        public User User { get; set; }
    }
}
