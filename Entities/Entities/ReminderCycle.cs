using Entities.Entities.CommonField;

namespace Entities.Entities
{
    public class ReminderCycle : Name_Field
    {
        public int Cycle { get; set; }
        public bool Deleted { get; set; }
    }
}
