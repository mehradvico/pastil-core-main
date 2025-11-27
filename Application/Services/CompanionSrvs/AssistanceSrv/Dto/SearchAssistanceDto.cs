using Application.Common.Dto.Field;
using Application.Services.Filing.PictureSrv.Dto;

namespace Application.Services.CompanionSrvs.AssistanceSrv.Dto
{
    public class SearchAssistanceDto : Name_FieldDto
    {
        public long? PictureId { get; set; }
        public PictureVDto Picture { get; set; }

    }
}
