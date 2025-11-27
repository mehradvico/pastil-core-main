using Application.Common.Dto.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.TripSrv.TripSrv.Dto
{
    public class ManualPayTripDto : Id_FieldDto
    {
        public bool IsPaid { get; set; }
        public DateTime? ManualPay { get; set; }
    }
}
