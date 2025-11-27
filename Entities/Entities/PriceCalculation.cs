using Entities.Entities.CommonField;

namespace Entities.Entities
{
    public class PriceCalculation : Id_Field
    {
        public int FromTime { get; set; }
        public int ToTime { get; set; }
        public double Price { get; set; }
        public double StopPrice { get; set; }
        public bool Deleted { get; set; }
    }
}
