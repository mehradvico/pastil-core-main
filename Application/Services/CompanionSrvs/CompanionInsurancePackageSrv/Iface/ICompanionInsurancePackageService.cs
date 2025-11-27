using Application.Common.Dto.Result;
using Application.Common.Interface;
using Application.Services.CompanionSrvs.CompanionInsurancePackageSrv.Dto;
using Entities.Entities.CompanionField;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CompanionSrvs.CompanionInsurancePackageSrv.Iface
{
    public interface ICompanionInsurancePackageService : ICommonSrv<CompanionInsurancePackage, CompanionInsurancePackageDto>
    {
        CompanionInsurancePackageSearchDto Search(CompanionInsurancePackageInputDto baseSearchDto);
        Task<BaseResultDto<CompanionInsurancePackageVDto>> FindAsyncVDto(long id);
        BaseResultDto ActivationDto(CompanionInsurancePackageActivationDto dto);
    }
}
