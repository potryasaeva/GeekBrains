using System;

namespace GeekBrainsSecondLesson
{
    class Program
    {
        static void Main()
        {
            //Запросить у пользователя минимальную и максимальную температуру
            //за сутки и вывести среднесуточную температуру.

            Console.WriteLine("Please enter min temperature per day");
            var minTemperature = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter max temperature per day");
            var maxTemperature = Convert.ToDouble(Console.ReadLine());
            double middleTemperature = (maxTemperature + minTemperature) / 2;
            Console.WriteLine($"The middle temperature per day is {middleTemperature}");

            //Запросить у пользователя порядковый номер текущего месяца и вывести его название.

            Console.WriteLine("Please enter number of current month");
            var currentMonth = Convert.ToInt32(Console.ReadLine());
            switch (currentMonth)
            {
                case 1:
                    if (middleTemperature > 0)
                    {
                        Console.WriteLine("It's January now. Rainy winter!");
                    }
                    else
                        Console.WriteLine("It's January now");
                    break;
                case 2:
                    if (middleTemperature > 0)
                    {
                        Console.WriteLine("It's February now. Rainy winter!");
                    }
                    else
                        Console.WriteLine("It's February now");
                    break;
                case 3:
                    Console.WriteLine("It's March now");
                    break;
                case 4:
                    Console.WriteLine("It's April now");
                    break;
                case 5:
                    Console.WriteLine("It's May now");
                    break;
                case 6:
                    Console.WriteLine("It's June now");
                    break;
                case 7:
                    Console.WriteLine("It's July now");
                    break;
                case 8:
                    Console.WriteLine("It's August now");
                    break;
                case 9:
                    Console.WriteLine("It's September now");
                    break;
                case 10:
                    Console.WriteLine("It's October now");
                    break;
                case 11:
                    Console.WriteLine("It's November now");
                    break;
                case 12:
                    if (middleTemperature > 0)
                    {
                        Console.WriteLine("It's February now. Rainy winter!");
                    }
                    else
                        Console.WriteLine("It's December now");
                    break;
                default:
                    Console.WriteLine("Something wrong. Try again. Use numbers from 1 to 12. Good luck!");
                    break;
            }

            //Определить, является ли введённое пользователем число чётным.
            if (currentMonth % 2 == 0) { Console.WriteLine($"By the way, {currentMonth} is even number"); }
            else Console.WriteLine($"By the way, {currentMonth} is odd number");
            Console.ReadKey();



            //Задача с чеком 
            Console.Clear();
            Console.SetWindowSize(30, 14);


            string firm = "ИП Булочкина";
            var date = DateTime.Now;
            string worker = "Кассир 1";
            string total = "ИТОГО:";
            double price = 35.41;
            long inn = 7819230004;
            int kpp = 7801001;

            // Выводим строку с фирмой
            int centerFirstLine = (Console.WindowWidth / 2) - (firm.Length / 2);
            Console.SetCursorPosition(centerFirstLine, 0);
            Console.Write(firm);

            //Выводим строку с датой
            Console.SetCursorPosition(0, 2);
            Console.Write(date);

            //Выводим строку с кассиром
            int workerСoordinateX = Console.WindowWidth - worker.Length;
            Console.SetCursorPosition(workerСoordinateX, 2);
            Console.Write(worker);

            //Выводим строку с ценой
            Console.SetCursorPosition(0, 4);
            Console.Write(total);
            int totalCoordinateX = Console.WindowWidth - total.Length;
            Console.SetCursorPosition(totalCoordinateX, 4);
            Console.Write(price);

            //Выводим строки с ИНН/КПП (не смогла определить длинну у типа long, поэтому костыль)
            int innCoordinateX = Console.WindowWidth - 14;
            Console.SetCursorPosition(innCoordinateX, 6);
            Console.Write($"ИНН {inn}");
            int kppCoordinateX = Console.WindowWidth - 11;
            Console.SetCursorPosition(kppCoordinateX, 8);
            Console.Write($"КПП {kpp}");

            //Выводим пожелания
            Console.SetCursorPosition(centerFirstLine, 10);
            Console.Write("Спасибо за покупку!");
            Console.SetCursorPosition(centerFirstLine, 12);
            Console.Write("Ждем Вас снова!");

            //Ждём нажатия клавиши перед выходом
            Console.ReadKey();

        }
    }
}
