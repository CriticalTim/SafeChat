using Microsoft.AspNetCore.SignalR;

namespace SafeChat.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message) 
        { 
            await Clients.All.SendAsync("RecieveMessage", user, message);
        }

        public async Task IsConnected(string user)
        {
            await Clients.All.SendAsync("ConnectionSuccess", user);
        }
    }
}
