using Application.Common.Dto.Field;
using Application.Services.Filing.PictureSrv.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CompanionSrvs.CompanionAssistancePackagePictureSrv.Dto
{
    public class CompanionAssistancePackagePictureVDto : Id_FieldDto
    {
        public long CompanionAssistancePackageId { get; set; }
        public long PictureId { get; set; }

        public PictureVDto Picture { get; set; }
    }
}
