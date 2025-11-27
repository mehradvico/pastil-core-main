using Application.Common.Dto.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Setting.NoticeSrv.Dto
{
    public class NoticeReadDto : Id_FieldDto
    {
        public long? UserId { get; set; }
        public DateTime? ReadDate { get; set; }
    }
}
