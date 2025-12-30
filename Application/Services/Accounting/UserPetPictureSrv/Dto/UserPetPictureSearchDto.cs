using Application.Common.Dto.Result;
using Application.Services.Accounting.UserPetPictureSrv.Iface;
using AutoMapper;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Accounting.UserPetPictureSrv.Dto
{
    public class UserPetPictureSearchDto : BaseSearchDto<UserPetPicture, UserPetPictureVDto>, IUserPetPictureSearchFields
    {
        public UserPetPictureSearchDto(UserPetPictureInputDto dto, IQueryable<UserPetPicture> list, IMapper mapper) : base(dto, list, mapper)
        {
            UserPetId = dto.UserPetId;
            UserId = dto.UserId;
        }
        public long? UserPetId { get; set; }
        public long? UserId { get; set; }

    }
}
