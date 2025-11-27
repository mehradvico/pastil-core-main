using Application.Common.Dto.Field;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.TripSrv.TripOptionSrv.Dto
{
    public class TripOptionDto : Name_FieldDto
    {
        public double Price { get; set; }
        public bool Active { get; set; }
    }
}
