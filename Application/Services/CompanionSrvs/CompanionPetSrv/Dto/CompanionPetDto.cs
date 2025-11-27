using Application.Common.Dto.Field;
using Application.Services.Accounting.PetSrv.Dto;
using Application.Services.CompanionSrvs.CompanionSrv.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CompanionSrvs.CompanionPetSrv.Dto
{
    public class CompanionPetDto : Id_FieldDto
    {
        public long CompanionId { get; set; }
        public long PetId { get; set; }

        public CompanionMinVDto Companion {  get; set; }
        public PetVDto Pet { get; set; }
    }
}
