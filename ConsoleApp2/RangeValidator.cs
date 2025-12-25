using System;

namespace ConsoleApp2
{
    public class RangeValidator : Validator<string>
    {
        private readonly int _min;
        private readonly int _max;

        public RangeValidator(int min, int max)
        {
            _min = min;
            _max = max;
        }

        public override bool Handle(string request)
        {
            if (!int.TryParse(request, out int number))
            {
                Console.WriteLine("Ошибка: Данные должны быть числом.");
                return false;
            }

            if (number < _min || number > _max)
            {
                Console.WriteLine($"Ошибка: Данные должны быть в диапазоне от {_min} до {_max}.");
                return false;
            }

            Console.WriteLine($"Число {number} находится в допустимом диапазоне ({_min}-{_max}).");
            return base.Handle(request);
        }
    }
}