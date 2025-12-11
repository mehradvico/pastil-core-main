using Application.Common.Interface;
using Application.Services.CompanionSrvs.CompanionAssistancePackagePictureSrv.Dto;
using Entities.Entities;
using Entities.Entities.CompanionField;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CompanionSrvs.CompanionAssistancePackagePictureSrv.Iface
{
    public interface ICompanionAssistancePackagePictureService : ICommonSrv<CompanionAssistancePackagePicture, CompanionAssistancePackagePictureDto>
    {
        CompanionAssistancePackagePictureSearchDto SearchDto(CompanionAssistancePackagePictureInputDto dto);
        void InsertOrUpdate(CompanionAssistancePackagePictureDto CompanionAssistancePackagePicture);
        void InsertOrUpdate(CompanionAssistancePackage CompanionAssistancePackage, List<CompanionAssistancePackagePictureDto> CompanionAssistancePackagePicturesDto);
    }
}
