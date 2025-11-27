using Application.Common.Dto.Result;
using Application.Services.CompanionSrv.CompanionAssistanceTimeSrv.Dto.Dto;
using Application.Services.CompanionSrv.CompanionAssistanceTimeSrv.Iface;
using AutoMapper;
using Entities.Entities;
using System.Linq;

namespace Application.Services.CompanionSrv.CompanionAssistanceTimeSrv.Dto
{
    public class CompanionAssistanceTimeSearchDto : BaseSearchDto<CompanionAssistanceTime, CompanionAssistanceTimeVDto>, ICompanionAssistanceTimeSearchFields
    {
        public CompanionAssistanceTimeSearchDto(CompanionAssistanceTimeInputDto dto, IQueryable<CompanionAssistanceTime> list, IMapper mapper) : base(dto, list, mapper)
        {

            this.WeekDayId = dto.WeekDayId;
            this.CompanionAssistanceId = dto.CompanionAssistanceId;
            this.Active = dto.Active;
        }

        public long? WeekDayId { get; set; }
        public long? CompanionAssistanceId { get; set; }
        public bool? Active { get; set; }

    }
}
