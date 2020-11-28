using Chat.RequestDTO;
using System.Threading.Tasks;

namespace Chat.Interfaces
{
    public interface IChatHub
    {
        Task UpdateCountAsync(int count);
        Task OnReceiveAsync(MessageDTO message);
    }
}
