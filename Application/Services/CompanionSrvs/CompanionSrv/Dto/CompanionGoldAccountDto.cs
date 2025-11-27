using Application.Common.Dto.Field;
using System;

namespace Application.Services.CompanionSrvs.CompanionSrv.Dto
{
    public class CompanionGoldAccountDto : Id_FieldDto
    {
        public DateTime? GoldAccountDate { get; set; }
    }
}
