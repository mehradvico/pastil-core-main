using Application.Common.Dto.Field;
using Application.Services.CompanionSrv.CompanionAssistanceSrv.Dto;
using Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CompanionSrvs.CompanionAssistanceReportSrv.Dto
{
    public class CompanionAssistanceReportDto : Id_FieldDto
    {
        public long UserId { get; set; }
        public long CompanionAssistanceId { get; set; }
        public string ReportValue { get; set; }

        public UserMinVDto User { get; set; }
        public CompanionAssistanceVDto CompanionAssistance { get; set; }
    }
}
