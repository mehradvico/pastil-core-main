using Application.Common.Dto.Result;
using Application.Common.Enumerable.Code;
using Application.Services.CompanionSrv.CompanionAssistanceSrv.Iface;
using AutoMapper;
using Entities.Entities;
using System.Linq;

namespace Application.Services.CompanionSrv.CompanionAssistanceSrv.Dto
{
    public class CompanionAssistanceSearchDto : BaseSearchDto<CompanionAssistance, CompanionAssistanceVDto>, ICompanionAssistanceSearchFields
    {
        public CompanionAssistanceSearchDto(CompanionAssistanceInputDto dto, IQueryable<CompanionAssistance> list, IMapper mapper) : base(dto, list, mapper)
        {

            this.CompanionId = dto.CompanionId;
            this.AssistanceId = dto.AssistanceId;
            this.IsSinglePackage = dto.IsSinglePackage;
            this.Type = dto.Type;
            this.IsPersonal = dto.IsPersonal;
            this.PetId = dto.PetId;
            this.CompanionTypeId = dto.CompanionTypeId;
        }

        public long? CompanionId { get; set; }
        public long? AssistanceId { get; set; }
        public bool? IsSinglePackage { get; set; }
        public bool? IsPersonal { get; set; }
        public long? CompanionTypeId { get; set; }
        public long? PetId { get; set; }
        public CompanionAssistanceTypeEnum? Type { get; set; }


    }
}
