using Entities.Entities.CommonField;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities.PansionField
{
    public class PansionPet : Id_Field
    {
        public long PansionId { get; set; }
        public long PetId { get; set; }

        public Pansion Pansion { get; set; }
        public Pet Pet { get; set; }
    }
}
