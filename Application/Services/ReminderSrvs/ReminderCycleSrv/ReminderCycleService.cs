using AngleSharp.Dom;
using Application.Common.Dto.Result;
using Application.Common.Enumerable;
using Application.Common.Helpers;
using Application.Common.Service;
using Application.Services.ReminderSrvs.ReminderCycleSrv.Dto;
using Application.Services.ReminderSrvs.ReminderCycleSrv.Iface;
using AutoMapper;
using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.ReminderSrvs.ReminderCycleSrv
{
    public class ReminderCycleService : CommonSrv<ReminderCycle, ReminderCycleDto>, IReminderCycleService
    {
        private readonly IDataBaseContext _context;
        private readonly IMapper mapper;
        public ReminderCycleService(IDataBaseContext _context, IMapper mapper) : base(_context, mapper)
        {
            this._context = _context;
            this.mapper = mapper;
        }
        public async Task<BaseResultDto<ReminderCycleVDto>> FindAsyncVDto(long id)
        {
            var item = await _context.ReminderCycles.FirstOrDefaultAsync(s => s.Id == id && !s.Deleted);
            if (item != null)
            {
                return new BaseResultDto<ReminderCycleVDto>(true, mapper.Map<ReminderCycleVDto>(item));
            }
            return new BaseResultDto<ReminderCycleVDto>(false, mapper.Map<ReminderCycleVDto>(item));
        }

        public override async Task<BaseResultDto<ReminderCycleDto>> FindAsyncDto(long id)
        {
            var item = await _context.ReminderCycles.FirstOrDefaultAsync(s => s.Id == id && !s.Deleted);
            if (item != null)
            {
                return new BaseResultDto<ReminderCycleDto>(true, mapper.Map<ReminderCycleDto>(item));
            }
            return new BaseResultDto<ReminderCycleDto>(false, mapper.Map<ReminderCycleDto>(item));
        }

        public ReminderCycleSearchDto Search(ReminderCycleInputDto baseSearchDto)
        {
            var model = _context.ReminderCycles.AsQueryable().Where(s => !s.Deleted);

            switch (baseSearchDto.SortBy)
            {
                case SortEnum.New:
                    {
                        model = model.OrderByDescending(s => s.Id);
                        break;
                    }
                case SortEnum.Old:
                    {
                        model = model.OrderBy(s => s.Id);
                        break;
                    }
                default:
                    break;
            }
            return new ReminderCycleSearchDto(baseSearchDto, model, mapper);
        }
    }
}
