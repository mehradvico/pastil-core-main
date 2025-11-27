using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CompanionSrvs.CompanionInsurancePackageSaleSrv.Iface
{
    public interface ICompanionInsurancePackageSaleSearchFields
    {
        public long? CompanionInsurancePackageId { get; set; }
        public long? UserPetId { get; set; }
        public long? UserId { get; set; }
        public bool? IsPaid { get; set; }
        public bool? ManualPay { get; set; }
        public long? CompanionId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
    }
}
