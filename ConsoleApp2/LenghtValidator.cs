using System;

namespace ConsoleApp2
{
    public class LengthValidator : Validator<string>
    {
        private readonly int _minLength;

        public LengthValidator(int minLength = 5)
        {
            _minLength = minLength;
        }

        public override bool Handle(string request)
        {
            if (request.Length < _minLength)
            {
                Console.WriteLine($"Ошибка: Длина данных должна быть не менее {_minLength} символов.");
                return false;
            }

            Console.WriteLine($"Длина данных валидна (не менее {_minLength} символов).");
            return base.Handle(request);
        }
    }
}