using System;
using System.Collections.Generic;

namespace ReminderDay
{
    class Program
    {
        static void Main(string[] args)
        {
            /// словарь дней недели
            Dictionary<int, string> daysOfTheWheek = new Dictionary<int, string>(7)
            {
                {1, "Понедельник"},
                {2, "Вторник"},
                {3, "Среда"},
                {4, "Четверг"},
                {5, "Пятница"},
                {6, "Суббота"},
                {7, "Воскресенье"}
            };
            List<string[,]> events = new List<string[,]>();
            /// массив добавленных мероприятий
            //string[,] events = new string[,] { };

            bool runned = true;
            while(runned)
            {
                AddEvents(daysOfTheWheek, ref events);

                Console.Clear();
                if (events.Count > 0)
                {
                    Console.WriteLine("Все запланированные мероприятия:");
                    foreach(var ev in events)
                    {
                        for (int i = 0; i < ev.Length / 2; i++)
                        {
                            Console.WriteLine($"{ev[i, 0]} - {ev[1, i]}");
                        }
                    }
                }

                Console.WriteLine($"\nХотите добавить ещё мероприятия?\nY - да; N - нет");
                if (Console.ReadKey().Key == ConsoleKey.Y)
                {
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Выполнен выход их программы");
                    Environment.Exit(0);
                }
            }



            Console.ReadLine();
        }

        private static int ShowAndSelectDay(Dictionary<int, string> daysOfTheWheek)
        {
            foreach (var day in daysOfTheWheek)
            {
                Console.WriteLine($"{day.Value} = {day.Key}");
            }
            Console.Write("Выберите день недели для планирования мероприятия: ");

            int userChoose;
            int.TryParse(Console.ReadLine(), out userChoose);

            if (userChoose < 1 || userChoose > 7)
            {
                Console.WriteLine("\nНеверный ввод.\nНеобходимо ввести число соответствующее дню недели." +
                    "\nДля продолжения нажмите Enter");
                Console.ReadLine();
                return -1;
            }
            else
            {
                Console.WriteLine($"*** Выбранный день - {daysOfTheWheek[userChoose]} ***\n");
            }

            return userChoose;
        }

        private static void AddEvents(Dictionary<int, string> daysOfTheWheek, ref List<string[,]> events)
        {
            int selectedDay = ShowAndSelectDay(daysOfTheWheek);
            if (selectedDay == -1)
                return;

            foreach (var ev in events)
            {
                foreach(string c in ev)
                {
                    if (c.Contains(daysOfTheWheek[selectedDay]))
                    {
                        Console.WriteLine("На этот день уже запланировано мероприятие.\nДля продолжения нажмите Enter");
                        Console.ReadLine();
                        return;
                    }
                }
            }

            if (selectedDay > 0)
            {
                Console.WriteLine("Запланируйте на этот день мероприятие:");
                events.Add(new string[,] { { daysOfTheWheek[selectedDay] }, { Console.ReadLine() } });
            }
        }
    }
}
