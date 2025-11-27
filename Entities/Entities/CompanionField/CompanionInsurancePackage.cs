using Entities.Entities.CommonField;

namespace Entities.Entities.CompanionField
{
    public class CompanionInsurancePackage : FullName_Field
    {
        public int DayCount { get; set; }
        public long CompanionId { get; set; }
        public double Price { get; set; }
        public long PetId { get; set; }
        public int Priority { get; set; }
        public bool Active { get; set; }
        public string ActivationValue { get; set; }
        public bool Deleted { get; set; }
        public Companion Companion { get; set; }
        public Pet Pet { get; set; }
    }
}
