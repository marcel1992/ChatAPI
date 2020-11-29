using Chat.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Chat.Core.Interfaces
{
    public interface IChatRepository
    {
        Task<ChatModel> GetByIdAsync(int id);
        Task<IReadOnlyList<ChatModel>> GetAllAsync();
        Task AddAsync(ChatModel newMessage);
        Task UpdateAsync(ChatModel modifiedMessage);
        Task DeleteAsync(int id);
    }
}
