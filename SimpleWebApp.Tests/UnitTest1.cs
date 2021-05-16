using System;
using Xunit;
using SimpleWebApp.Repository;

namespace SimpleWebApp.Tests
{
    public class UnitTest1
    {
		[Fact]
		public void SavePredictionTest()
		{
			PredictionsDatabaseRepository repository = new PredictionsDatabaseRepository();
			repository.SavePrediction(new PredictionDto() { PredictionText = "test text" });
		}

		[Fact]
		public void GetPredictionByIdTest()
		{
			PredictionsDatabaseRepository repository = new PredictionsDatabaseRepository();
			var result = repository.GetPredictionById(1);
		}

		[Fact]
		public void GetAllPredictionsTest()
		{
			PredictionsDatabaseRepository repository = new PredictionsDatabaseRepository();
			var result = repository.GetAllPredictions();
		}

		[Fact]
		public void RemovePredictionTest()
		{
			PredictionsDatabaseRepository repository = new PredictionsDatabaseRepository();
			repository.RemovePrediction(1);
		}
	}
}
