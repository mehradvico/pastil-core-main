using Application.Common.Dto.Result;
using Application.Services.WeekDaySrv.WeekDaySrv.Iface;
using AutoMapper;
using Entities.Entities;
using System.Linq;

namespace Application.Services.WeekDaySrv.WeekDaySrv.Dto
{
    public class WeekDaySearchDto : BaseSearchDto<WeekDay, WeekDayVDto>, IWeekDaySearchFields
    {
        public WeekDaySearchDto(WeekDayInputDto dto, IQueryable<WeekDay> list, IMapper mapper) : base(dto, list, mapper)
        {
        }
    }
}
