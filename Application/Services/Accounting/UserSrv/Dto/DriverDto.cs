using Application.Common.Dto.LocationPoint;

namespace Application.Services.Accounting.UserSrv.Dto
{
    public class DriverDto
    {
        public long UserId { get; set; }
        public string Name { get; set; }
        public string UserToken { get; set; }
        public string ConnctionId { get; set; }

        public PointDto Location { get; set; }
    }
}
