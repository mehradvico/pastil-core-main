using Entities.Entities.CommonField;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities.CompanionField
{
    public class CompanionAssistancePackagePicture : Id_Field
    {
        public long CompanionAssistancePackageId { get; set; }
        public long PictureId { get; set; }

        public CompanionAssistancePackage CompanionAssistancePackage { get; set; }
        public Picture Picture { get; set; }
    }
}
