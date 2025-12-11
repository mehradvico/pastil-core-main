using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CompanionSrvs.CompanionReserveUserPetSrv.Iface
{
    public interface ICompanionReserveUserPetService
    {
        Task InsertOrUpdateAsync(CompanionReserve companionReserve, long UserPetId);
        Task InsertOrUpdateAsync(CompanionReserve companionReserve, List<long> userPetIds);
    }
}
