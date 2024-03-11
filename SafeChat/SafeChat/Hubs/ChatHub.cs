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
            await Clients.AllExcept(user).SendAsync("RecieveMessageAll", user, message);
        }
    }
}
