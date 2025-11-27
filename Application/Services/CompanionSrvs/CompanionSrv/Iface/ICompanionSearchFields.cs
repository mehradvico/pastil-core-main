using Application.Common.Enumerable.Code;

namespace Application.Services.CompanionSrvs.CompanionSrv.Iface
{
    public interface ICompanionSearchFields
    {
        public long? OwnerId { get; set; }
        public long? TypeId { get; set; }
        public long? PetId  { get; set; }
        public long? CityId { get; set; }
        public long? StateId { get; set; }
        public long? NeighborhoodId { get; set; }
        public bool? Approved { get; set; }
        public bool? GoldAccount { get; set; }
        public bool? SilverAccount { get; set; }
        public bool? HasInsurance { get; set; }
        public long? AssistanceId { get; set; }
        public bool? IsPersonal { get; set; }
        public CompanionAssistanceTypeEnum? AssistanceType { get; set; }
    }
}
