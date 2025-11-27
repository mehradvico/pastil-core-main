using Application.Services.CompanionSrv.CompanionAssistanceTypeSrv.Iface;
using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Services.CompanionSrv.CompanionAssistanceTypeSrv
{
    public class CompanionAssistanceTypeService : ICompanionAssistanceTypeService
    {
        private readonly IDataBaseContext _context;

        public CompanionAssistanceTypeService(IDataBaseContext _context)
        {
            this._context = _context;
        }

        public async Task InsertOrUpdateAsync(CompanionAssistance companionAssistance, long typeId)
        {
            var item = await _context.Codes.AsTracking().FirstOrDefaultAsync(s => s.Id == typeId);
            if (item != null)
            {
                companionAssistance.Codes.Add(item);
                await _context.SaveChangesAsync();
            }
        }

        public async Task InsertOrUpdateAsync(CompanionAssistance companionAssistance, List<long> typeIds)
        {
            if (companionAssistance.Codes != null)
            {
                companionAssistance.Codes.Clear();
                await _context.SaveChangesAsync();
            }
            else
            {
                companionAssistance.Codes = new List<Code>();
            }
            foreach (var item in typeIds)
            {
                await InsertOrUpdateAsync(companionAssistance, item);
            }
        }
    }
}
