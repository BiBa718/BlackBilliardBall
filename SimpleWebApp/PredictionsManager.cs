using System;
using SimpleWebApp.Repository;
using System.Collections.Generic;
using System.Linq;

namespace SimpleWebApp
{
	public class PredictionsManager
	{
		private Random rnd = new Random();
		IPredictionsRepository _repository;

		public PredictionsManager(IPredictionsRepository repository)
		{
			_repository = repository;
		}

		public List<Prediction> GetAllPredictions()
		{
			return _repository.GetAllPredictions().Select(dto => new Prediction(dto.Id, dto.PredictionText)).ToList();
		}

		public Prediction GetRandomPrediction()
		{			
			List<Prediction> prs = _repository.GetAllPredictions().Select(dto => new Prediction(dto.PredictionText)).ToList();
            if (prs.Count == 0)
            {
				return new Prediction("");
            }
            else
			{
				return prs[new Random().Next(0, prs.Count)];
			}
		}

		public void AddPrediction(string prediction)
		{
			_repository.SavePrediction(prediction);
		}

		internal void DeletePrediction(int predictionNumber)
		{
			_repository.RemovePrediction(predictionNumber);
		}

		internal void UpdatePrediction(PredictionUpdateRequest request)
		{
			_repository.UpdatePrediction(new PredictionDto() { PredictionText = request.NewText, Id = request.PredictionNumber });
		}
	}
}
