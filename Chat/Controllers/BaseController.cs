using Chat.Hubs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace Chat.Controllers
{
    public class BaseController: ControllerBase
    {
        public readonly IHubContext<ChatHub> HubContext;

        public BaseController(IHubContext<ChatHub> hubContext)
        {
            HubContext = hubContext;
        }
    }
}
