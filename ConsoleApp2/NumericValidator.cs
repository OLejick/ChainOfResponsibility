using System;

namespace ConsoleApp2
{
    public class NumericValidator : Validator<string>
    {
        public override bool Handle(string request)
        {
            if (!int.TryParse(request, out int number))
            {
                Console.WriteLine("Ошибка: Данные должны быть числом.");
                return false;
            }

            Console.WriteLine($"Данные '{request}' являются корректным числом: {number}");
            return base.Handle(request);
        }
    }
}