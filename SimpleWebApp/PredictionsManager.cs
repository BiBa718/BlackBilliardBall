using System;
using SimpleWebApp.Repository;
using System.Collections.Generic;
using System.Linq;

namespace SimpleWebApp
{
	public class PredictionsManager
	{
		private Random rnd = new Random();
		IPredictionsRepository _repository = new PredictionsDatabaseRepository();

		public PredictionsManager(IPredictionsRepository repository)
		{
			_repository = repository;
		}

		public List<Prediction> GetAllPredictions()
		{
			return _repository.GetAllPredictions().Select(dto => new Prediction(dto.PredictionText)).ToList();
		}

		public Prediction GetRandomPrediction()
		{			
			List<Prediction> prs = _repository.GetAllPredictions().Select(dto => new Prediction(dto.PredictionText)).ToList();
			return prs[new Random().Next(prs.Count)];
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
