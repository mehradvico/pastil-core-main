using Entities.Entities.CommonField;
using System.Collections.Generic;

namespace Entities.Entities
{
    public class CompanionAssistancePackage : Name_Field
    {
        public double Price { get; set; }
        public bool Active { get; set; }
        public string ActivationValue { get; set; }
        public long CompanionAssistanceId { get; set; }
        public bool Deleted { get; set; }
        public CompanionAssistance CompanionAssistance { get; set; }
        public ICollection<CompanionReserve> CompanionReserves { get; set; }
    }
}
