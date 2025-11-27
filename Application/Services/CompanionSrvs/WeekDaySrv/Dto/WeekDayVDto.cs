using Application.Common.Dto.Field;

namespace Application.Services.WeekDaySrv.WeekDaySrv.Dto
{
    public class WeekDayVDto : Name_FieldDto
    {
        public string Label { get; set; }
        public int Number { get; set; }
    }
}
