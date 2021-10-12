using System;
using System.Diagnostics;

namespace SixthLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            //Написать консольное приложение Task Manager, которое выводит на экран запущенные процессы
            //и позволяет завершить указанный процесс. Предусмотреть возможность завершения процессов
            //с помощью указания его ID или имени процесса. В качестве примера можно использовать
            //консольные утилиты Windows tasklist и taskkill.

            Process[] processes = Process.GetProcesses();
            Console.WriteLine("{0,10} || {1,0}\n", "ID", "Name");
            foreach (var i in processes)
            {
                Console.WriteLine("{0,10} || {1,0}", i.Id, i.ProcessName);
            }
            Console.WriteLine("If you want to finish some of the process, plz enter it's Name of ID!");
            killTheProcess(processes);

            static void killTheProcess(Process[] processes)
            {
                var selectedProcess = Console.ReadLine();
                Process process = new Process();

                try
                {
                    int result;
                    if (Int32.TryParse(selectedProcess, out result))
                    {
                        bool isExist = false;
                        foreach (var item in processes)
                        {
                            if (result == 0)
                            {
                                continue;
                            }
                            else if (item.Id == result)
                            {
                                isExist = true;
                                item.Kill();
                            }
                            else continue;
                        }
                        if (isExist == false) {
                            Console.WriteLine("Couldn't fined any process by entered ID. Try Again please.");
                            killTheProcess(processes);
                        }
                    }
                    else
                    {
                        foreach (var item in processes)
                        {
                            if (item.ProcessName == selectedProcess)
                            {
                                item.Kill();
                            }
                            else
                            {
                                Console.WriteLine("The entered value not equal to any ID or Name. Try Again please.");
                                killTheProcess(processes);
                            }
                        }
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Что-то пошло не так.");
                }
            }
        }
    }
}
