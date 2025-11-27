using Application.Common.Dto.Input;
using Application.Services.Accounting.UserPetSrv.Iface;

namespace Application.Services.Accounting.UserPetSrv.Dto
{
    public class UserPetInputDto : BaseInputDto, IUserPetSearchFields
    {
        public long? UserId { get; set; }
    }
}
