using Application.Services.WeekDaySrv.WeekDaySrv.Dto;
using System.Collections.Generic;

namespace Application.Services.CompanionSrv.CompanionAssistanceTimeSrv.Dto
{
    public class CompanionAssistanceTimeUpdateDto
    {
        public WeekDayDto WeekDay { get; set; }
        public List<CompanionAssistanceTimeDto> CompanionAssistanceTimes { get; set; } = new List<CompanionAssistanceTimeDto>();
    }
}
