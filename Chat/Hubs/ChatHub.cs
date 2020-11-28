using Chat.RequestDTO;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;

namespace Chat.Hubs
{
    public class ChatHub : Hub
    {
        #region Override

        public override Task OnConnectedAsync()
        {
            return base.OnConnectedAsync();
        }
        public override Task OnDisconnectedAsync(Exception exception)
        {
            return base.OnDisconnectedAsync(exception);
        }

        #endregion

        public Task SendMessage(MessageDTO message)
        {
            return Clients.All.SendAsync("OnReceive", message);
        }
    }
}
