using WebSocketSharp;
using WebSocketSharp.Server;

namespace WebsocketComunication
{
    public class TrainingCommunication : WebSocketBehavior
    {
        private IncommingData IncData;
        private OutgoingData OutData;

        public TrainingCommunication()
        {
            IncData = new();
            OutData = new();
        }

        protected override void OnMessage(MessageEventArgs e)
        {
            GeneralInput recipient = new();

            if (IncData.ValidateData(e.Data, ref recipient))
            {
                // Example correct output data
                Send(OutData.Response(new(
                    200,
                    "Data propperly Processed!",
                    new OutputData(
                        0.00f,
                        0.00f
                    )
                )));
            }
            else
            {
                // Example Incorrect output data
                Send(OutData.Response(new(
                    500,
                    "The data was not processed propperly!",
                    new OutputData(
                        0.00f,
                        0.00f
                    )
                )));
            }
        }
    }
}