using Application.Common.Dto.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CompanionSrvs.CompanionInsurancePackageSaleSrv.Dto
{
    public class CompanionInsurancePackageSaleSetRebateCodeDto : Id_FieldDto
    {
        public string RebateCode { get; set; }
    }
}
