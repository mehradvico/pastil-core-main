using Application.Common.Dto.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Setting.NoticeSrv.Dto
{
    public class NoticeUserDto : Id_FieldDto
    {
        public long TypeId { get; set; }
        public long? ItemId { get; set; }
    }
}
