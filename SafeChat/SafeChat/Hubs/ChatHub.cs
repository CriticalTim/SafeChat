using Microsoft.AspNetCore.SignalR;

namespace SafeChat.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message) 
        { 

            await Clients.All.SendAsync("RecieveMessage", user, message);

        }

        public async Task SendMessageExceptUser(string user, string message)
        {
            await Clients.AllExcept(user).SendAsync("RecieveMessage", user, message);
        }

        public async Task IsConnecting(string user)
        {
            await Clients.All.SendAsync("ConnectionSuccess", user);
        }
    }
}
