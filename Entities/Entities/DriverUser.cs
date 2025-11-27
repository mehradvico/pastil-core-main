using Entities.Entities.CommonField;
using Entities.Entities.Security;

namespace Entities.Entities
{
    public class DriverUser : Id_Field
    {
        public long DriverId { get; set; }
        public long UserId { get; set; }

        public Driver Driver { get; set; }
        public User User { get; set; }
    }
}
