using Application.Common.Dto.Result;
using Application.Services.Accounting.UserPetSrv.Iface;
using AutoMapper;
using Entities.Entities;
using System.Linq;

namespace Application.Services.Accounting.UserPetSrv.Dto
{
    public class UserPetSearchDto : BaseSearchDto<UserPet, UserPetVDto>, IUserPetSearchFields
    {
        public UserPetSearchDto(UserPetInputDto dto, IQueryable<UserPet> list, IMapper mapper) : base(dto, list, mapper)
        {
            this.UserId = dto.UserId;
        }
        public long? UserId { get; set; }

    }
}
