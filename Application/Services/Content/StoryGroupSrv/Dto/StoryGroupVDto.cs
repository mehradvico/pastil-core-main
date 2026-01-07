using Application.Common.Dto.Field;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Content.StoryGroupSrv.Dto
{
    public class StoryGroupVDto : Name_FieldDto
    {
        public int Priority { get; set; }
        public long PictureId { get; set; }
        public bool Active { get; set; }

        public Picture Picture { get; set; }
        List<StoryItem> StoryItems { get; set; }
    }
}
