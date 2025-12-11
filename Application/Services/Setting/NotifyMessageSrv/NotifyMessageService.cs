using Application.Common.Enumerable;
using Application.Common.Service;
using Application.Services.Setting.NotifyMessageSrv.Dto;
using Application.Services.Setting.NotifyMessageSrv.Iface;
using AutoMapper;
using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Setting.NotifyMessageSrv
{
    public class NotifyMessageService : CommonSrv<NotifyMessage, NotifyMessageDto>, INotifyMessageService
    {
        private readonly IDataBaseContext _context;
        private readonly IMapper mapper;

        public NotifyMessageService(IDataBaseContext context, IMapper mapper)
            : base(context, mapper)
        {
            this._context = context;
            this.mapper = mapper;
        }
        public async Task SendToAllAsync(long notifyMessageId)
        {
            var msg = await _context.NotifyMessages.Include(x => x.Picture).FirstOrDefaultAsync(x => x.Id == notifyMessageId);

            if (msg == null)
                return;

            // اینجا PushService رو صدا می‌زنی (WebPush)
            // یا SignalR Notification Hub
            // مثلا:
            // await _pushService.Broadcast(msg);
        }

        // ✔ ارسال نوتیف به یک کاربر
        public async Task SendToUserAsync(long notifyMessageId, long userId)
        {
            var msg = await _context.NotifyMessages.FirstOrDefaultAsync(x => x.Id == notifyMessageId);

            if (msg == null)
                return;

            // اینجا PushService رو صدا می‌زنی
            // await _pushService.SendToUser(userId, msg);
        }
    }
}
