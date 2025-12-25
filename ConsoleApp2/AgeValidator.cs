using System;

namespace ConsoleApp2
{
    public class AgeValidator : Validator<User>
    {
        private readonly int _minAge;
        private readonly int _maxAge;

        public AgeValidator(int minAge = 18, int maxAge = 100)
        {
            _minAge = minAge;
            _maxAge = maxAge;
        }

        public override bool Handle(User request)
        {
            if (request.Age < _minAge || request.Age > _maxAge)
            {
                Console.WriteLine($"Ошибка: Возраст должен быть от {_minAge} до {_maxAge} лет.");
                return false;
            }

            Console.WriteLine("Возраст валиден.");
            return base.Handle(request);
        }
    }
}