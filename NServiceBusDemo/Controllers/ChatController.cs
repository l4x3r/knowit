using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using NServiceBusDemo.Hubs;
using NServiceBusDemo.Hubs.Clients;
using NServiceBusDemo.Models;
using System.Threading.Tasks;

namespace NServiceBusDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChatController : ControllerBase
    {
        private readonly IHubContext<ChatHub, IChatClient> _chatHub;

        public ChatController(IHubContext<ChatHub, IChatClient> chatHub)
        {
            _chatHub = chatHub;
        }

        [HttpPost("messages")]
        public async Task Post(ChatMessage message)
        {
            await _chatHub.Clients.All.RecieveMessage(message);
        }
    }
}
