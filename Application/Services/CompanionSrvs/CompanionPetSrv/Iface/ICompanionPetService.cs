using Application.Common.Dto.Result;
using Application.Common.Interface;
using Application.Services.CompanionSrvs.CompanionPetSrv.Dto;
using Application.Services.CompanionSrvs.CompanionSrv.Dto;
using Entities.Entities;
using Entities.Entities.CompanionField;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CompanionSrvs.CompanionPetSrv.Iface
{
    public interface ICompanionPetService : ICommonSrv<CompanionPet, CompanionPetDto>
    {
        CompanionPetSearchDto Search(CompanionPetInputDto baseSearchDto);
        Task<BaseResultDto<CompanionPetVDto>> FindAsyncVDto(long id);
    }
}
