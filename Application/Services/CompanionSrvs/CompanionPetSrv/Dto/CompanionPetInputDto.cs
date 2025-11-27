using Application.Common.Dto.Input;
using Application.Services.CompanionSrvs.CompanionPetSrv.Iface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CompanionSrvs.CompanionPetSrv.Dto
{
    public class CompanionPetInputDto : BaseInputDto, ICompanionPetSearchFields
    {
        public long? PetId { get; set; }
        public long? CompanionId { get; set; }
    }
}
