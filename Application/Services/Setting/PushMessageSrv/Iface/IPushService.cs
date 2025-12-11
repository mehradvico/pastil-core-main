using Application.Services.Setting.PushMessageSrv.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Setting.PushMessageSrv.Iface
{
    public interface IPushService
    {
        Task SendAsync(PushMessageDto message, long userId);
        Task SendToAllAsync(PushMessageDto message);
        Task RegisterAsync(PushSubscriptionDto dto);
        Task SendLastMessageAsync();
        Task SendToUserAsync(long userId, PushMessageDto message);
    }
}
