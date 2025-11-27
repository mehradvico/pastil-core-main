using Application.Common.Dto.Input;
using Application.Services.Accounting.UserPerRecordSrv.Iface;
using Application.Services.Accounting.UserPetSrv.Iface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Accounting.UserPerRecordSrv.Dto
{
    public class UserPetRecordInputDto : BaseInputDto, IUserPetRecordSearchFields
    {
        public long? UserPetId { get; set; }
        public long? UserId { get; set; }
        public long? OperatorId { get; set; }
    }
}
