using Entities.Entities;
using Entities.Entities.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Setting.NoticeSrv.Iface
{
    public interface INoticeSearchFields
    {
        public long? UserId { get; set; }
        public bool? IsRead { get; set; }
        public long? TypeId { get; set; }
    }
}
