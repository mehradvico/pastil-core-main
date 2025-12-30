using Application.Common.Dto.Input;
using Application.Services.Accounting.UserPetPictureSrv.Iface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Accounting.UserPetPictureSrv.Dto
{
    public class UserPetPictureInputDto : BaseInputDto, IUserPetPictureSearchFields
    {
        public long? UserPetId { get; set; }
        public long? UserId { get; set; }
    }
}
