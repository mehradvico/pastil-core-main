using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CompanionSrvs.CompanionZoneSrv.Iface
{
    public interface ICompanionZoneSearchFields
    {
        public long? CompanionId { get; set; }
        public long? StateId { get; set; }
        public long? CityId { get; set; }
        public long? NeighborhoodId { get; set; }
    }
}
