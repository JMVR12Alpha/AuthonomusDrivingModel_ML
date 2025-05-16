using Newtonsoft.Json;

namespace WebsocketComunication
{
    public class IncommingData
    {
        public bool ValidateData(string incommingMessage, ref GeneralInput recipient)
        {
            bool isValid = false;
            try
            {
                recipient = JsonConvert.DeserializeObject<GeneralInput>(incommingMessage);
                isValid = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nAn Error was detected (from IncommingData::ValidateData)\n\n\t{ex.Message}\n");
            }

            return isValid;
        }
    }
}