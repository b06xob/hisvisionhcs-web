using HisVisionHCS.Web.Models;
using System.Security.Cryptography;

namespace HisVisionHCS.Web.Services
{
    public interface ICaptchaService
    {
        CaptchaQuestion GenerateQuestion();
        bool ValidateAnswer(string userAnswer, int expectedAnswer);
    }

    public class CaptchaService : ICaptchaService
    {
        private readonly Random _random;

        public CaptchaService()
        {
            _random = new Random();
        }

        public CaptchaQuestion GenerateQuestion()
        {
            // Generate simple math problems that are easy for humans but harder for bots
            var questionTypes = new[]
            {
                () => GenerateAdditionQuestion(),
                () => GenerateSubtractionQuestion(),
                () => GenerateSimpleMultiplicationQuestion()
            };

            var selectedType = questionTypes[_random.Next(questionTypes.Length)];
            return selectedType();
        }

        private CaptchaQuestion GenerateAdditionQuestion()
        {
            var num1 = _random.Next(1, 20);
            var num2 = _random.Next(1, 20);
            var answer = num1 + num2;
            
            return new CaptchaQuestion
            {
                Question = $"What is {num1} + {num2}?",
                Answer = answer
            };
        }

        private CaptchaQuestion GenerateSubtractionQuestion()
        {
            var num1 = _random.Next(10, 30);
            var num2 = _random.Next(1, num1); // Ensure positive result
            var answer = num1 - num2;
            
            return new CaptchaQuestion
            {
                Question = $"What is {num1} - {num2}?",
                Answer = answer
            };
        }

        private CaptchaQuestion GenerateSimpleMultiplicationQuestion()
        {
            var num1 = _random.Next(2, 10);
            var num2 = _random.Next(2, 10);
            var answer = num1 * num2;
            
            return new CaptchaQuestion
            {
                Question = $"What is {num1} × {num2}?",
                Answer = answer
            };
        }

        public bool ValidateAnswer(string userAnswer, int expectedAnswer)
        {
            if (string.IsNullOrWhiteSpace(userAnswer))
                return false;

            if (int.TryParse(userAnswer.Trim(), out int parsedAnswer))
            {
                return parsedAnswer == expectedAnswer;
            }

            return false;
        }
    }
}
