using Application.Common.Dto.Input;
using Application.Services.CompanionSrv.CompanionAssistanceTimeSrv.Iface;

namespace Application.Services.CompanionSrv.CompanionAssistanceTimeSrv.Dto
.Dto
{
    public class CompanionAssistanceTimeInputDto : BaseInputDto, ICompanionAssistanceTimeSearchFields
    {
        public long? WeekDayId { get; set; }
        public long? CompanionAssistanceId { get; set; }
        public bool? Active { get; set; }
    }
}
