using Application.Common.Dto.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Content.StoryGroupSrv.Dto
{
    public class StoryGroupDto : Name_FieldDto
    {
        public int Priority { get; set; }
        public long PictureId { get; set; }
        public bool Active { get; set; }
    }
}
