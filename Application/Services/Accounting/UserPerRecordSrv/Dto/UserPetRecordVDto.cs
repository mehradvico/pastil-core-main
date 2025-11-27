using Application.Common.Dto.Field;
using Application.Services.Accounting.UserPetSrv.Dto;
using Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Accounting.UserPerRecordSrv.Dto
{
    public class UserPetRecordVDto : Name_FieldDto
    {
        public long UserPetId { get; set; }
        public long OperatorId { get; set; }
        public DateTime CreateDate { get; set; }

        public UserPetVDto UserPet { get; set; }
        public UserMinVDto Operator { get; set; }
    }
}
