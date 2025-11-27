using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CompanionSrvs.CompanionReportSrv.Iface
{
    internal interface ICompanionReportSearchFields
    {
        public long? CompanionId { get; set; }
        public long? UserId { get; set; }
    }
}
