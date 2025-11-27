using Application.Common.Dto.Result;
using Application.Common.Interface;
using Application.Services.WeekDaySrv.WeekDaySrv.Dto;
using Entities.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Services.WeekDaySrv.WeekDaySrv.Iface
{
    public interface IWeekDayService : ICommonSrv<WeekDay, WeekDayDto>
    {
        WeekDaySearchDto Search(WeekDayInputDto baseSearchDto);
        Task<BaseResultDto<WeekDayVDto>> FindAsyncVDto(long id);
        List<WeekDayDto> GetWeekDays();
    }
}
