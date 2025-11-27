using Application.Common.Dto.Result;
using Application.Services.CompanionSrvs.CompanionPetSrv.Iface;
using Application.Services.CompanionSrvs.CompanionSrv.Dto;
using Application.Services.CompanionSrvs.CompanionSrv.Iface;
using AutoMapper;
using Entities.Entities;
using Entities.Entities.CompanionField;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CompanionSrvs.CompanionPetSrv.Dto
{
    public class CompanionPetSearchDto : BaseSearchDto<CompanionPet, CompanionPetVDto>, ICompanionPetSearchFields
    {
        public CompanionPetSearchDto(CompanionPetInputDto dto, IQueryable<CompanionPet> list, IMapper mapper) : base(dto, list, mapper)
        {

            this.CompanionId = dto.CompanionId;
            this.PetId = dto.PetId;

        }

        public long? PetId { get; set; }
        public long? CompanionId { get; set; }
    }
}
