using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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
                Console.WriteLine("Пожалуйста, подождите 3 секунды");
                Thread.Sleep(2500);
                Console.Clear();
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

        static void ShowAllTeachers()
        {
            if (!manager.HasTeachers())
            {
                Console.WriteLine("Нет преподавателей");
                return;
            }

            var teachersInfo = manager.GetAllTeachersInfo();
            foreach (var info in teachersInfo)
            {
                Console.WriteLine(info);
            }
        }
        static void DeleteTeacher()
        {
            Console.Write("Введите ID для удаления: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                if (manager.RemoveTeacher(id))
                    Console.WriteLine("Преподаватель удален");
                else
                    Console.WriteLine("Преподаватель с таким ID не найден");
            }
            else
            {
                Console.WriteLine("Ошибка ввода ID");
            }
        }
        static void UpdateTeacher()
        {
            Console.Write("Введите ID для изменения: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                if (!manager.TeacherExists(id))
                {
                    Console.WriteLine("Преподаватель с таким ID не найден");
                    return;
                }

                Console.Write("Новое имя: ");
                var name = Console.ReadLine();

                Console.Write("Новый предмет: ");
                var subject = Console.ReadLine();

                Console.Write("Новый стаж: ");
                if (int.TryParse(Console.ReadLine(), out int experience))
                {
                    if (manager.UpdateTeacher(id, name, subject, experience))
                        Console.WriteLine("Данные преподавателя обновлены");
                    else
                        Console.WriteLine("Ошибка при обновлении");
                }
                else
                {
                    Console.WriteLine("Ошибка ввода стажа");
                }
            }
            else
            {
                Console.WriteLine("Ошибка ввода ID");
            }
        }
        static void GroupBySubject()
        {
            if (!manager.HasTeachers())
            {
                Console.WriteLine("Нет преподавателей");
                return;
            }

            var groupsInfo = manager.GetGroupedBySubjectInfo();
            foreach (var info in groupsInfo)
            {
                Console.WriteLine(info);
            }
        }

        static void FilterByExperience()
        {
            Console.Write("Минимальный стаж: ");
            if (int.TryParse(Console.ReadLine(), out int minExperience))
            {
                var teachersInfo = manager.GetTeachersByExperienceInfo(minExperience);
                foreach (var info in teachersInfo)
                {
                    Console.WriteLine(info);
                }
            }
            else
            {
                Console.WriteLine("Ошибка ввода стажа");
            }
        }

    }
}