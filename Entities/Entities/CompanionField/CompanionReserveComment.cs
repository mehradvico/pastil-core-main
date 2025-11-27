using System.Collections.Generic;

namespace Entities.Entities.CompanionField
{
    public class CompanionReserveComment : Comment
    {
        public long CompanionReserveId { get; set; }
        public CompanionReserve CompanionReserve { get; set; }

        public ICollection<CompanionReserveCommentRate> CompanionReserveCommentRates { get; set; }
    }
}
