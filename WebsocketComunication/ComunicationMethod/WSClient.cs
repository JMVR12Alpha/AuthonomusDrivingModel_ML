using WebSocketSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Configuration.Assemblies;

namespace WebsocketComunication
{
    public class WSClient
    {
        private WebSocket client;

        // Initialize the WebSocket client
        public WSClient(string URL)
        {
            this.client = new(URL);
            this.client.Connect();

            this.client.OnError += (sender, e) =>
            {
                on_error(sender, e);
            };
            this.client.OnClose += (sender, e) =>
            {
                on_close(sender, e);
            };
        }

        // Methods

        // // private Methods
        private static void on_error(object? sender, WebSocketSharp.ErrorEventArgs e)
        {
            Console.WriteLine("An error has occurred: ", e.Message);
        }

        private static void on_close(object? sender, CloseEventArgs e)
        {
            Console.WriteLine($"*-*-*-*-*-*-* Connection closed *-*-*-*-*-*-* \n\tCode: {e.Code} \n\tReason: {e.Reason}");
        }

        // In the future change this method to procede according to random or customized received data.
        private void on_message(object? sender, MessageEventArgs e) 
        {
            Console.WriteLine($"We've just recived the message: {e.Data}");
        }

        // // Public Methods
        public void closingConnection()
        {
            this.client.Close();
        }

        public void send(string message)
        {
            this.client.Send(message);
        }

    }
}