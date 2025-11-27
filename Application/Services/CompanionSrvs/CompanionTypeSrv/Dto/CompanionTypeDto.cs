using Application.Common.Dto.Field;
using Application.Services.CompanionSrvs.CompanionSrv.Dto;
using Application.Services.Setting.CodeSrv.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CompanionSrvs.CompanionTypeSrv.Dto
{
    public class CompanionTypeDto : Id_FieldDto
    {
        public long CompanionId { get; set; }
        public long TypeId { get; set; }

        public CompanionMinVDto Companion { get; set; }
        public CodeVDto Type { get; set; }
    }
}
