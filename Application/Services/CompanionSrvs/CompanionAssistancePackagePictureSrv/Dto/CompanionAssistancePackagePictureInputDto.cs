using Application.Common.Dto.Input;
using Application.Services.CompanionSrvs.CompanionAssistancePackagePictureSrv.Iface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CompanionSrvs.CompanionAssistancePackagePictureSrv.Dto
{
    public class CompanionAssistancePackagePictureInputDto : BaseInputDto, ICompanionAssistancePackagePictureSearchFields
    {
        public long? CompanionAssistancePackageId { get; set; }
    }
}
