using Application.Common.Dto.Result;
using Application.Services.PansionSrvs.PansionPetSrv.Iface;
using Application.Services.PansionSrvs.PansionSrv.Dto;
using Application.Services.PansionSrvs.PansionSrv.Iface;
using AutoMapper;
using Entities.Entities.PansionField;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.PansionSrvs.PansionPetSrv.Dto
{
    public class PansionPetSearchDto : BaseSearchDto<PansionPet, PansionPetVDto>, IPansionPetSearchFields
    {
        public PansionPetSearchDto(PansionPetInputDto dto, IQueryable<PansionPet> list, IMapper mapper) : base(dto, list, mapper)
        {
            this.CompanionId = dto.CompanionId;
        }
        public long? CompanionId { get; set; }
    }
}
