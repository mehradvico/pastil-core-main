using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Setting.PushMessageSrv.Dto
{
    public class PushMessageDto
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public string Icon { get; set; }
        public string Url { get; set; }
    }
}
