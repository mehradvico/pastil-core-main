using Entities.Entities.CommonField;
using Entities.Entities.Security;

namespace Entities.Entities
{
    public class CompanionAssistanceUser : Id_Field
    {
        public bool Active { get; set; }
        public string ActivationValue { get; set; }
        public bool Deleted { get; set; }
        public long UserId { get; set; }
        public User User { get; set; }
        public long CompanionAssistanceId { get; set; }
        public CompanionAssistance CompanionAssistance { get; set; }
    }
}
