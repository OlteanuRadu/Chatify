using Microsoft.AspNet.SignalR;
using Microsoft.Owin.Cors;
using Owin;

namespace Chatify.Server
{

    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCors(CorsOptions.AllowAll);
            app.MapSignalR("/signalchat", new HubConfiguration());

            GlobalHost.Configuration.MaxIncomingWebSocketMessageSize = null;
        }
    }
}
