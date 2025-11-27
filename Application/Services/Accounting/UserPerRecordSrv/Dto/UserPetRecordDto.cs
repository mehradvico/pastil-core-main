using Application.Common.Dto.Field;
using Application.Services.Accounting.UserPetSrv.Dto;
using Application.Services.Dto;
using Entities.Entities;
using Entities.Entities.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Accounting.UserPerRecordSrv.Dto
{
    public class UserPetRecordDto : Name_FieldDto
    {
        public long UserPetId { get; set; }
        public long OperatorId { get; set; }

        public UserPetVDto UserPet { get; set; }
        public UserMinVDto Operator { get; set; }
    }
}
