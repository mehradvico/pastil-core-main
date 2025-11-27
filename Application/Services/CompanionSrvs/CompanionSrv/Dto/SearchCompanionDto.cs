using Application.Common.Dto.Field;
using Application.Services.Filing.PictureSrv.Dto;

namespace Application.Services.CompanionSrvs.CompanionSrv.Dto
{
    public class SearchCompanionDto : Name_FieldDto
    {
        public long? IconId { get; set; }
        public double RateAvg { get; set; }
        public int RateCount { get; set; }
        public PictureVDto Icon { get; set; }
    }
}
