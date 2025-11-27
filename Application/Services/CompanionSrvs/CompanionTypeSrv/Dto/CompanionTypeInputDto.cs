using Application.Common.Dto.Input;
using Application.Services.CompanionSrvs.CompanionTypeSrv.Iface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CompanionSrvs.CompanionTypeSrv.Dto
{
    public class CompanionTypeInputDto : BaseInputDto, ICompanionTypeSearchFields
    {
        public long? TypeId { get; set; }
        public long? CompanionId { get; set; }
    }
}
