using Application.Common.Dto.Field;
using Application.Services.CompanionSrv.CompanionAssistanceSrv.Dto;
using Application.Services.WeekDaySrv.WeekDaySrv.Dto;

namespace Application.Services.CompanionSrv.CompanionAssistanceTimeSrv.Dto
{
    public class CompanionAssistanceTimeVDto : Id_FieldDto
    {
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public long WeekDayId { get; set; }
        public long CompanionAssistanceId { get; set; }
        public bool Active { get; set; }
        public WeekDayVDto WeekDay { get; set; }
        public CompanionAssistanceVDto CompanionAssistance { get; set; }
    }
}
