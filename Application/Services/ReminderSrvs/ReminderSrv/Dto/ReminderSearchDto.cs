using Application.Common.Dto.Result;
using Application.Services.ReminderSrvs.ReminderSrv.Dto;
using Application.Services.ReminderSrvs.ReminderSrv.Iface;
using AutoMapper;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.ReminderSrvs.ReminderSrv.Dto
{
    public class ReminderSearchDto : BaseSearchDto<Reminder, ReminderVDto>, IReminderSearchFields
    {
        public ReminderSearchDto(ReminderInputDto dto, IQueryable<Reminder> list, IMapper mapper) : base(dto, list, mapper)
        {
            this.ReminderCycleId = dto.ReminderCycleId;
            this.ReminderTypeId = dto.ReminderTypeId;
            this.UserId = dto.UserId;
        }
        public long? ReminderTypeId { get; set; }
        public long? ReminderCycleId { get; set; }
        public long? UserId { get; set; }
    }
}
