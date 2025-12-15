using Application.Common.Dto.Result;
using Application.Services.PansionSrvs.PansionPictureSrv.Iface;
using AutoMapper;
using Entities.Entities;
using Entities.Entities.PansionField;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.PansionSrvs.PansionPictureSrv.Dto
{
    public class PansionPictureSearchDto : BaseSearchDto<PansionPicture, PansionPictureDto>, IPansionPictureSearchFields
    {
        public PansionPictureSearchDto(PansionPictureInputDto dto, IQueryable<PansionPicture> list, IMapper mapper) : base(dto, list, mapper)
        {
            PansionId = dto.PansionId;
            CompanionId = dto.CompanionId;
        }
        public long? PansionId { get; set; }
        public long? CompanionId { get; set; }

    }
}
