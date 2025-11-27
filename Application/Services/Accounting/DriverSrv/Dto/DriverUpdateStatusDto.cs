using Application.Common.Dto.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Accounting.DriverSrv.Dto
{
    public class DriverUpdateStatusDto : Id_FieldDto
    {
        public long StatusId { get; set; }
        public string AdminDetail { get; set; }
    }
}
