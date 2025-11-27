using Application.Common.Dto.Result;
using Application.Common.Interface;
using Application.Services.CompanionSrv.CompanionAssistancePackageSrv.Dto;
using Application.Services.CompanionSrvs.CompanionAssistancePackageSrv.Dto;
using Application.Services.CompanionSrvs.CompanionAssistanceSrv.Dto;
using Entities.Entities;
using System.Threading.Tasks;

namespace Application.Services.CompanionSrv.CompanionAssistancePackageSrv.Iface
{
    public interface ICompanionAssistancePackageService : ICommonSrv<CompanionAssistancePackage, CompanionAssistancePackageDto>
    {
        CompanionAssistancePackageSearchDto Search(CompanionAssistancePackageInputDto baseSearchDto);
        Task<BaseResultDto<CompanionAssistancePackageVDto>> FindAsyncVDto(long id);
        BaseResultDto ActivationDto(CompanionAssistancePackageActivationDto dto);
    }
}
