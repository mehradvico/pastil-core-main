using Application.Common.Dto.Result;
using Application.Services.Content.CargoSrv.Dto;
using Application.Services.Content.CargoSrv.Iface;
using AutoMapper;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Content.CargoSrv.Dto
{
    public class CargoSearchDto : BaseSearchDto<Cargo, CargoVDto>, ICargoSearchFields
    {
        public CargoSearchDto(CargoInputDto dto, IQueryable<Cargo> list, IMapper mapper) : base(dto, list, mapper)
        {
            this.FromStateId = dto.FromStateId;
            this.ToStateId = dto.ToStateId;
            this.FromCountryId = dto.FromCountryId;
            this.ToCountryId = dto.ToCountryId;
            this.UserPetId = dto.UserPetId;
            this.IsAccompany = dto.IsAccompany;
            this.IsPaid = dto.IsPaid;
            this.StatusId = dto.StatusId;
            this.UserId = dto.UserId;
        }

        public long? FromStateId { get; set; }
        public long? ToStateId { get; set; }
        public long? FromCountryId { get; set; }
        public long? ToCountryId { get; set; }
        public long? UserPetId { get; set; }
        public long? UserId { get; set; }
        public bool? IsAccompany { get; set; }
        public bool? IsPaid { get; set; }
        public long? StatusId { get; set; }
    }
}
