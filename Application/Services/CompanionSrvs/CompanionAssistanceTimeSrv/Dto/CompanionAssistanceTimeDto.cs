using Application.Common.Dto.Field;

namespace Application.Services.CompanionSrv.CompanionAssistanceTimeSrv.Dto
{
    public class CompanionAssistanceTimeDto : Id_FieldDto
    {
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public bool Active { get; set; }
        public long WeekDayId { get; set; }
        public long CompanionAssistanceId { get; set; }

    }
}
