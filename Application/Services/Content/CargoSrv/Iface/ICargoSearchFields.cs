using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Content.CargoSrv.Iface
{
    public interface ICargoSearchFields
    {
        public long? FromStateId { get; set; }
        public long? ToStateId { get; set; }
        public long? FromCountryId { get; set; }
        public long? ToCountryId { get; set; }
        public long? UserPetId { get; set; }
        public long? UserId { get; set; }
        public bool? IsAccompany { get; set; }
        public bool? IsPaid { get; set; }
        public long? StatusId { get; set; }
    }
}
