using Chat.Core.Interfaces;
using Chat.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Chat.Core.Models
{
    public class ChatRepository : IChatRepository
    {
        private readonly StoreContext _context;

        public ChatRepository(StoreContext context)
        {
            _context = context;
        }
        public async Task AddAsync(ChatModel newMessage)
        {
            _context.Chats.Add(newMessage);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var message = await _context.Chats.FirstOrDefaultAsync(x => x.Id == id);
            if (message != null)
            {
                _context.Remove(message);
                await _context.SaveChangesAsync();
            }
        }
        public async Task<IReadOnlyList<ChatModel>> GetAllAsync()
        {
            return await _context.Chats.ToListAsync();
        }
        public async Task<ChatModel> GetByIdAsync(int id)
        {
            return await _context.Chats.FirstOrDefaultAsync(x => x.Id == id);
        }   
        public async Task UpdateAsync(ChatModel modifiedMessage)
        {
            _context.Chats.Update(modifiedMessage);
            await _context.SaveChangesAsync();
        }
    }
}
