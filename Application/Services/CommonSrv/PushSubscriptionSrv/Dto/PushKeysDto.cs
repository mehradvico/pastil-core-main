using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CommonSrv.PushSubscriptionSrv.Dto
{
    public class PushKeysDto
    {
        public string P256dh { get; set; }
        public string Auth { get; set; }
    }
}
