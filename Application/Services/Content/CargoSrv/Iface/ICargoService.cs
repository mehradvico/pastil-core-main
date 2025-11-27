using Application.Common.Dto.Result;
using Application.Common.Interface;
using Application.Services.CompanionSrvs.CompanionReserveSrv.Dto;
using Application.Services.Content.CargoSrv.Dto;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Content.CargoSrv.Iface
{
    public interface ICargoService : ICommonSrv<Cargo, CargoDto>
    {
        CargoSearchDto Search(CargoInputDto baseSearchDto);
        Task<BaseResultDto<CargoVDto>> FindAsyncVDto(long id);
        Task<BaseResultDto> CargoPaymentCallback(long? cargoId, bool fromWallet = false);
        Task<BaseResultDto<CargoUpdateStatusDto>> CargoUpdateStatusAsyncDto(CargoUpdateStatusDto dto);
        Task<BaseResultDto> SetRebateCodeAsyncDto(CargoSetRebateCodeDto dto);
        Task<BaseResultDto> SetWalletAsyncDto(CargoSetWalletDto dto);
        Task<BaseResultDto> ClearRebateCodeAsync(long id);
    }
}
