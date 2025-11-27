using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CompanionSrvs.CompanionAssistanceReportSrv.Iface
{
    public interface ICompanionAssistanceReportSearchFields 
    {
        public long? CompanionAssistanceId { get; set; }
        public long? UserId { get; set; }
    }
}
