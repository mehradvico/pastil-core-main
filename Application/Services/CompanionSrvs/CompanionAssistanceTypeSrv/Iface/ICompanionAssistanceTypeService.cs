using Entities.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Services.CompanionSrv.CompanionAssistanceTypeSrv.Iface
{
    public interface ICompanionAssistanceTypeService
    {
        Task InsertOrUpdateAsync(CompanionAssistance companionAssistance, long TypeId);
        Task InsertOrUpdateAsync(CompanionAssistance companionAssistance, List<long> typeIds);
    }
}
