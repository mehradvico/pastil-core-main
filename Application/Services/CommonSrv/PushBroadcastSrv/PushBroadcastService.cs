using Application.Common.Dto.Result;
using Application.Services.CommonSrv.PushBroadcastSrv.Dto;
using Application.Services.CommonSrv.PushBroadcastSrv.Iface;
using Application.Services.CommonSrv.PushSubscriptionSrv.Dto;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Persistence.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WebPush;

namespace Application.Services.CommonSrv.PushBroadcastSrv
{
    public class PushBroadcastService : IPushBroadcastService
    {
        private readonly IDataBaseContext _context;
        private readonly VapidKeysOption _vapid;

        public PushBroadcastService(IDataBaseContext context, IOptions<VapidKeysOption> vapid)
        {
            _context = context;
            _vapid = vapid.Value;
        }

        public async Task<BaseResultDto> BroadcastAsync(PushBroadcastDto dto)
        {
            var client = new WebPushClient();
            var vapid = new VapidDetails("mailto:admin@pastil.pet", _vapid.PublicKey, _vapid.PrivateKey);

            var payload = JsonSerializer.Serialize(new
            {
                title = dto.Title,
                body = dto.Body,
                url = dto.Url,
                icon = dto.Icon,
                tag = dto.Tag
            });

            var subs = await _context.PushSubscriptions
                .Where(x => x.IsActive).ToListAsync();

            int sent = 0, failed = 0;

            foreach (var s in subs)
            {
                try
                {
                    var sub = new PushSubscription(s.Endpoint, s.P256dh, s.Auth);
                    await client.SendNotificationAsync(sub, payload, vapid);
                    sent++;
                    s.LastSeen = DateTime.UtcNow;
                }
                catch (WebPushException ex)
                {
                    failed++;

                    if (ex.StatusCode == System.Net.HttpStatusCode.Gone ||
                        ex.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        s.IsActive = false;
                    }
                }
            }

            await _context.SaveChangesAsync();
            return new BaseResultDto(true, $"sent:{sent}, failed:{failed}");
        }
    }
}
