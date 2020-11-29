using Chat.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Chat.Core.Interfaces
{
    public interface IUserRepository
    {
        Task<IReadOnlyList<UserModel>> GetAllAsync();
        Task<UserModel> GetByIdAsync(int id);
        Task AddAsync(UserModel newUser);
        Task UpdateAsync(UserModel modifiedUser);
        Task DeleteAsync(int id);
    }
}
