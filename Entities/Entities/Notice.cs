using Entities.Entities.CommonField;
using Entities.Entities.Security;
using System;
namespace Entities.Entities
{
    public class Notice : Id_Field
    {
        public long? UserId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? ReadDate { get; set; }
        public long TypeId { get; set; }
        public long UserTypeId { get; set; }
        public long? ItemId { get; set; }
        public User User { get; set; }
        public Code Type { get; set; }
        public Code UserType { get; set; }
    }
}
