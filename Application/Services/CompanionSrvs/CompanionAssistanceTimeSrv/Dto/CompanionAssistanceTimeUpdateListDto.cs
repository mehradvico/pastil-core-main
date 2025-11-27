using System.Collections.Generic;

namespace Application.Services.CompanionSrv.CompanionAssistanceTimeSrv.Dto
{
    public class CompanionAssistanceTimeUpdateListDto
    {
        public long CompanionAssistanceId { get; set; }
        public List<CompanionAssistanceTimeUpdateDto> CompanionAssistanceTimeUpdateList { get; set; }
    }
}
