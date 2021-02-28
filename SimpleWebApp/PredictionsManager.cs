using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleWebApp
{
    public class PredictionsManager
    {
        private Random rnd = new Random();
        private List<string> predictions = new List<string>()
        {
            "Да",
            "Нет",
            "Не знаю"
        };

        public string GetRandomPrediction()
        {
            int randomNumber = rnd.Next(0, predictions.Count);
            return predictions[randomNumber];
        }

        public void AddPrediction(string prediction)
        {
            predictions.Add(prediction);
        }
    }
}
