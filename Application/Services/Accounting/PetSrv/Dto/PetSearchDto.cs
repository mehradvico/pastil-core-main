using Application.Common.Dto.Result;
using Application.Services.Accounting.PetSrv.Iface;
using AutoMapper;
using Entities.Entities;
using System.Linq;

namespace Application.Services.Accounting.PetSrv.Dto
{
    public class PetSearchDto : BaseSearchDto<Pet, PetVDto>, IPetSearchFields
    {
        public PetSearchDto(PetInputDto dto, IQueryable<Pet> list, IMapper mapper) : base(dto, list, mapper)
        {
        }
    }
}
