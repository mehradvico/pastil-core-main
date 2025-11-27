using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Accounting.UserPerRecordSrv.Iface
{
    public interface IUserPetRecordSearchFields
    {
        public long? UserPetId { get; set; }
        public long? UserId { get; set; }
        public long? OperatorId { get; set; }
    }
}
