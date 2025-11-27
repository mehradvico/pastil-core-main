using Application.Common.Dto.Result;
using Application.Common.Interface;
using Application.Services.Accounting.UserPerRecordSrv.Dto;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Accounting.UserPerRecordSrv.Iface
{
    public interface IUserPetRecordService : ICommonSrv<UserPetRecord, UserPetRecordDto>
    {
        UserPetRecordSearchDto Search(UserPetRecordInputDto baseSearchDto);
        Task<BaseResultDto<UserPetRecordVDto>> FindAsyncVDto(long id);

    }
}
