using WebSocketSharp;
using WebSocketSharp.Server;

namespace WebsocketComunication
{
    class TestExt : WebSocketBehavior
    {
        // Catching incomming message
        protected override void OnMessage(MessageEventArgs e)
        {
            string msg = e.Data == "Random key"
                      ? "Appropriate key"
                      : "Incorrect key, try once more";

            Send(msg);
        }
    }
}