using System;
using blazor.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.ML;

namespace blazor.Pages
{
    public class IndexBase : ComponentBase
    {
        public ModelInput Input = new ModelInput();

        [Inject]
        public PredictionEnginePool<ModelInput, ModelOutput> PredictionEnginePool { get; set; }

        public string Sentiment { get; set; }

        public void MakePrediction()
        {
            var prediction = PredictionEnginePool.Predict(Input);

            var toxic = Convert.ToBoolean(prediction.Prediction) ? "Not Toxic" : "Toxic";

            Sentiment = $"Sentiment is: {toxic} with a probability of: {prediction.Probability} score: {prediction.Score}";
        }
    }
}
