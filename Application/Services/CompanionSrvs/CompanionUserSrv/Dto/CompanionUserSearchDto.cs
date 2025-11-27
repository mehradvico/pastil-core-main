using Application.Common.Dto.Result;
using Application.Services.CompanionSrvs.CompanionUserSrv.Iface;
using AutoMapper;
using Entities.Entities.CompanionField;
using System.Linq;

namespace Application.Services.CompanionSrvs.CompanionUserSrv.Dto
{
    public class CompanionUserSearchDto : BaseSearchDto<CompanionUser, CompanionUserVDto>, ICompanionUserSearchFields
    {
        public CompanionUserSearchDto(CompanionUserInputDto dto, IQueryable<CompanionUser> list, IMapper mapper) : base(dto, list, mapper)

        {
            CompanionId = dto.CompanionId;
            UserId = dto.UserId;
            UserAccept = dto.UserAccept;
            AllUserAccept = dto.AllUserAccept;
            Active = dto.Active;
        }
        public long? CompanionId { get; set; }
        public long? UserId { get; set; }
        public bool? UserAccept { get; set; }
        public bool AllUserAccept { get; set; }
        public bool? Active { get; set; }


    }
}
