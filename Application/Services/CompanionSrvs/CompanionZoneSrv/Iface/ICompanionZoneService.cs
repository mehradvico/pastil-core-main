using Application.Common.Interface;
using Application.Services.CompanionSrvs.CompanionZoneSrv.Dto;
using Entities.Entities.CompanionField;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CompanionSrvs.CompanionZoneSrv.Iface
{
    public interface ICompanionZoneService : ICommonSrv<CompanionZone, CompanionZoneDto>
    {
        CompanionZoneSearchDto Search(CompanionZoneInputDto dto);
    }
}
