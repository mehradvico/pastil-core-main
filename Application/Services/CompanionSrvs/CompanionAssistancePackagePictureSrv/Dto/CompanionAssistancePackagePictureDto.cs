using Application.Common.Dto.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CompanionSrvs.CompanionAssistancePackagePictureSrv.Dto
{
    public class CompanionAssistancePackagePictureDto : Id_FieldDto
    {
        public long CompanionAssistancePackageId { get; set; }
        public long PictureId { get; set; }
    }
}
