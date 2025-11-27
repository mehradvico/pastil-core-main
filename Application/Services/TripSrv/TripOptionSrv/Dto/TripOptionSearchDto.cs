using Application.Common.Dto.Result;
using Application.Services.TripSrv.TripOptionSrv.Iface;
using AutoMapper;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.TripSrv.TripOptionSrv.Dto
{
    public class TripOptionSearchDto : BaseSearchDto<TripOption, TripOptionVDto>, ITripOptionSearchFields
    {
        public TripOptionSearchDto(TripOptionInputDto dto, IQueryable<TripOption> list, IMapper mapper) : base(dto, list, mapper)
        {
        }

    }
}
