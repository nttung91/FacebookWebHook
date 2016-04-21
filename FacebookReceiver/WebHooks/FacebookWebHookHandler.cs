using System.Threading.Tasks;
using Microsoft.AspNet.WebHooks;
using Newtonsoft.Json.Linq;

namespace FacebookReceiver.WebHooks
{
    public class DropboxWebHookHandler : WebHookHandler
    {
        public DropboxWebHookHandler()
        {
            this.Receiver = FacebookWebHookReceiver.ReceiverName;
        }

        public override Task ExecuteAsync(string generator, WebHookHandlerContext context)
        {
            JObject entry = context.GetDataOrDefault<JObject>();

            return Task.FromResult(true);
        }
    }
}