using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            var nameValidator = new NameValidator();
            var ageValidator = new AgeValidator(18, 100);
            var emailValidator = new EmailValidator();
            var phoneValidator = new PhoneNumberValidator();

            nameValidator
                .SetNext(ageValidator)
                .SetNext(emailValidator)
                .SetNext(phoneValidator);

            Console.WriteLine("=== Тест 1: Валидный пользователь ===");
            var validUser = new User
            {
                Name = "Иван Иванов",
                Age = 25,
                Email = "ivan@example.com",
                PhoneNumber = "+79123456789"
            };

            bool isValid = nameValidator.Handle(validUser);
            Console.WriteLine($"\nОбщий результат валидации: {(isValid ? "УСПЕХ" : "ОШИБКА")}\n");

            Console.WriteLine("=== Тест 2: Невалидный номер телефона ===");
            var invalidPhoneUser = new User
            {
                Name = "Петр Петров",
                Age = 30,
                Email = "petr@example.com",
                PhoneNumber = "89123456789" 
            };

            isValid = nameValidator.Handle(invalidPhoneUser);
            Console.WriteLine($"\nОбщий результат валидации: {(isValid ? "УСПЕХ" : "ОШИБКА")}\n");

            Console.WriteLine("=== Тест 3: Невалидный возраст ===");
            var invalidAgeUser = new User
            {
                Name = "Сергей Сергеев",
                Age = 17,
                Email = "sergey@example.com",
                PhoneNumber = "+79123456789"
            };

            isValid = nameValidator.Handle(invalidAgeUser);
            Console.WriteLine($"\nОбщий результат валидации: {(isValid ? "УСПЕХ" : "ОШИБКА")}");

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}