using Entities.Entities.CommonField;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities.CompanionField
{
    public class CompanionPet : Id_Field
    {
        public long CompanionId { get; set; }
        public long PetId { get; set; }
        public bool Deleted { get; set; }

        public Companion Companion { get; set; }
        public Pet Pet { get; set; }
    }
}
