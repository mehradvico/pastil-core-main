using Application.Common.Dto.Result;
using Application.Services.Setting.NotifyMessageSrv.Iface;
using AutoMapper;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Setting.NotifyMessageSrv.Dto
{
    public class NotifyMessageSearchDto : BaseSearchDto<NotifyMessage, NotifyMessageVDto>, INotifyMessageSearchFields
    {
        public NotifyMessageSearchDto(NotifyMessageInputDto dto, IQueryable<NotifyMessage> list, IMapper mapper) : base(dto, list, mapper)
        {
        }
    }
}
