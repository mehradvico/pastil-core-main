using Application.Common.Dto.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.TripSrv.TripSrv.Dto
{
    public class TripSetWalletDto : Id_FieldDto
    {
        public bool FromWallet { get; set; }
    }
}
