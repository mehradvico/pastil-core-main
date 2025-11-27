using Application.Common.Dto.Result;
using Application.Services.Accounting.UserPerRecordSrv.Iface;
using Application.Services.Accounting.UserPetSrv.Dto;
using Application.Services.Accounting.UserPetSrv.Iface;
using AutoMapper;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Accounting.UserPerRecordSrv.Dto
{
    public class UserPetRecordSearchDto : BaseSearchDto<UserPetRecord, UserPetRecordVDto>, IUserPetRecordSearchFields
    {
        public UserPetRecordSearchDto(UserPetRecordInputDto dto, IQueryable<UserPetRecord> list, IMapper mapper) : base(dto, list, mapper)
        {
            this.UserPetId = dto.UserPetId;
            this.UserId = dto.UserId;
            this.OperatorId = dto.OperatorId;
        }
        public long? UserPetId { get; set; }
        public long? UserId { get; set; }
        public long? OperatorId { get; set; }
    }
}
