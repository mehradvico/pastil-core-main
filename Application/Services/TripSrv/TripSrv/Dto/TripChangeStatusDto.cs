using Application.Common.Dto.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.TripSrv.TripSrv.Dto
{
    public class TripChangeStatusDto : Id_FieldDto
    {
        public long TripStatusId { get; set; }
    }
}
