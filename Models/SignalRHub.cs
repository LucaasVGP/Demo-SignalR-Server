using Microsoft.AspNetCore.SignalR;

namespace DemoSignalR.Models
{
	public class SignalRHub : Hub
	{
		public async Task SendMessage(string message)
		{
			await Clients.All.SendAsync("ReceiveMessage", message);
		}
	}
}
