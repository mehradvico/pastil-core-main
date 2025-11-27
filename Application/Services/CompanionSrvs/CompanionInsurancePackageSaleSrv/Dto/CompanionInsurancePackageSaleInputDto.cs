using Application.Common.Dto.Input;
using Application.Services.CompanionSrvs.CompanionInsurancePackageSaleSrv.Iface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CompanionSrvs.CompanionInsurancePackageSaleSrv.Dto
{
    public class CompanionInsurancePackageSaleInputDto : BaseInputDto, ICompanionInsurancePackageSaleSearchFields
    {
        public long? CompanionInsurancePackageId { get; set; }
        public long? CompanionId { get; set; }
        public long? UserPetId { get; set; }
        public long? UserId { get; set; }
        public bool? IsPaid { get; set; }
        public bool? ManualPay { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
    }
}
