using Entities.Entities.CommonField;
using Entities.Entities.Security;
using System;

namespace Entities.Entities.CompanionField
{
    public class CompanionReport : Id_Field
    {
        public long UserId { get; set; }
        public long CompanionId { get; set; }
        public string ReportValue { get; set; }
        public DateTime CreateDate { get; set; }

        public User User { get; set; }
        public Companion Companion { get; set; }
    }
}
