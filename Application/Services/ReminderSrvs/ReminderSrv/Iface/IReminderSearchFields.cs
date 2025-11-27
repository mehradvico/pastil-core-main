using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.ReminderSrvs.ReminderSrv.Iface
{
    public interface IReminderSearchFields
    {
        public long? ReminderTypeId { get; set; }
        public long? ReminderCycleId { get; set; }
        public long? UserId { get; set; }
    }
}
