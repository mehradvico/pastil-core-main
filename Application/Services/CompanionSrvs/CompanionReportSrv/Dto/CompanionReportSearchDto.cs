using Application.Common.Dto.Result;
using Application.Services.CompanionSrvs.CompanionReportSrv.Iface;
using AutoMapper;
using Entities.Entities;
using Entities.Entities.CompanionField;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CompanionSrvs.CompanionReportSrv.Dto
{
    public class CompanionReportSearchDto : BaseSearchDto<CompanionReport, CompanionReportVDto>, ICompanionReportSearchFields
    {
        public CompanionReportSearchDto(CompanionReportInputDto dto, IQueryable<CompanionReport> list, IMapper mapper) : base(dto, list, mapper)
        {
            CompanionId = dto.CompanionId;
            UserId = dto.UserId;
        }
        public long? CompanionId { get; set; }
        public long? UserId { get; set; }
    }
}
