using System;
using System.Configuration;

namespace EighthLesson
{
    class Program
    {
        static void Main(string[] args)
        //Создать консольное приложение, которое при старте выводит приветствие, записанное в настройках приложения (application-scope).
        //Запросить у пользователя имя, возраст и род деятельности, а затем сохранить данные в настройках.
        //При следующем запуске отобразить эти сведения. Задать приложению версию и описание.

        {
            Console.WriteLine(Properties.Settings1.Default.HelloWords);

            if (string.IsNullOrEmpty(Properties.Settings1.Default.UserName))
            {

                Console.WriteLine("Enter your name");
                Properties.Settings1.Default.UserName = Console.ReadLine();
                //Properties.Settings1.Default.Save();

                Console.WriteLine("Enter your age");
                Properties.Settings1.Default.UserAge = Console.ReadLine();
               // Properties.Settings1.Default.Save();

                Console.WriteLine("Enter your position");
                Properties.Settings1.Default.UserPosition = Console.ReadLine();
                Properties.Settings1.Default.Save();
            }
            string userName = Properties.Settings1.Default.UserName;
            string userAge = Properties.Settings1.Default.UserAge;
            string userPosition = Properties.Settings1.Default.UserPosition;
            Console.WriteLine($"{userName}, {userAge}, {userPosition}!");


        }
    }
}
