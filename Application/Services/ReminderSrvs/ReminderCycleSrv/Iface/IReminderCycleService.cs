using Application.Common.Dto.Result;
using Application.Common.Interface;
using Application.Services.ReminderSrvs.ReminderCycleSrv.Dto;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.ReminderSrvs.ReminderCycleSrv.Iface
{
    public interface IReminderCycleService : ICommonSrv<ReminderCycle, ReminderCycleDto>
    {
        ReminderCycleSearchDto Search(ReminderCycleInputDto baseSearchDto);
        Task<BaseResultDto<ReminderCycleVDto>> FindAsyncVDto(long id);
    }
}
