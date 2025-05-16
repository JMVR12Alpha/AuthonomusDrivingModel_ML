using Newtonsoft.Json;

namespace WebsocketComunication
{
    public class OutgoingData
    {
        // Expecting for more detailed checking in the response, but for now this approach works
        public string Response(GeneralResponse response)
        {
            return JsonConvert.SerializeObject(response);
        }
    }
}