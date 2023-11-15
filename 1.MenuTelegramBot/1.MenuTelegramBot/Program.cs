using System;

namespace MenuTelegramBot
{
    class Program
    {         
        static void Main(string[] args)
        {
            string commandUser = "";
            string userName = "Пользователь";
            DateTime dateOfCreation = DateTime.Now.Date;
            int version = 1;
            
            while (commandUser != "/exit")
            {
                Console.Clear();
                Console.WriteLine($"Привет, {userName}!");
                StartHello(userName);
                
                Console.WriteLine("Ваша команда:");
                commandUser = Console.ReadLine();
                
                switch (commandUser)
                {
                    case "/start":
                        Console.WriteLine($"{userName}, напишите ваше имя:");
                        userName = Console.ReadLine();
                        break;
                    case "/help":
                        Console.WriteLine($"Укажи нужную команду и получи ответ.");
                        Console.WriteLine($"{userName}, нажмите ENTER чтобы посмотреть список команд");
                        Console.ReadLine();
                        break;
                    case "/info":
                        Console.WriteLine($"Версия программы: {version}\n" +
                                          $"Дата создания: {dateOfCreation.ToString("dd.MM.yyyy")}");
                        Console.WriteLine($"{userName}, нажмите ENTER чтобы посмотреть список команд");
                        Console.ReadLine();
                        break;
                    case string s when s.Split()[0] == "/echo":
                        if (CheckUser(userName))
                        {
                            break;
                        }
                        Console.WriteLine(s.Replace("/echo","").Trim());
                        Console.WriteLine($"{userName}, нажмите ENTER чтобы посмотреть список команд");
                        Console.ReadLine();
                        break;
                }

                version++;
            }

            static bool CheckUser(string currentUser)
            {
                return currentUser == "Пользователь";
            }
            
            static void StartHello(string user)
            {
                string startWord = CheckUser(user)
                    ? $"{user}, для тебя доступны команды: /start, /help, /info, /exit"
                    : $"{user}, для тебя доступны команды: /start, /help, /info, /echo, /exit";
                
                Console.WriteLine(startWord);
            }
        }
    }
}