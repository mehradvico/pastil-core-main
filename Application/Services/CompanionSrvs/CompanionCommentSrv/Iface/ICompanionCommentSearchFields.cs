using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CompanionSrvs.CompanionCommentSrv.Iface
{
    public interface ICompanionCommentSearchFields
    {
        public long? CompanionId { get; set; }
        public bool? AllStatus { get; set; }
    }
}
