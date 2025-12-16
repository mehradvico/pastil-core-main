using Application.Common.Dto.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.PansionSrvs.PansionReserveSrv.Dto
{
    public class PansionReserveCancelDto : Id_FieldDto
    {
        public bool IsCancel { get; set; }
        public string CancelDetail { get; set; }
    }
}
