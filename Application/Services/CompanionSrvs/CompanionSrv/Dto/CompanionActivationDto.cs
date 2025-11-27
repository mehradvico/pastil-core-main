using Application.Common.Dto.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CompanionSrvs.CompanionSrv.Dto
{
    public class CompanionActivationDto : Id_FieldDto
    {
        public bool Approved { get; set; }
        public bool Active { get; set; }
        public string ActivationValue { get; set; }
    }
}
