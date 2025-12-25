using System;
using System.Linq;

namespace ConsoleApp2
{
    public class PhoneNumberValidator : Validator<User>
    {
        public override bool Handle(User request)
        {
            if (string.IsNullOrEmpty(request.PhoneNumber))
            {
                Console.WriteLine("Ошибка: Номер телефона не может быть пустым.");
                return false;
            }

            if (!request.PhoneNumber.StartsWith("+7"))
            {
                Console.WriteLine("Ошибка: Номер телефона должен начинаться с '+7'.");
                return false;
            }

            var digitsOnly = new string(request.PhoneNumber.Where(char.IsDigit).ToArray());
            if (digitsOnly.Length != 11)
            {
                Console.WriteLine("Ошибка: Номер телефона должен содержать 11 цифр.");
                return false;
            }

            Console.WriteLine("Номер телефона валиден.");
            return base.Handle(request);
        }
    }
}