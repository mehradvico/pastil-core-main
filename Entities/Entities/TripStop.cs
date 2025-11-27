using Entities.Entities.CommonField;
using System.Collections.Generic;

namespace Entities.Entities
{
    public class TripStop : Name_Field
    {
        public double Price { get; set; }
        public bool Active { get; set; }
        public bool Deleted { get; set; }
        public ICollection<Trip> Trips { get; set; }
    }
}
