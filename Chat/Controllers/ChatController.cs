using Chat.Hubs;
using Chat.RequestDTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace Chat.Controllers
{
    [Route("api/chat")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        private readonly IHubContext<ChatHub> _hubContext;
        public ChatController(IHubContext<ChatHub> hubContext)
        {
            _hubContext = hubContext;
        }

        //path looks like this: https://localhost:44379/api/chat/send
        [HttpPost("~/api/chat/send")]
        public async Task<IActionResult> SendRequest([FromBody] MessageDTO message)
        {
            await _hubContext.Clients.All.SendAsync("OnReceive", message);
            return Ok();
        }

    }
}
