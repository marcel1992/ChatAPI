using Chat.RequestDTO;
using System.Threading.Tasks;

namespace Chat.Core.Interfaces
{
    public interface IChatHub
    {
        Task OnUpdateCountAsync(int count);
        Task OnReceiveAsync(MessageDTO message);
    }
}
