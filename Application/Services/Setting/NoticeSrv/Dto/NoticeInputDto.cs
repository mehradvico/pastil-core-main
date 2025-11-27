using Application.Common.Dto.Input;
using Application.Services.Setting.NoticeSrv.Iface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Setting.NoticeSrv.Dto
{
    public class NoticeInputDto : BaseInputDto, INoticeSearchFields
    {
        public long? UserId { get; set; }
        public bool? IsRead { get; set; }
        public long? TypeId { get; set; }
    }
}
