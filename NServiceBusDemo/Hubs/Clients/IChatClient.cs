using NServiceBusDemo.Models;
using System.Threading.Tasks;

namespace NServiceBusDemo.Hubs.Clients
{
    public interface IChatClient
    {
        Task RecieveMessage(ChatMessage message);
    }
}
