using Application.Common.Dto.Result;
using Application.Common.Service;
using Application.Services.TripSrv.PriceCalculationSrv.Dto;
using Application.Services.TripSrv.TripAddressSrv.Iface;
using AutoMapper;
using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.TripSrv.TripAddressSrv
{
    public class TripAddressService : CommonSrv<TripAddress, TripAddressDto>, ITripAddressService
    {
        private readonly IDataBaseContext _context;
        private readonly IMapper mapper;
        public TripAddressService(IDataBaseContext _context, IMapper mapper) : base(_context, mapper)
        {
            this._context = _context;
            this.mapper = mapper;
        }

        public async Task<BaseResultDto<TripAddressVDto>> FindAsyncVDto(long id)
        {
            var item = await _context.TripAddresses.Include(s => s.User).FirstOrDefaultAsync(s => s.Id == id && !s.Deleted);
            if (item != null)
            {
                return new BaseResultDto<TripAddressVDto>(true, mapper.Map<TripAddressVDto>(item));
            }
            return new BaseResultDto<TripAddressVDto>(false, mapper.Map<TripAddressVDto>(item));
        }

        public TripAddressSearchDto Search(TripAddressInputDto baseSearchDto)
        {
            var model = _context.TripAddresses.Include(s => s.User).AsQueryable().Where(s => !s.Deleted);

            if (baseSearchDto.UserId.HasValue)
            {
                model = model.Where(s => s.UserId == baseSearchDto.UserId.Value);
            }
            switch (baseSearchDto.SortBy)
            {
                case Common.Enumerable.SortEnum.New:
                    {
                        model = model.OrderByDescending(s => s.Id);
                        break;
                    }
                case Common.Enumerable.SortEnum.Old:
                    {
                        model = model.OrderBy(s => s.Id);
                        break;
                    }
                default:
                    break;
            }
            return new TripAddressSearchDto(baseSearchDto, model, mapper);
        }
    }
}
