using Microsoft.AspNetCore.SignalR;

namespace SignalRSample.Hubs
{
    public class NotificationHub : Hub
    {
        public async Task SendNotificationAsync(string jsonData)
        {
            await Clients.All.SendAsync("receiveData", jsonData);
        }
    }
}
