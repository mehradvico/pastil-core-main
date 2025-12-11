using Entities.Entities.CommonField;
using Entities.Entities.CompanionField;
using Microsoft.Identity.Client;
using System.Collections.Generic;

namespace Entities.Entities
{
    public class CompanionAssistancePackage : Name_Field
    {
        public double Price { get; set; }
        public double PrePaymentPrice { get; set; }
        public long? PictureId { get; set; }
        public bool Active { get; set; }
        public string ActivationValue { get; set; }
        public long CompanionAssistanceId { get; set; }
        public string Discription { get; set; }
        public bool Deleted { get; set; }
        public CompanionAssistance CompanionAssistance { get; set; }
        public Picture Picture { get; set; }
        public ICollection<CompanionReserve> CompanionReserves { get; set; }
        public ICollection<CompanionAssistancePackagePicture> CompanionAssistancePackagePictures { get; set; }
    }
}
