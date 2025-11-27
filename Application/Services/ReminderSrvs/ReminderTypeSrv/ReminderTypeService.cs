using Application.Common.Dto.Result;
using Application.Common.Enumerable;
using Application.Common.Service;
using Application.Services.ReminderSrvs.ReminderTypeSrv.Dto;
using Application.Services.ReminderSrvs.ReminderTypeSrv.Iface;
using AutoMapper;
using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.ReminderSrvs.ReminderTypeSrv
{
    public class ReminderTypeService : CommonSrv<ReminderType, ReminderTypeDto>, IReminderTypeService
    {
        private readonly IDataBaseContext _context;
        private readonly IMapper mapper;
        public ReminderTypeService(IDataBaseContext _context, IMapper mapper) : base(_context, mapper)
        {
            this._context = _context;
            this.mapper = mapper;
        }
        public async Task<BaseResultDto<ReminderTypeVDto>> FindAsyncVDto(long id)
        {
            var item = await _context.ReminderTypes.FirstOrDefaultAsync(s => s.Id == id && !s.Deleted);
            if (item != null)
            {
                return new BaseResultDto<ReminderTypeVDto>(true, mapper.Map<ReminderTypeVDto>(item));
            }
            return new BaseResultDto<ReminderTypeVDto>(false, mapper.Map<ReminderTypeVDto>(item));
        }

        public override async Task<BaseResultDto<ReminderTypeDto>> FindAsyncDto(long id)
        {
            var item = await _context.ReminderTypes.FirstOrDefaultAsync(s => s.Id == id && !s.Deleted);
            if (item != null)
            {
                return new BaseResultDto<ReminderTypeDto>(true, mapper.Map<ReminderTypeDto>(item));
            }
            return new BaseResultDto<ReminderTypeDto>(false, mapper.Map<ReminderTypeDto>(item));
        }

        public ReminderTypeSearchDto Search(ReminderTypeInputDto baseSearchDto)
        {
            var model = _context.ReminderTypes.AsQueryable().Where(s => !s.Deleted);

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
            return new ReminderTypeSearchDto(baseSearchDto, model, mapper);
        }
    }
}
