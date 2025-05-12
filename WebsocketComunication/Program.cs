using WebSocketSharp;

namespace WebsocketComunication
{
    class Program
    {
        static void Main(string[] args)
        {
            WS firstWS = new ("ws://127.0.0.1:8189");

            firstWS.startSocket();

            Console.ReadKey (true);

            firstWS.stopSocket();
        }
    }
}