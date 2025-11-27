using Entities.Entities.CommonField;
using Entities.Entities.CompanionField;

namespace Entities.Entities
{
    public class CompanionReserveCommentRate : Id_Field
    {
        public int Rate { get; set; }
        public long AssistanceQuestionnaireId { get; set; }
        public long CompanionReserveCommentId { get; set; }
        public AssistanceQuestionnaire AssistanceQuestionnaire { get; set; }
        public CompanionReserveComment CompanionReserveComment { get; set; }
    }
}
