using Application.Common.Dto.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.PansionSrvs.PansionPictureSrv.Dto
{
    public class PansionPictureDto : Id_FieldDto
    {
        public long PansionId { get; set; }
        public long PictureId { get; set; }
    }
}
