using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.PansionSrvs.PansionPictureSrv.Iface
{
    public interface IPansionPictureSearchFields
    {
        public long? PansionId { get; set; }
        public long? CompanionId { get; set; }
    }
}
