using Entities.Entities.CommonField;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class UserPetPicture : Id_Field
    {
        public long UserPetId { get; set; }
        public long PictureId { get; set; }
        public bool Deleted { get; set; }

        public UserPet UserPet { get; set; }
        public Picture Picture { get; set; }
    }
}
