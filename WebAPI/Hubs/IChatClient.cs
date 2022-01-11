using System.Threading.Tasks;
using static WebAPI.Hubs.ChatHub;

namespace WebAPI.Hubs
{
    public interface IChatClient
    {
        Task ReceiveMessage(ChatMessage message);
    }
}
