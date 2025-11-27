using Application.Common.Dto.Field;
using Application.Services.Accounting.PetSrv.Dto;
using Application.Services.CompanionSrvs.CompanionSrv.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CompanionSrvs.CompanionInsurancePackageSrv.Dto
{
    public class CompanionInsurancePackageVDto : FullName_FieldDto
    {
        public int DayCount { get; set; }
        public long CompanionId { get; set; }
        public double Price { get; set; }
        public long PetId { get; set; }
        public int Priority { get; set; }
        public bool Active { get; set; }
        public string ActivationValue { get; set; }
        public CompanionMinVDto Companion { get; set; }
        public PetVDto Pet { get; set; }
    }
}
