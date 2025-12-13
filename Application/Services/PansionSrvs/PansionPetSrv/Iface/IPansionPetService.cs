using Application.Common.Dto.Result;
using Application.Common.Interface;
using Application.Services.PansionSrvs.PansionPetSrv.Dto;
using Application.Services.PansionSrvs.PansionSrv.Dto;
using Entities.Entities.PansionField;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.PansionSrvs.PansionPetSrv.Iface
{
    public interface IPansionPetService : ICommonSrv<PansionPet, PansionPetDto>
    {
        PansionPetSearchDto Search(PansionPetInputDto baseSearchDto);
        Task<BaseResultDto<PansionPetVDto>> FindAsyncVDto(long id);
    }
}
