using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;

namespace ConsoleUI
{
    class Program
    {
        static TeacherManager manager = new TeacherManager();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Добавить преподавателя");
                Console.WriteLine("2. Показать всех преподавателей");
                Console.WriteLine("3. Удалить преподавателя");
                Console.WriteLine("4. Изменить преподавателя");
                Console.WriteLine("5. Сгруппировать по предметам");
                Console.WriteLine("6. Найти по стажу");
                Console.WriteLine("7. Выход");
                Console.Write("Выберите: ");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddTeacher();
                        break;
                    case "2":
                        ShowAllTeachers();
                        break;
                    case "3":
                        DeleteTeacher();
                        break;
                    case "4":
                        UpdateTeacher();
                        break;
                    case "5":
                        GroupBySubject();
                        break;
                    case "6":
                        FilterByExperience();
                        break;
                    case "7":
                        return;
                    default:
                        Console.WriteLine("Неверный выбор");
                        break;
                }

                Console.WriteLine();
            }
        }
        static void AddTeacher()
        {
            Console.Write("Введите имя: ");
            var name = Console.ReadLine();

            Console.Write("Введите предмет: ");
            var subject = Console.ReadLine();

            Console.Write("Введите стаж: ");
            if (int.TryParse(Console.ReadLine(), out int experience))
            {
                manager.AddTeacher(name, subject, experience);
                Console.WriteLine("Преподаватель добавлен");
            }
            else
            {
                Console.WriteLine("Ошибка ввода стажа");
            }
        }


    }