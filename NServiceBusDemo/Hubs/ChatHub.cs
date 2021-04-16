using Microsoft.AspNetCore.SignalR;
using NServiceBusDemo.Hubs.Clients;

namespace NServiceBusDemo.Hubs
{
    public class ChatHub : Hub<IChatClient>
    {}
}
