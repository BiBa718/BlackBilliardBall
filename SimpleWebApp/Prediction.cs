namespace SimpleWebApp
{
    public class Prediction
    {
        public string PredictionString { get; }
        public int PredictionId { get; }

        public Prediction(){}

        public Prediction(string predictionString)
        {
            PredictionString = predictionString;
        }

        public Prediction(int predictionId, string predictionString)
        {
            PredictionString = predictionString;
            PredictionId = predictionId;
        }
    }
}