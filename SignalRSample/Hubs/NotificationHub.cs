using Microsoft.AspNetCore.SignalR;
using System.Diagnostics.Metrics;

namespace SignalRSample.Hubs
{
    public class NotificationHub : Hub
    {
        public async Task SendMessageAsync(string message)
        {
            await Clients.All.SendAsync("receiveMessage", message);
        }
        public async Task SendNotificationAsync()
        {
            await Clients.All.SendAsync("receiveNotify", "Döngü çalıştı");
        }
    }
}
