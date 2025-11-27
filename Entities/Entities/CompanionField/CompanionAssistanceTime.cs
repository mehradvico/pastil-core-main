using Entities.Entities.CommonField;

namespace Entities.Entities
{
    public class CompanionAssistanceTime : Id_Field
    {
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public bool Active { get; set; }
        public bool Deleted { get; set; }
        public long WeekDayId { get; set; }
        public long CompanionAssistanceId { get; set; }
        public WeekDay WeekDay { get; set; }
        public CompanionAssistance CompanionAssistance { get; set; }
    }
}
