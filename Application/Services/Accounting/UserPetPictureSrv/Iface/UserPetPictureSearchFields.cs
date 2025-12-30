using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Accounting.UserPetPictureSrv.Iface
{
    public interface IUserPetPictureSearchFields
    {
        public long? UserPetId { get; set; }
        public long? UserId { get; set; }
    }
}
