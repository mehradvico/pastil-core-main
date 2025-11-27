using Entities.Entities.CommonField;
using Entities.Entities.Security;
using System;

namespace Entities.Entities.CompanionField
{
    public class CompanionAssistanceReport : Id_Field
    {
        public long UserId { get; set; }
        public long CompanionAssistanceId { get; set; }
        public string ReportValue { get; set; }
        public DateTime CreateDate { get; set; }

        public User User { get; set; }
        public CompanionAssistance CompanionAssistance { get; set; }
    }
}
