using Application.Common.Dto.LocationPoint;
using Application.Common.Dto.Result;
using Application.Services.ReminderSrvs.ReminderTypeSrv.Iface;
using AutoMapper;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.ReminderSrvs.ReminderTypeSrv.Dto
{
    public class ReminderTypeSearchDto : BaseSearchDto<ReminderType, ReminderTypeVDto>, IReminderTypeSearchFields
    {
        public ReminderTypeSearchDto(ReminderTypeInputDto dto, IQueryable<ReminderType> list, IMapper mapper) : base(dto, list, mapper)
        {
        }
    }
}
