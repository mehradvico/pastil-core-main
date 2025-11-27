using Entities.Entities.CommonField;

namespace Entities.Entities
{
    public class MapKey : Id_Field
    {
        public long TypeId { get; set; }
        public string Key { get; set; }
        public bool Active { get; set; }
        public bool Deleted { get; set; }
        public Code Type { get; set; }
    }
}
