using Application.Common.Dto.Result;
using Application.Common.Enumerable.Code;
using Application.Common.Interface;
using Application.Services.CategorySrv.Dto;
using Application.Services.CodeSrv.Dto;
using Application.Services.Setting.NoticeSrv.Dto;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Setting.NoticeSrv.Iface
{
    public interface INoticeService : ICommonSrv<Notice, NoticeDto>
    {
        NoticeSearchDto Search(NoticeInputDto baseSearchDto);
        Task<BaseResultDto<NoticeDto>> FindAsyncUserDto(long id, long? userId);
        Task InsertNoticeAsync(long itemId, NoticeTypeEnum notifTypeEnum, NoticeUserTypeEnum usernotifTypeEnum);
    }
}
