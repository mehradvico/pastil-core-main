using Application.Common.Interface;
using Application.Services.Setting.NotifyMessageSrv.Dto;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Setting.NotifyMessageSrv.Iface
{
    public interface INotifyMessageService : ICommonSrv<NotifyMessage, NotifyMessageDto>
    {
        Task SendToAllAsync(long notifyMessageId);
        Task SendToUserAsync(long notifyMessageId, long userId);
    }
}
