using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleWebApp.Repository
{
    public interface IPredictionsRepository
    {
        void SavePrediction(string prediction);
        PredictionDto GetPredictionById(int id);
        List<PredictionDto> GetAllPredictions();
        void UpdatePrediction(PredictionDto prediction);
        void RemovePrediction(int id);
    }
}
