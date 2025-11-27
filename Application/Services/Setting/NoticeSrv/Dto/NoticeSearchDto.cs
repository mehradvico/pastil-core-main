using Application.Common.Dto.Result;
using Application.Services.CategorySrv.Dto;
using Application.Services.CategorySrv.Iface;
using Application.Services.Setting.NoticeSrv.Iface;
using AutoMapper;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Setting.NoticeSrv.Dto
{
    public class NoticeSearchDto : BaseSearchDto<Notice, NoticeVDto>, INoticeSearchFields
    {
        public NoticeSearchDto(NoticeInputDto dto, IQueryable<Notice> list, IMapper mapper) : base(dto, list, mapper)
        {
            UserId = dto.UserId;
            IsRead = dto.IsRead;
            TypeId = dto.TypeId;
        }

        public long? UserId { get; set; }
        public bool? IsRead { get; set; }
        public long? TypeId { get; set; }
    }
}
