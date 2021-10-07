using System;

namespace GeekBrainsFourthLesson
{
    enum Season
    {
        Winter,
        Spring,
        Summer,
        Autumn
    }

    class Program
    {
        static void Main()
        {
            /*Написать метод GetFullName(string firstName, string lastName, 
            string patronymic), принимающий на вход ФИО в разных аргументах 
            и возвращающий объединённую строку с ФИО. Используя метод, написать программу, 
            выводящую в консоль 3–4 разных ФИО.*/
            static string GetIt(string str)
            {
                string atr = "";
                switch (str)
                {
                    case
                "firstName":
                        atr = "Name";
                        break;
                        ;
                    case
                "lastName":
                        atr = "Surname";
                        break;
                        ;
                    case
                "patronymic":
                        atr = "Patronymic";
                        break;
                        ;
                    default:
                        break;
                }
                Console.WriteLine($"Please enter your {atr}");
                var asn = Console.ReadLine();
                return asn;
            }

            static string GetFullName(string firstName, string lastName, string patronymic)
            {
                return firstName + " " + lastName + " " + patronymic;
            }

            //first implementation
            var firstName = GetIt("firstName");
            var lastName = GetIt("lastName");
            var patronymic = GetIt("patronymic");
            Console.Clear();

            string fullName = GetFullName(firstName, lastName, patronymic);
            Console.WriteLine($"{fullName}");
            Console.ReadKey();
            Console.Clear();

            //second implementation
            string[,] NamesArray = new string[4, 3] {{ "Ivanov","Stepan","Gennadievich"},
                {"Petrov","Gennadij","Borisovich"},
                {"Sidorova","Irina","Anatolievna"},
                {"Alekseev","Andrej","Nikolaevich"}};

            for (int i = 0; i < 4; i++)
            {
                lastName = NamesArray[i, 0];
                firstName = NamesArray[i, 1];
                patronymic = NamesArray[i, 2];
                fullName = GetFullName(firstName, lastName, patronymic);
                Console.WriteLine($"{fullName}");
            }
            Console.ReadKey();
            Console.Clear();

            /*Написать программу, принимающую на вход строку — набор чисел, 
            разделенных пробелом, и возвращающую число — сумму всех чисел в строке. 
            Ввести данные с клавиатуры и вывести результат на экран.*/
            Console.WriteLine("Enter integer numbers separated by a space");
            String[] numbers = Console.ReadLine().Split(' ');
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            { sum += Convert.ToInt32(numbers[i]); }
            Console.WriteLine($" Summ of all numbers is {sum}");
            Console.ReadKey();
            Console.Clear();

            /*Написать метод по определению времени года. На вход подаётся число – 
            порядковый номер месяца. На выходе — значение из перечисления
            (enum) — Winter, Spring, Summer, Autumn. Написать метод, 
            принимающий на вход значение из этого перечисления и возвращающий 
            название времени года (зима, весна, лето, осень). Используя эти методы, 
            вести с клавиатуры номер месяца и вывести название времени года. 
            Если введено некорректное число, вывести в консоль текст «Ошибка: введите число от 1 до 12».*/

            Console.WriteLine("Please enter number of current month");
            var currentMonth = Convert.ToInt32(Console.ReadLine());
            var currentSeason = GetSeason(currentMonth);
            Console.WriteLine($"It's {currentSeason} now!");

            static Enum GetSeason(int number)
            {
                var season = new Season();
                switch (number)
                {
                    case 1: season = Season.Winter; break;
                    case 2: season = Season.Winter; break;
                    case 3: season = Season.Spring; break;
                    case 4: season = Season.Spring; break;
                    case 5: season = Season.Spring; break;
                    case 6: season = Season.Summer; break;
                    case 7: season = Season.Summer; break;
                    case 8: season = Season.Summer; break;
                    case 9: season = Season.Autumn; break;
                    case 10: season = Season.Autumn; break;
                    case 11: season = Season.Autumn; break;
                    case 12: season = Season.Winter; break;

                    default:
                        Console.WriteLine("An Error: Enter correct number from 1 to 12!");
                        break;
                }
                return season;

            }
        }
    }
}