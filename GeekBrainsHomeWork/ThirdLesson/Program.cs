using System;

namespace GeekBrainsThirdLesson
{
    class Program
    {
        static void Main()
        {

            //Написать программу, выводящую элементы четырехмерного массива по диагонали.
            int[,] array = { { 123, 321, 213, 312 }, { 456, 654, 546, 645 }, { 789, 987, 879, 798 }, { 852, 258, 528, 285 } };
            int arrayRows = array.GetUpperBound(0) + 1;
            int arrayColumns = array.Length / arrayRows;
            for (int i = 0; i < arrayColumns; i++)
            {
                Console.Write($"{array[i, i]} ");
            }
            Console.ReadKey();
            Console.Clear();


            // or 'по диагонали'
            int[,] arrayForDiagonal = new[,] { { 123, 321 }, { 456, 654 } };
            int padLeft = 0;

            foreach (var item in arrayForDiagonal)
            {
                Console.WriteLine(item.ToString().PadLeft(padLeft += 3));
            }
            Console.ReadKey();
            Console.Clear();


            //Написать программу — телефонный справочник — создать двумерный массив 5*2,
            //хранящий список телефонных контактов: первый элемент хранит имя контакта, 
            //второй — номер телефона/e-mail.
            string[,] phonebook = {
                { "Ivanov Vladimir", "Doctor Barmental", "Zinka", "Pizza Delivery", "Do Not Unswer" },
                { "+8(951)147-23-65", "+8(812)777-23-65", "576-55-94", "7777" , "+34568972365"}
            };

            int rows = phonebook.GetUpperBound(0) + 1; //строки
            int columns = phonebook.Length / rows;
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.Write($"{phonebook[j, i]}\r\n");
                }
                Console.Write($"\r\n");
            }
            Console.ReadKey();
            Console.Clear();


            //Написать программу, выводящую введенную пользователем 
            //строку в обратном порядке (olleH вместо Hello).
            Console.Write($"Enter any word/phrase\n");
            string userString = Console.ReadLine();
            for (int i = userString.Length - 1; i >= 0; i--)
            {
                Console.Write(userString[i]);
            }


        }
    }
}
