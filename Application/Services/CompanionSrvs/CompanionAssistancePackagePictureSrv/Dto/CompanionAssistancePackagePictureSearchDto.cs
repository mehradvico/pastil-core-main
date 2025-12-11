using Application.Common.Dto.Result;
using Application.Services.CompanionSrvs.CompanionAssistancePackagePictureSrv.Iface;
using AutoMapper;
using Entities.Entities;
using Entities.Entities.CompanionField;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CompanionSrvs.CompanionAssistancePackagePictureSrv.Dto
{
    public class CompanionAssistancePackagePictureSearchDto : BaseSearchDto<CompanionAssistancePackagePicture, CompanionAssistancePackagePictureVDto>, ICompanionAssistancePackagePictureSearchFields
    {
        public CompanionAssistancePackagePictureSearchDto(CompanionAssistancePackagePictureInputDto dto, IQueryable<CompanionAssistancePackagePicture> list, IMapper mapper) : base(dto, list, mapper)

        {
            CompanionAssistancePackageId = dto.CompanionAssistancePackageId;
        }
        public long? CompanionAssistancePackageId { get; set; }
    }
}
