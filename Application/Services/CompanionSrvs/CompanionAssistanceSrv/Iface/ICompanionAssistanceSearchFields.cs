using Application.Common.Enumerable.Code;

namespace Application.Services.CompanionSrv.CompanionAssistanceSrv.Iface
{
    public interface ICompanionAssistanceSearchFields
    {
        public long? CompanionId { get; set; }
        public long? AssistanceId { get; set; }
        public bool? IsSinglePackage { get; set; }
        public long? CompanionTypeId { get; set; }
        public bool? IsPersonal { get; set; }
        public long? PetId { get; set; }
        public CompanionAssistanceTypeEnum? Type { get; set; }
    }
}
