using Entities.Entities.CommonField;
using System;

namespace Entities.Entities
{
    public class Reminder : Id_Field
    {
        public long ReminderTypeId { get; set; }
        public long ReminderCycleId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? LastChecked { get; set; }
        public long UserPetId { get; set; }
        public bool Deleted { get; set; }
        public UserPet UserPet { get; set; }
        public ReminderType ReminderType { get; set; }
        public ReminderCycle ReminderCycle { get; set; }
    }
}
