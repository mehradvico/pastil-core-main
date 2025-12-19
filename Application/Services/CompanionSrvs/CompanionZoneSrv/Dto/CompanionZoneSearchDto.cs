using Application.Common.Dto.Result;
using Application.Services.CompanionSrvs.CompanionZoneSrv.Dto;
using Application.Services.CompanionSrvs.CompanionZoneSrv.Iface;
using AutoMapper;
using Entities.Entities.CompanionField;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CompanionSrvs.CompanionZoneSrv.Dto
{
    public class CompanionZoneSearchDto : BaseSearchDto<CompanionZone, CompanionZoneVDto>, ICompanionZoneSearchFields
    {
        public CompanionZoneSearchDto(CompanionZoneInputDto dto, IQueryable<CompanionZone> list, IMapper mapper) : base(dto, list, mapper)

        {
            this.CompanionId = dto.CompanionId;
            this.StateId = dto.StateId;
            this.CityId = dto.CityId;
            this.NeighborhoodId = dto.NeighborhoodId;
        }

        public long? CompanionId { get; set; }
        public long? StateId { get; set; }
        public long? CityId { get; set; }
        public long? NeighborhoodId { get; set; }
    }
}
