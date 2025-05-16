namespace WebsocketComunication
{
    public class GeneralResponse
    {
        public GeneralResponse(int code, string message, OutputData data)
        {
            this.Code       = code;
            this.Message    = message;
            this.Data       = data;
        }
        public int Code { get; set; }
        public string Message { get; set; }

        public OutputData Data { get; set;}
    }

    public class OutputData
    {
        public OutputData(float speed, float steeringAngle)
        {
            this.Speed          = speed;
            this.SteeringAngle  = steeringAngle;
        }
        public float Speed { get; set; }
        public float SteeringAngle { get; set; }
    }
}