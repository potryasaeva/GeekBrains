using System;
using System.IO;

namespace FifthLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл.
            Console.WriteLine("Please enter something");
            var someData = Console.ReadLine();
            File.WriteAllText("SavedData.txt", someData);
            Console.Clear();


            //Написать программу, которая при старте дописывает текущее время в файл «startup.txt».
            var currentDate = DateTime.Now.ToString();
            Console.WriteLine(currentDate);
            File.AppendAllText("DatesTimes.txt", Environment.NewLine); 
            File.AppendAllText("DatesTimes.txt", currentDate);
            Console.Clear();


            //Ввести с клавиатуры произвольный набор чисел (0...255) и записать их в бинарный файл.
            Console.WriteLine("Enter any numbers form 0 to 255 separeted by space");

            String[] numbers = Console.ReadLine().Split(' ');
            byte[] nums = new byte[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            { nums[i] = byte.Parse(numbers[i]); }
            File.WriteAllBytes("bytes.bin", nums);

            //For check that file not empty
            /*byte[] fromFile = File.ReadAllBytes("bytes.bin");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(fromFile[i]);
            }*/
            Console.Clear();


            //(*) Сохранить дерево каталогов и файлов по заданному пути в текстовый файл 
            string workDir = @"C:\Users\lpotr\Desktop\Repos";
            string[] entries = Directory.GetFileSystemEntries(workDir, "*", SearchOption.AllDirectories);

            for (int i = 0; i < entries.Length; i++)
            {
                if (i == 0)
                {
                    File.WriteAllText("textNew.txt", entries[i]);
                }
                else
                {
                    File.AppendAllText("textNew.txt", Environment.NewLine);
                    File.AppendAllText("textNew.txt", entries[i]);
                }

                Console.WriteLine(entries[i]);
            }

        }
    }
}
