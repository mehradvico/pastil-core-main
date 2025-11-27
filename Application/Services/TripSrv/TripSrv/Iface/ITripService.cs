using Application.Common.Dto.Result;
using Application.Common.Interface;
using Application.Services.Content.CargoSrv.Dto;
using Application.Services.TripSrv.TripSrv.Dto;
using Entities.Entities;
using System.Threading.Tasks;

namespace Application.Services.TripSrv.TripSrv.Iface
{
    public interface ITripService : ICommonSrv<Trip, TripDto>
    {

        TripSearchDto Search(TripInputDto baseSearchDto);
        Task<BaseResultDto<ManualPayTripDto>> ManualTripPaymentAsync(ManualPayTripDto dto);
        Task<BaseResultDto<TripVDto>> FindAsyncVDto(long id);
        Task<BaseResultDto> InsertOrUpdateAsync(TripDto dto);
        Task<BaseResultDto<TripVDto>> GetUserCurrentTrip(long userId);
        Task<BaseResultDto<TripVDto>> GetDriverCurrentTrip(long driverId);
        Task<BaseResultDto> TripPaymentCallback(long? tripId, bool fromWallet = false);
        Task<BaseResultDto<TripDriverChangeStatusDto>> UpdateTripDriverStatusAsync(TripDriverChangeStatusDto dto);
        Task<BaseResultDto<TripShareDto>> UpdateTripShareAsync(TripShareDto dto);
        Task<BaseResultDto<TripAdminChooseDriverDto>> ChooseDriverAsync(TripAdminChooseDriverDto dto);
        Task<BaseResultDto<TripChangeStatusDto>> TripChangeStatusAsync(TripChangeStatusDto dto);
        Task<BaseResultDto<TripUserChangeStatusDto>> UpdateTripUserStatusAsync(TripUserChangeStatusDto dto);
        Task<BaseResultDto> SetRebateCodeAsyncDto(TripSetRebateCodeDto dto);
        Task<BaseResultDto> SetWalletAsyncDto(TripSetWalletDto dto);
        Task<BaseResultDto> ClearRebateCodeAsync(long id);
        Task SyncDriverAcceptAsync();
    }
}
