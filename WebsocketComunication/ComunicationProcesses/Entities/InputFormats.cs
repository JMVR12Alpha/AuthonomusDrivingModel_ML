namespace WebsocketComunication
{
    // Recognition of what user and what kind of user is sending data from the other side.
    public class User
    {
        public int Key { get; set; }
        public int Type { get; set; }
    }

    // This is the perception of the car of its surroundings
    public class DrivingPerceptionData
    {
        public float FrontDiagonalLeft { get; set; }
        public float FrontCenter { get; set; }
        public float FrontDiagonalRight { get; set; }
        public float Left { get; set; }
        public float Right { get; set; }
        public float BackLeft { get; set; }
        public float BackCenter { get; set; }
        public float BackRight { get; set; }
    }

    // These are the parameters that the vehicle had at the moment of sending the data to the server
    public class VehicleCurrentParams
    {
        public float Speed { get; set; }
        public float SteeringAngle { get; set; }
    }

    // This class corresponds to the perception of the vehicle position according to the roading blueprint
    public class PositionPerceptionData
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        public float WeightValue { get; set; }
    }

    // Most standared input to procede with the communication amoung client and server
    // This kind of format belongs to the in-road process.
    /**
        Proposed JSON structure:
        {
            "UsersRequest": {
                "Key": int,
                "Type": int
            },
            "DrivingData": {
                "FrontDiagonalLeft": float,
                "FrontCenter": float,
                "FrontDiagonalRight": float,
                "Left": float,
                "Right": float,
                "BackLeft": float,
                "BackCenter": float,
                "BackRight": float
            },
            "VehicleParams": {
                "Speed": float,
                "SteeringAngle": float
            },
            "PositionPerception": {
                "X": float,
                "Y": float,
                "Z": float,
                "WeightValue": float 
            }
        }
    */
    public class GeneralInput()
    {
        public User UsersRequest { get; set; }
        public DrivingPerceptionData DrivingData { get; set; }
        public VehicleCurrentParams VehicleParams { get; set; }
        public PositionPerceptionData PositionPerception { get; set; }
    }
}