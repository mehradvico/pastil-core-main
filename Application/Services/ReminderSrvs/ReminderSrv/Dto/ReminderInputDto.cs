using Application.Common.Dto.Input;
using Application.Services.ReminderSrvs.ReminderSrv.Iface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.ReminderSrvs.ReminderSrv.Dto
{
    public class ReminderInputDto : BaseInputDto, IReminderSearchFields
    {
        public long? ReminderTypeId { get; set; }
        public long? ReminderCycleId { get; set; }
        public long? UserId { get; set; }
    }
}
