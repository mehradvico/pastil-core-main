using Application.Common.Dto.Input;
using Application.Services.CompanionSrvs.CompanionInsurancePackageSrv.Iface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CompanionSrvs.CompanionInsurancePackageSrv.Dto
{
    public class CompanionInsurancePackageInputDto : BaseInputDto, ICompanionInsurancePackageSearchFields
    {
        public int? MaxDayCount { get; set; }
        public int? MinDayCount { get; set; }
        public long? CompanionId { get; set; }
        public long? PetId { get; set; }
    }
}
