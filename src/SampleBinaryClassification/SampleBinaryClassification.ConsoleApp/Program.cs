//*****************************************************************************************
//*                                                                                       *
//* This is an auto-generated file by Microsoft ML.NET CLI (Command-Line Interface) tool. *
//*                                                                                       *
//*****************************************************************************************

using System;
using System.IO;
using System.Linq;
using Microsoft.ML;
using SampleBinaryClassification.Model.DataModels;

namespace SampleBinaryClassification.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsumeModel("Hello every body");
            ConsumeModel("How are you");
            ConsumeModel("What to fuck");
            ConsumeModel("That is rude.");
        }

        static void ConsumeModel(string word)
        {
            var context = new MLContext();
            var model = context.Model.Load($"./src/SampleBinaryClassification/SampleBinaryClassification.Model/MLModel.zip", out var schema);
            var prediction = context.Model.CreatePredictionEngine<ModelInput, ModelOutput>(model);

            var input = new ModelInput();
            input.SentimentText = word;

            var result = prediction.Predict(input);
            var toxic = Convert.ToBoolean(result.Prediction) ? "Toxic" : "Non Toxic";
            Console.WriteLine($"Text: {input.SentimentText} | Predcition: {toxic}");
        }
    }
}