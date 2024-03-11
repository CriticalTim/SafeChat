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

        public async Task IAmOnline(string user)
        {
            await Clients.All.SendAsync("Connected", user);
            await Clients.All.SendAsync("ReceiveMessage", user, "has connected.");
        }

        //public async Task IAmOffline(string user)
        //{
        //    await Clients.All.SendAsync("Disconnected", user);
        //    await Clients.All.SendAsync("ReceiveMessage", user, "has disconnected.");
        //}

        //public async Task OnConnectedAsync(Exception exception)
        //{
        //    string? user = Context.ConnectionId; // Or a more user-friendly identifier
        //    await Clients.All.SendAsync("ReceiveMessage", user, "has connected.");
        //    await Clients.All.SendAsync("Connected", user);
        //    await base.OnConnectedAsync();
        //}

        //public override async Task OnDisconnectedAsync(Exception exception)
        //{
        //    string? user = Context.ConnectionId; // Or a more user-friendly identifier
        //    await Clients.All.SendAsync("ReceiveMessage", user, "has disconnected.");
        //    await Clients.All.SendAsync("Disconnected", user);
        //    await base.OnDisconnectedAsync(exception);
        //}



    }
}
