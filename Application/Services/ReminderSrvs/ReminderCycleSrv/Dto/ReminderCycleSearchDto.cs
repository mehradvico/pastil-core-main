using Application.Common.Dto.Result;
using Application.Services.ReminderSrvs.ReminderCycleSrv.Dto;
using Application.Services.ReminderSrvs.ReminderCycleSrv.Iface;
using AutoMapper;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.ReminderSrvs.ReminderCycleSrv.Dto
{
    public class ReminderCycleSearchDto : BaseSearchDto<ReminderCycle, ReminderCycleVDto>, IReminderCycleSearchFields
    {
        public ReminderCycleSearchDto(ReminderCycleInputDto dto, IQueryable<ReminderCycle> list, IMapper mapper) : base(dto, list, mapper)
        {
        }
    }
}
