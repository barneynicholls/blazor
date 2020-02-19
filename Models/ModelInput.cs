﻿using Microsoft.ML.Data;

namespace blazor.Models
{
    public class ModelInput
    {
        [LoadColumn(0)]
        public string SentimentText { get; set; }

        [LoadColumn(1)]
        [ColumnName("Label")]
        public bool Sentiment { get; set; }
    }
}
