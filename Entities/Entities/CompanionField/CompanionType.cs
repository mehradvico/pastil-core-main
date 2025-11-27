using Entities.Entities.CommonField;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities.CompanionField
{
    public class CompanionType : Id_Field
    {
        public long CompanionId { get; set; }
        public long TypeId { get; set; }
        public bool Deleted { get; set; }

        public Companion Companion { get; set; }
        public Code Type { get; set; }
    }
}
