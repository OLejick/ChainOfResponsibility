using System;

namespace ConsoleApp2
{
    public class NameValidator : Validator<User>
    {
        public override bool Handle(User request)
        {
            if (string.IsNullOrEmpty(request.Name))
            {
                Console.WriteLine("Ошибка: Имя не может быть пустым.");
                return false;
            }

            Console.WriteLine("Имя валидно.");
            return base.Handle(request);
        }
    }
}