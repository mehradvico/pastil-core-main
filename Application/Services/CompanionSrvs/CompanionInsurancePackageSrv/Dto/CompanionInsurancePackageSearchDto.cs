using Application.Common.Dto.Result;
using Application.Services.CompanionSrvs.CompanionInsurancePackageSrv.Iface;
using AutoMapper;
using Entities.Entities;
using Entities.Entities.CompanionField;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CompanionSrvs.CompanionInsurancePackageSrv.Dto
{
    public class CompanionInsurancePackageSearchDto : BaseSearchDto<CompanionInsurancePackage, CompanionInsurancePackageVDto>, ICompanionInsurancePackageSearchFields
    {
        public CompanionInsurancePackageSearchDto(CompanionInsurancePackageInputDto dto, IQueryable<CompanionInsurancePackage> list, IMapper mapper) : base(dto, list, mapper)
        {
            this.CompanionId = dto.CompanionId;
            this.PetId = dto.PetId;
            this.MaxDayCount = dto.MaxDayCount;
            this.MinDayCount = dto.MinDayCount;
        }
        public int? MaxDayCount { get; set; }
        public int? MinDayCount { get; set; }
        public long? CompanionId { get; set; }
        public long? PetId { get; set; }
    }
}
