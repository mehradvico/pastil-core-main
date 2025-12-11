using Application.Services.Setting.PushMessageSrv.Dto;
using Application.Services.Setting.PushMessageSrv.Iface;
using AutoMapper;
using Entities.Entities;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Persistence.Interface;
using System.Linq;
using System.Threading.Tasks;
using WebPush;

namespace Application.Services.Setting.PushMessageSrv
{
    public class PushService : IPushService
    {
        private readonly IDataBaseContext _context;
        private readonly IConfiguration _config;
        private readonly VapidDetails vapidDetails;
        private readonly WebPushClient webPushClient;

        public PushService(IDataBaseContext context, IConfiguration config)
        {
            _context = context;

            vapidDetails = new VapidDetails(

                config["Vapid:Subject"],
                config["Vapid:PublicKey"],
                config["Vapid:PrivateKey"]
            );

            webPushClient = new WebPushClient();
        }

        public async Task SendAsync(PushMessageDto message, long userId)
        {
            var subscriber = _context.PushSubscribers
                                     .FirstOrDefault(x => x.UserId == userId);

            if (subscriber == null)
                return;

            await SendNotification(subscriber, message);
        }

        public async Task SendToAllAsync(PushMessageDto message)
        {
            var subscribers = _context.PushSubscribers.ToList();

            foreach (var s in subscribers)
            {
                await SendNotification(s, message);
            }
        }

        private async Task SendNotification(PushSubscriber sub, PushMessageDto msg)
        {
            var payload = JsonConvert.SerializeObject(new
            {
                title = msg.Title,
                body = msg.Body,
                icon = msg.Icon,
                url = msg.Url
            });

            var subscription = new PushSubscription(
                sub.Endpoint,
                sub.P256dh,
                sub.Auth
            );

            try
            {
                var client = new WebPushClient();
                await client.SendNotificationAsync(subscription, payload, vapidDetails);
            }
            catch (WebPushException ex)
            {
                // اگر کاربر اشتراک را حذف کرده بود → پاکش می‌کنیم
                if (ex.StatusCode == System.Net.HttpStatusCode.Gone ||
                    ex.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    _context.PushSubscribers.Remove(sub);
                    await _context.SaveChangesAsync();
                }
            }
        }

        public async Task RegisterAsync(PushSubscriptionDto dto)
        {
            var sub = _context.PushSubscribers
                              .FirstOrDefault(x => x.UserId == dto.UserId);

            if (sub == null)
            {
                sub = new PushSubscriber
                {
                    UserId = dto.UserId,
                    Endpoint = dto.Endpoint,
                    P256dh = dto.P256dh,
                    Auth = dto.Auth
                };

                _context.PushSubscribers.Add(sub);
            }
            else
            {
                sub.Endpoint = dto.Endpoint;
                sub.P256dh = dto.P256dh;
                sub.Auth = dto.Auth;
            }

            await _context.SaveChangesAsync();
        }

        public async Task SendLastMessageAsync()
        {
            var msg = _context.NotifyMessages
                    .OrderByDescending(x => x.Id)
                    .Select(x => new PushMessageDto
                    {
                        Title = x.Title,
                        Body = x.Message,
                        Url = x.Url,
                        Icon = _context.Pictures
                                .Where(p => p.Id == x.PictureId)
                                .Select(p => p.DirectUrl)
                                .FirstOrDefault()
                    })
                    .FirstOrDefault();

            if (msg != null)
                await SendToAllAsync(msg);
        }
        public async Task SendToUserAsync(long userId, PushMessageDto message)
        {
            var subs = _context.PushSubscribers
                .Where(x => x.UserId == userId)
                .ToList();

            foreach (var s in subs)
            {
                var subscription = new PushSubscription(s.Endpoint, s.P256dh, s.Auth);
                await webPushClient.SendNotificationAsync(subscription, JsonConvert.SerializeObject(message), vapidDetails);
            }
        }

    }
}
