using Application.Common.Dto.Result;
using Application.Services.CompanionSrvs.CompanionTypeSrv.Dto;
using Application.Services.CompanionSrvs.CompanionTypeSrv.Iface;
using AutoMapper;
using Entities.Entities.CompanionField;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CompanionSrvs.CompanionTypeSrv.Dto
{
    public class CompanionTypeSearchDto : BaseSearchDto<CompanionType, CompanionTypeVDto>, ICompanionTypeSearchFields
    {
        public CompanionTypeSearchDto(CompanionTypeInputDto dto, IQueryable<CompanionType> list, IMapper mapper) : base(dto, list, mapper)
        {

            this.CompanionId = dto.CompanionId;
            this.TypeId = dto.TypeId;

        }

        public long? TypeId { get; set; }
        public long? CompanionId { get; set; }
    }
}
