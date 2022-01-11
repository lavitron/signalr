using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace WebAPI.Hubs
{

    public class ChatHub : Hub<IChatClient>
    {
        public class ChatMessage
        {
            public string User { get; set; }

            public string Message { get; set; }
        }
        public async Task SendMessage(ChatMessage message)
        {
            await Clients.All.ReceiveMessage(message);
        }

    }
}
