using Entities.Entities.CommonField;
using System.Collections.Generic;

namespace Entities.Entities
{
    public class Pet : Name_Field
    {
        public bool Deleted { get; set; }
        public bool Active { get; set; }
        public int Priority { get; set; }
        public ICollection<Companion> Companions { get; set; }

    }
}
