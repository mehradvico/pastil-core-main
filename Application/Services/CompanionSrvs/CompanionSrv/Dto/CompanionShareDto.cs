using Application.Common.Dto.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CompanionSrvs.CompanionSrv.Dto
{
    public class CompanionShareDto : Id_FieldDto
    {
        public int SharePercent { get; set; }
    }
}
