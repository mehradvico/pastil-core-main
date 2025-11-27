using Entities.Entities.CommonField;
using System.Collections.Generic;

namespace Entities.Entities
{
    public class AssistanceQuestionnaire : Name_Field
    {
        public int Priority { get; set; }
        public bool Active { get; set; }
        public bool Deleted { get; set; }
        public long AssistanceId { get; set; }
        public Assistance Assistance { get; set; }
        public ICollection<CompanionReserveCommentRate> CompanionReserveCommentRates { get; set; }
    }
}
