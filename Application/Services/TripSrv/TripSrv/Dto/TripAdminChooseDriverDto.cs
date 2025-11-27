using Application.Common.Dto.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.TripSrv.TripSrv.Dto
{
    public class TripAdminChooseDriverDto : Id_FieldDto
    {
        public long DriverId { get; set; }
    }
}
