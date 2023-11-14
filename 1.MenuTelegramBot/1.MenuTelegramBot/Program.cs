using System;

namespace MenuTelegramBot
{
    class Program
    {         
        static void Main(string[] args)
        {
            string startWord = "Привет, мир!" +
                               "Доступные команды: /start, /help, /info, /exit";
            Console.WriteLine(startWord);
            string commandUser = "";
            string nameUser;
            
            while (commandUser != "/exit")
            {
                Console.WriteLine("Ваша команда:");
                commandUser = Console.ReadLine();
                
                switch (commandUser)
                {
                    case "/start":
                        Console.WriteLine("Напишите ваше имя:");
                        nameUser = Console.ReadLine();
                        break;
                    case "/help":
                        Console.WriteLine("Доступные команды: /start, /help, /info, /exit");
                        break;
                    case "/info":
                        Console.WriteLine($"Версия программы 00.000.001 Дата создания {DateTime.Now.Date}");
                        break;
                    case "/echo":
                        Console.WriteLine();
                        break;
                }
                Console.Clear();
            }
        }
    }
}

/*
Вам предстоит создать консольное приложение, которое будет имитировать интерактивное меню бота согласно следующему плану:

Приветствие: При запуске программы отображается сообщение приветствия со списком доступных команд: /start, /help, /info, /exit.
    Обработка команды /start: Если пользователь вводит команду /start, программа просит его ввести своё имя. Сохраните введенное имя в переменную. Программа должна обращаться к пользователю по имени в каждом следующем ответе.
    Обработка команды /help: Отображает краткую справочную информацию о том, как пользоваться программой.
    Обработка команды /info: Предоставляет информацию о версии программы и дате её создания.
    Доступ к команде /echo: После ввода имени становится доступной команда /echo. При вводе этой команды с аргументом (например, /echo Hello), программа возвращает введенный текст (в данном примере "Hello").
Основной цикл программы: Программа продолжает ожидать ввод команды от пользователя, пока не будет введена команда /exit.
*/