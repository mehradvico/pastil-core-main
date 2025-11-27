using Application.Common.Dto.Result;
using Application.Common.Interface;
using Application.Services.ReminderSrvs.ReminderSrv.Dto;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.ReminderSrvs.ReminderSrv.Iface
{
    public interface IReminderService : ICommonSrv<Reminder, ReminderDto>
    {
        ReminderSearchDto Search(ReminderInputDto baseSearchDto);
        Task<BaseResultDto<ReminderVDto>> FindAsyncVDto(long id);
        Task SyncReminderAsync();
    }
}
