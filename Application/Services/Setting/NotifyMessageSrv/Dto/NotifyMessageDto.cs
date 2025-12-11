using Application.Common.Dto.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Setting.NotifyMessageSrv.Dto
{
    public class NotifyMessageDto : Id_FieldDto
    {
        public long PictureId { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public string Url { get; set; }
    }
}
