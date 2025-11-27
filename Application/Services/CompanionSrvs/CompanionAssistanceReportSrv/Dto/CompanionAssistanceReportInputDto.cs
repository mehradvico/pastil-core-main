using Application.Common.Dto.Input;
using Application.Services.CompanionSrvs.CompanionAssistanceReportSrv.Iface;
using Application.Services.CompanionSrvs.CompanionReportSrv.Iface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CompanionSrvs.CompanionAssistanceReportSrv.Dto
{
    public class CompanionAssistanceReportInputDto : BaseInputDto, ICompanionAssistanceReportSearchFields
    {
        public long? CompanionAssistanceId { get; set; }
        public long? UserId { get; set; }
    }
}
