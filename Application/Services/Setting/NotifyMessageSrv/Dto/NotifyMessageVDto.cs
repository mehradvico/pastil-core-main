using Application.Common.Dto.Field;
using Application.Services.Filing.PictureSrv.Dto;
using DocumentFormat.OpenXml.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Setting.NotifyMessageSrv.Dto
{
    public class NotifyMessageVDto : Id_FieldDto
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public long PictureId { get; set; }
        public string Url { get; set; }

        public PictureVDto Picture { get; set; }
    }
}
