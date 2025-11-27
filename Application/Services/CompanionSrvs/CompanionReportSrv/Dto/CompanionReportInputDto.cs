using Application.Common.Dto.Input;
using Application.Services.CompanionSrvs.CompanionReportSrv.Iface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CompanionSrvs.CompanionReportSrv.Dto
{
    public class CompanionReportInputDto : BaseInputDto, ICompanionReportSearchFields
    {
        public long? CompanionId { get; set; }
        public long? UserId { get; set; }
    }
}
