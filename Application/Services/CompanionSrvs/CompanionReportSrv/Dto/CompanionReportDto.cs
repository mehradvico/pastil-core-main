using Application.Common.Dto.Field;
using Application.Services.CompanionSrvs.CompanionSrv.Dto;
using Application.Services.Dto;

namespace Application.Services.CompanionSrvs.CompanionReportSrv.Dto
{
    public class CompanionReportDto : Id_FieldDto
    {
        public long UserId { get; set; }
        public long CompanionId { get; set; }
        public string ReportValue { get; set; }

        public UserMinVDto User { get; set; }
        public CompanionMinVDto Companion { get; set; }
    }
}
