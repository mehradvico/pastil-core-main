using Application.Common.Dto.Result;
using Application.Common.Interface;
using Application.Services.CompanionSrvs.CompanionReportSrv.Dto;
using Entities.Entities;
using Entities.Entities.CompanionField;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CompanionSrvs.CompanionReportSrv.Iface
{
    public interface ICompanionReportService : ICommonSrv<CompanionReport, CompanionReportDto>
    {
        Task<BaseResultDto<CompanionReportVDto>> FindAsyncVDto(long id);
        CompanionReportSearchDto Search(CompanionReportInputDto baseSearchDto);
    }
}
