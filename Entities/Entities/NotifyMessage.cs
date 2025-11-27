using Entities.Entities.CommonField;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class NotifyMessage : Id_Field
    {
        public long PictureId { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public string Url { get; set; }

        public Picture Picture { get; set; }
    }
}
