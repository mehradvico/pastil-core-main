namespace Application.Services.CompanionSrvs.CompanionUserSrv.Iface
{
    public interface ICompanionUserSearchFields
    {
        public long? CompanionId { get; set; }
        public long? UserId { get; set; }
        public bool? UserAccept { get; set; }
        public bool AllUserAccept { get; set; }
        public bool? Active { get; set; }

    }
}
