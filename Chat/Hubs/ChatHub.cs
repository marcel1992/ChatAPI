using Chat.Core.Interfaces;
using Chat.RequestDTO;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;

namespace Chat.Hubs
{
    public class ChatHub : Hub<IChatHub>
    {
        private static int _counter = 0;

        #region Override

        public override async Task OnConnectedAsync()
        {
            _counter++;
            await Clients.All.OnUpdateCountAsync(_counter);
            await base.OnConnectedAsync();
        }
        public override async Task OnDisconnectedAsync(Exception exception)
        {
            _counter--;
            await Clients.All.OnUpdateCountAsync(_counter);
            await base.OnDisconnectedAsync(exception);
        }

        #endregion

        public async Task SendMessage(MessageDTO message)
        {
            await Clients.All.OnReceiveAsync(message);
        }
    }
}
