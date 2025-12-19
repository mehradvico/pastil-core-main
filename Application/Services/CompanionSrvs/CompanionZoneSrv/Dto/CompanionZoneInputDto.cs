using Application.Common.Dto.Input;
using Application.Services.CompanionSrvs.CompanionZoneSrv.Iface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CompanionSrvs.CompanionZoneSrv.Dto
{
    public class CompanionZoneInputDto : BaseInputDto, ICompanionZoneSearchFields
    {
        public long? CompanionId { get; set; }
        public long? StateId { get; set; }
        public long? CityId { get; set; }
        public long? NeighborhoodId { get; set; }

    }
}
