using Application.Common.Dto.Field;
using Application.Services.Dto;
using Application.Services.Setting.CodeSrv.Dto;
using AutoMapper.Configuration.Annotations;
using Entities.Entities;
using Entities.Entities.CommonField;
using Entities.Entities.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Application.Services.Setting.NoticeSrv.Dto
{
    public class NoticeDto : Id_FieldDto
    {
        public long? UserId { get; set; }
        public DateTime? ReadDate { get; set; }
        public long TypeId { get; set; }
        public long UserTypeId { get; set; }
        public long? ItemId { get; set; }
        public CodeVDto Type { get; set; }
        public UserMinVDto User { get; set; }
        public CodeVDto UserType { get; set; }

    }
}
