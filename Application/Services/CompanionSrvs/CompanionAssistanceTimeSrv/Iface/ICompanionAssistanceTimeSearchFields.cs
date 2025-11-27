namespace Application.Services.CompanionSrv.CompanionAssistanceTimeSrv.Iface
{
    public interface ICompanionAssistanceTimeSearchFields
    {
        public long? WeekDayId { get; set; }
        public long? CompanionAssistanceId { get; set; }
        public bool? Active { get; set; }

    }
}
