using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CompanionSrvs.CompanionAssistancePackagePictureSrv.Iface
{
    public interface ICompanionAssistancePackagePictureSearchFields
    {
        public long? CompanionAssistancePackageId { get; set; }
        public long? CompanionId { get; set; }
    }
}
