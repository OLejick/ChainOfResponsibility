using System;

namespace ConsoleApp2
{
    public class EmailValidator : Validator<User>
    {
        public override bool Handle(User request)
        {
            if (string.IsNullOrEmpty(request.Email))
            {
                Console.WriteLine("Ошибка: Email не может быть пустым.");
                return false;
            }

            if (!request.Email.Contains("@"))
            {
                Console.WriteLine("Ошибка: Email должен содержать символ '@'.");
                return false;
            }

            Console.WriteLine("Email валиден.");
            return base.Handle(request);
        }
    }
}