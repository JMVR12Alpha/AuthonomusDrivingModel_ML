using WebSocketSharp;
using WebSocketSharp.Server;

namespace WebsocketComunication
{
    public class WS
    {
        // create an instance of a websocket server
        private WebSocketServer WSS;

        public WS(string URL)
        {
            this.WSS = new(URL);

            this.WSS.AddWebSocketService<TestExt>("/test-ext");
            this.WSS.AddWebSocketService<TrainingCommunication>("/training");
        }

        // Methods
        
        // // Public Methods
        // Turns-on the WebSocket server
        public void startSocket()
        {
            this.WSS.Start();
        }

        // Turns-off the WebSocket server
        public void stopSocket()
        {
            this.WSS.Stop();
        }
    }
}