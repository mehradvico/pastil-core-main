using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CompanionSrvs.CompanionPetSrv.Iface
{
    public interface ICompanionPetSearchFields
    {
        public long? PetId { get; set; }
        public long? CompanionId { get; set; }
    }
}
