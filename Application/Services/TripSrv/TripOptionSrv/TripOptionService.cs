using Application.Common.Dto.Result;
using Application.Common.Service;
using Application.Services.TripSrv.TripOptionSrv.Dto;
using Application.Services.TripSrv.TripOptionSrv.Iface;
using AutoMapper;
using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Services.TripSrv.TripOptionSrv
{
    public class TripOptionService : CommonSrv<TripOption, TripOptionDto>, ITripOptionService
    {
        private readonly IDataBaseContext _context;
        private readonly IMapper mapper;
        public TripOptionService(IDataBaseContext _context, IMapper mapper) : base(_context, mapper)
        {
            this._context = _context;
            this.mapper = mapper;
        }

        public async Task<BaseResultDto<TripOptionVDto>> FindAsyncVDto(long id)
        {
            var item = await _context.TripOptions.Include(s => s.Trips).FirstOrDefaultAsync(s => s.Id == id && !s.Deleted);
            if (item != null)
            {
                return new BaseResultDto<TripOptionVDto>(true, mapper.Map<TripOptionVDto>(item));
            }
            return new BaseResultDto<TripOptionVDto>(false, mapper.Map<TripOptionVDto>(item));
        }

        public TripOptionSearchDto Search(TripOptionInputDto baseSearchDto)
        {
            var model = _context.TripOptions.Include(s => s.Trips).AsQueryable().Where(s => !s.Deleted);

            if (baseSearchDto.Available.HasValue)
            {
                model = model.Where(s => s.Active == baseSearchDto.Available.Value);
            }
            switch (baseSearchDto.SortBy)
            {
                case Common.Enumerable.SortEnum.New:
                    {
                        model = model.OrderByDescending(s => s.Id);
                        break;
                    }
                case Common.Enumerable.SortEnum.Expensive:
                    {
                        model = model.OrderByDescending(s => s.Price);
                        break;
                    }
                case Common.Enumerable.SortEnum.Inexpensive:
                    {
                        model = model.OrderBy(s => s.Price);
                        break;
                    }
                default:
                    break;
            }
            return new TripOptionSearchDto(baseSearchDto, model, mapper);
        }
        public async Task<List<TripOption>> GetListAsync(List<long> ids)
        {
            return await _context.TripOptions.Where(x => ids.Contains(x.Id)).ToListAsync();
        }
    }
}
