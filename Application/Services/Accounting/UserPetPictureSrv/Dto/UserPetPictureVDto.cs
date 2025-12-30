using Application.Common.Dto.Field;
using Application.Services.Filing.PictureSrv.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Accounting.UserPetPictureSrv.Dto
{
    public class UserPetPictureVDto : Id_FieldDto
    {
        public long UserPetId { get; set; }
        public long PictureId { get; set; }

        public PictureVDto Picture { get; set; }
    }
}
