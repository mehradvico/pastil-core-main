using Application.Common.Dto.Field;
using Application.Services.Filing.PictureSrv.Dto;

namespace Application.Services.ProductSrvs.ProductSrv.Dto
{
    public class SearchProductDto : Name_FieldDto
    {
        public string SecondName { get; set; }
        public string CategoryName { get; set; }
        public string BrandName { get; set; }
        public long BasePrice { get; set; }
        public long Price { get; set; }
        public int DiscountPercent { get; set; }
        public PictureVDto Picture { get; set; }
    }
}
