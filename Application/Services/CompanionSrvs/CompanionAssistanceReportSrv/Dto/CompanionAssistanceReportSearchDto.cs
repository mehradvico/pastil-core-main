using Application.Common.Dto.Result;
using Application.Services.CompanionSrvs.CompanionAssistanceReportSrv.Iface;
using Application.Services.CompanionSrvs.CompanionReportSrv.Dto;
using Application.Services.CompanionSrvs.CompanionReportSrv.Iface;
using AutoMapper;
using Entities.Entities.CompanionField;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CompanionSrvs.CompanionAssistanceReportSrv.Dto
{
    public class CompanionAssistanceReportSearchDto : BaseSearchDto<CompanionAssistanceReport, CompanionAssistanceReportVDto>, ICompanionAssistanceReportSearchFields
    {
        public CompanionAssistanceReportSearchDto(CompanionAssistanceReportInputDto dto, IQueryable<CompanionAssistanceReport> list, IMapper mapper) : base(dto, list, mapper)
        {
            CompanionAssistanceId = dto.CompanionAssistanceId;
            UserId = dto.UserId;
        }
        public long? CompanionAssistanceId { get; set; }
        public long? UserId { get; set; }
    }
}
