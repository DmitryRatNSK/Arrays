using System;
using System.Collections.Generic;

namespace arraysNew
{
    class Program
    {
        static int _input_index_to_remove()
        {
            while (true)
            {
                Console.Write("Введите номер записи, который хотите удалить: ");
                if (Int32.TryParse(Console.ReadLine(), out int index))
                    return index;
                else
                    Console.WriteLine("\nПроизошла ошибка, поробуйте заново!");
            }
        }

        static int _input_choice()
        {
            while (true)
            {
                Console.WriteLine("1 - Добавить запись\n2 - Удалить запись\n3 - Посмотреть записи\n4 - Выход\n5 - Очистить консоль");
                Console.Write("Выберите действие: ");
                if (Int32.TryParse(Console.ReadLine(), out int choice))
                    return choice;
                else
                    Console.WriteLine("\nПроизошла ошибка, поробуйте заново!");
            }
        }



        static void Main(string[] args)
        {
            List<string> array_strings = new List<string> {"Hello", "users", "about", "C#" };
            while (true)
            {

                int choice = _input_choice();
                switch (choice)
                {
                    case 1:
                        // codding
                        Console.Write("Введите новую запись: ");
                        string new_item_arrays = Console.ReadLine();
                        array_strings.Add(new_item_arrays);
                        Console.WriteLine("Запись добавленна успешно");
                        break;
                    case 2:
                        // codding
                        int item_to_remove = _input_index_to_remove();
                        if(item_to_remove > array_strings.Count)
                        {
                            Console.WriteLine("Запсиь не найдена, попробуйте другую!");
                        }
                        else
                        {
                            array_strings.RemoveAt(item_to_remove - 1);
                            Console.WriteLine("Запись Удалена успешно");
                        }
                        break;
                    case 3:
                        // codding
                        for (int i = 0; i < array_strings.Count; i++)
                        {
                            Console.WriteLine(array_strings[i]);
                        }
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    case 5:
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Такого действия нет!");
                        break;
                }
                Console.WriteLine("\n");
                //Console.ReadKey();
                //Console.Clear();
            }
        }
    }
}

