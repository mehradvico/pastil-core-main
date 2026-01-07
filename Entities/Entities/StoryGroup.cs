using Entities.Entities.CommonField;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class StoryGroup : Name_Field
    {
        public int Priority { get; set; }
        public long PictureId { get; set; }
        public bool Active { get; set; }
        public bool Deleted { get; set; }

        public Picture Picture { get; set; }
        ICollection<StoryItem> StoryItems { get; set; }

    }
}
