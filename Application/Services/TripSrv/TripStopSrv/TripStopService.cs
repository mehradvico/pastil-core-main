using Application.Common.Dto.Result;
using Application.Common.Service;
using Application.Services.TripSrv.TripStopSrv.Dto;
using Application.Services.TripSrv.TripStopSrv.Iface;
using AutoMapper;
using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Interface;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Services.TripSrv.TripStopSrv
{
    public class TripStopService : CommonSrv<TripStop, TripStopDto>, ITripStopService
    {
        private readonly IDataBaseContext _context;
        private readonly IMapper mapper;
        public TripStopService(IDataBaseContext _context, IMapper mapper) : base(_context, mapper)
        {
            this._context = _context;
            this.mapper = mapper;
        }

        public async Task<BaseResultDto<TripStopVDto>> FindAsyncVDto(long id)
        {
            var item = await _context.TripStops.Include(s => s.Trips).FirstOrDefaultAsync(s => s.Id == id && !s.Deleted);
            if (item != null)
            {
                return new BaseResultDto<TripStopVDto>(true, mapper.Map<TripStopVDto>(item));
            }
            return new BaseResultDto<TripStopVDto>(false, mapper.Map<TripStopVDto>(item));
        }

        public TripStopSearchDto Search(TripStopInputDto baseSearchDto)
        {
            var model = _context.TripStops.Include(s => s.Trips).AsQueryable().Where(s => !s.Deleted);

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
            return new TripStopSearchDto(baseSearchDto, model, mapper);
        }
        public async Task<TripStop> FindAsync(long id)
        {
            return await _context.TripStops.FindAsync(id);
        }
    }
}
