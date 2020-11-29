using Chat.Core.Interfaces;
using Chat.Core.Models;
using Chat.Hubs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Chat.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : BaseController
    {
        private readonly IUserRepository _repository;

        public UserController(IHubContext<ChatHub> hubContext, IUserRepository userRepository) : base(hubContext)
        {
            _repository = userRepository;
        }

        //path looks like this: https://localhost:44379/api/user/getAll
        [HttpGet("~/api/user/getAll")]
        public async Task<ActionResult<IReadOnlyList<UserModel>>> GetAllAsync() =>  Ok(await _repository.GetAllAsync());
        
        [HttpGet("~/api/user/getById/{id}")]
        public async Task<ActionResult<UserModel>> GetByIdAsync(int id) => Ok(await _repository.GetByIdAsync(id));

        [HttpPost("~/api/user/add")]
        public async Task<ActionResult> AddAsync([FromBody] UserModel newUser)
        {
            await _repository.AddAsync(newUser);
            return Ok();
        }

        [HttpPut("~/api/user/update")]
        public async Task<ActionResult> UpdateAsync([FromBody] UserModel modifiedUser)
        {
            await _repository.UpdateAsync(modifiedUser);
            return Ok();
        }

        [HttpDelete("~/api/user/delete/{id}")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
            return Ok();
        }
    }
}
