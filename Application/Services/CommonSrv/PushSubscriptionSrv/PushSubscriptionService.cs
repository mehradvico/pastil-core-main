using Application.Common.Dto.Result;
using Application.Services.CommonSrv.PushSubscriptionSrv.Dto;
using Application.Services.CommonSrv.PushSubscriptionSrv.Iface;
using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CommonSrv.PushSubscriptionSrv
{
    public class PushSubscriptionService : IPushSubscriptionService
    {
        private readonly IDataBaseContext _context;

        public PushSubscriptionService(IDataBaseContext context)
        {
            _context = context;
        }

        public async Task<BaseResultDto> SubscribeAsync(long? userId, PushSubscribeDto dto)
        {
            var sub = await _context.PushSubscriptions
                .FirstOrDefaultAsync(x => x.Endpoint == dto.Endpoint);

            if (sub == null)
            {
                sub = new PushSubscription
                {
                    Endpoint = dto.Endpoint,
                    P256dh = dto.Keys.P256dh,
                    Auth = dto.Keys.Auth,
                    UserAgent = dto.UserAgent,
                    IsActive = true,
                    CreateDate = DateTime.UtcNow,
                    UserId = null
                };
                _context.PushSubscriptions.Add(sub);
            }
            else
            {
                sub.P256dh = dto.Keys.P256dh;
                sub.Auth = dto.Keys.Auth;
                sub.UserAgent = dto.UserAgent;
                sub.IsActive = true;
                sub.LastSeen = DateTime.UtcNow;
            }

            await _context.SaveChangesAsync();
            return new BaseResultDto(true);
        }
    }
}
