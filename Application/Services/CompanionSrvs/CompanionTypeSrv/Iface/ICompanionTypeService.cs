using Application.Common.Dto.Result;
using Application.Common.Interface;
using Application.Services.CompanionSrvs.CompanionTypeSrv.Dto;
using Entities.Entities;
using Entities.Entities.CompanionField;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CompanionSrvs.CompanionTypeSrv.Iface
{
    public interface ICompanionTypeService : ICommonSrv<CompanionType, CompanionTypeDto>
    {
        CompanionTypeSearchDto Search(CompanionTypeInputDto baseSearchDto);
        Task<BaseResultDto<CompanionTypeVDto>> FindAsyncVDto(long id);
    }
}
