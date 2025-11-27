using Application.Common.Dto.Result;
using Application.Common.Interface;
using Application.Services.CompanionSrvs.CompanionAssistanceReportSrv.Dto;
using Application.Services.CompanionSrvs.CompanionReportSrv.Dto;
using Entities.Entities.CompanionField;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CompanionSrvs.CompanionAssistanceReportSrv.Iface
{
    public interface ICompanionAssistanceReportService : ICommonSrv<CompanionAssistanceReport, CompanionAssistanceReportDto>
    {
        Task<BaseResultDto<CompanionAssistanceReportVDto>> FindAsyncVDto(long id);
        CompanionAssistanceReportSearchDto Search(CompanionAssistanceReportInputDto baseSearchDto);
    }
}
