using Application.Common.Dto.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CompanionSrvs.CompanionZoneSrv.Dto
{
    public class CompanionZoneDto : Id_FieldDto
    {
        public long CompanionId { get; set; }
        public long CityId { get; set; }
        public long? NeighborhoodId { get; set; }
    }
}
