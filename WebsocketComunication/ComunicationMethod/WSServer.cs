using WebSocketSharp;
using WebSocketSharp.Server;

namespace WebsocketComunication
{
    public class WS
    {
        // create an instance of a websocket server
        private WebSocketServer WSS;

        public WS(string URL){
            this.WSS = new(URL);

            this.WSS.AddWebSocketService<TestExt>("/test-ext");
        }

        // Methods
        // // Public Methods
        // Enables the WebSocket server
        public void startSocket()
        {
            this.WSS.Start ();
        }

        // Disables the WebSocket server
        public void stopSocket()
        {
            this.WSS.Stop();
        }
    }
}