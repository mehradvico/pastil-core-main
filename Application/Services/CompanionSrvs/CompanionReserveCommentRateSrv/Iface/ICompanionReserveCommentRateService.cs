using Application.Common.Dto.Result;
using Application.Common.Interface;
using Application.Services.CompanionSrvs.CompanionReserveCommentRateSrv.Dto;
using Entities.Entities;
using System.Threading.Tasks;

namespace Application.Services.CompanionSrvs.CompanionReserveCommentRateSrv.Iface
{
    public interface ICompanionReserveCommentRateService : ICommonSrv<CompanionReserveCommentRate, CompanionReserveCommentRateDto>
    {
        CompanionReserveCommentRateSearchDto Search(CompanionReserveCommentRateInputDto baseSearchDto);
        Task<BaseResultDto<CompanionReserveCommentRateVDto>> FindAsyncVDto(long id);

    }
}
