using Application.Common.Dto.Field;
using System;

namespace Application.Services.CompanionSrvs.CompanionSrv.Dto
{
    public class CompanionSilverAccountDto : Id_FieldDto
    {
        public DateTime? SilverAccountDate { get; set; }
    }
}
