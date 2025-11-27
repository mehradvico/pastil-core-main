using Entities.Entities.CommonField;
using Entities.Entities.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class UserPetRecord : Name_Field
    {
        public long UserPetId { get; set; }
        public long OperatorId { get; set; }
        public DateTime CreateDate { get; set; }

        public UserPet UserPet { get; set; }
        public User Operator { get; set; }
        
    }
}
