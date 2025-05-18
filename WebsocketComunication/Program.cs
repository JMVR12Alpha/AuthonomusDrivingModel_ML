using WebSocketSharp;

namespace WebsocketComunication
{
    class Program
    {
        static void Main(string[] args)
        {
            WS wS = new ("ws://127.0.0.1:8189");

            wS.startSocket();

            Console.ReadLine();

            wS.stopSocket();
        }
    }
}