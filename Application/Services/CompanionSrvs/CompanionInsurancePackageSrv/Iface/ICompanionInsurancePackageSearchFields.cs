using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CompanionSrvs.CompanionInsurancePackageSrv.Iface
{
    public interface ICompanionInsurancePackageSearchFields
    {
        public int? MaxDayCount { get; set; }
        public int? MinDayCount { get; set; }
        public long? CompanionId { get; set; }
        public long? PetId { get; set; }
    }
}
