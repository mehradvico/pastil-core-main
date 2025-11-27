using Application.Common.Dto.Result;
using Application.Services.TripSrv.TripStopSrv.Dto;
using Application.Services.TripSrv.TripStopSrv.Iface;
using AutoMapper;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.TripSrv.TripStopSrv.Dto
{
    public class TripStopSearchDto : BaseSearchDto<TripStop, TripStopVDto>, ITripStopSearchFields
    {
        public TripStopSearchDto(TripStopInputDto dto, IQueryable<TripStop> list, IMapper mapper) : base(dto, list, mapper)
        {
        }

    }
}
