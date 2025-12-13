using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.PansionSrvs.PansionCommentSrv.Iface
{
    public interface IPansionCommentSearchFields
    {
        public long? PansionId { get; set; }
        public long? UserId { get; set; }
        public bool? AllStatus { get; set; }
    }
}
