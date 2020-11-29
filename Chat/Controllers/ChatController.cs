using Chat.Core.Interfaces;
using Chat.Core.Models;
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
        private readonly IChatRepository _chatRepository;

        public ChatController(IHubContext<ChatHub> hubContext, IChatRepository chatRepository)
        {
            _hubContext = hubContext;
            _chatRepository = chatRepository;
        }

        //path looks like this: https://localhost:44379/api/chat/send
        [HttpPost("~/api/chat/send")]
        public async Task<IActionResult> SendRequest([FromBody] MessageDTO message)
        {
            var chatMessage = new ChatModel()
            {
                Id = message.Id,
                FromUser = message.FromUser,
                ToUser = message.ToUser,
                CreationDate = message.CreationDate,
                LastEditDate = message.LastModifiedDate,
                Message = message.Message,
                IsOnline = message.IsOnline
            };

            await _chatRepository.AddAsync(chatMessage);
            await _hubContext.Clients.All.SendAsync("OnReceive", message);
            return Ok();
        }


    }
}
