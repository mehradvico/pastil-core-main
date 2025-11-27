using Application.Common.Interface;
using Application.Services.Accounting.PetSrv.Dto;
using Entities.Entities;

namespace Application.Services.Accounting.PetSrv.Iface
{
    public interface IPetService : ICommonSrv<Pet, PetDto>
    {
        PetSearchDto Search(PetInputDto baseSearchDto);
    }
}
