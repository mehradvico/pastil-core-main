using Application.Common.Dto.Result;
using Application.Common.Interface;
using Application.Services.ReminderSrvs.ReminderTypeSrv.Dto;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.ReminderSrvs.ReminderTypeSrv.Iface
{
    public interface IReminderTypeService : ICommonSrv<ReminderType, ReminderTypeDto>
    {
        ReminderTypeSearchDto Search(ReminderTypeInputDto baseSearchDto);
        Task<BaseResultDto<ReminderTypeVDto>> FindAsyncVDto(long id);
    }
}
