using Application.Common.Dto.Field;
using Application.Services.Filing.PictureSrv.Dto;
using Entities.Entities.PansionField;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.PansionSrvs.PansionPictureSrv.Dto
{
    public class PansionPictureVDto : Id_FieldDto
    {
        public long PansionId { get; set; }
        public long PictureId { get; set; }

        public PictureVDto Picture { get; set; }
    }
}
