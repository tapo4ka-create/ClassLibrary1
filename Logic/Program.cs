using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public int Experience { get; set; }
    }

    /// <summary>
    /// Менеджер для работы с преподавателями
    /// </summary>
    public class TeacherManager
    {
        private List<Teacher> teachers = new List<Teacher>();
        private int nextId = 1;

        /// <summary>
        /// Добавляет нового преподавателя
        /// </summary>
        /// <param name="name">Имя преподавателя</param>
        /// <param name="subject">Предмет</param>
        /// <param name="experience">Стаж в годах</param>
        public void AddTeacher(string name, string subject, int experience)
        {
            teachers.Add(new Teacher
            {
                Id = nextId++,
                Name = name,
                Subject = subject,
                Experience = experience
            });
        }

        /// <summary>
        /// Получает информацию о всех преподавателях
        /// </summary>
        /// <returns>Список строк с информацией о преподавателях</returns>
        public List<string> GetAllTeachersInfo()
        {
            return teachers.Select(t => $"ID: {t.Id}, {t.Name}, {t.Subject}, {t.Experience} лет").ToList();
        }

        /// <summary>
        /// Проверяет существование преподавателя по ID
        /// </summary>
        /// <param name="id">ID преподавателя</param>
        /// <returns>True если преподаватель существует</returns>
        public bool TeacherExists(int id)
        {
            return teachers.Any(t => t.Id == id);
        }

        /// <summary>
        /// Удаляет преподавателя по ID
        /// </summary>
        /// <param name="id">ID преподавателя</param>
        /// <returns>True если удаление успешно</returns>
        public bool RemoveTeacher(int id)
        {
            var teacher = teachers.Find(t => t.Id == id);
            if (teacher != null)
            {
                teachers.Remove(teacher);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Обновляет данные преподавателя
        /// </summary>
        /// <param name="id">ID преподавателя</param>
        /// <param name="name">Новое имя</param>
        /// <param name="subject">Новый предмет</param>
        /// <param name="experience">Новый стаж</param>
        /// <returns>True если обновление успешно</returns>
        public bool UpdateTeacher(int id, string name, string subject, int experience)
        {
            var teacher = teachers.Find(t => t.Id == id);
            if (teacher != null)
            {
                teacher.Name = name;
                teacher.Subject = subject;
                teacher.Experience = experience;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Группирует преподавателей по предметам
        /// </summary>
        /// <returns>Список сгруппированных данных</returns>
        public List<string> GetGroupedBySubjectInfo()
        {
            var result = new List<string>();
            var groups = teachers.GroupBy(t => t.Subject);

            foreach (var group in groups)
            {
                result.Add(group.Key + ":");
                foreach (var teacher in group)
                {
                    result.Add($"  {teacher.Name} ({teacher.Experience} лет)");
                }
                result.Add(""); // пустая строка между группами
            }

            return result;
        }

        /// <summary>
        /// Находит преподавателей по минимальному стажу
        /// </summary>
        /// <param name="minExperience">Минимальный стаж</param>
        /// <returns>Список подходящих преподавателей</returns>
        public List<string> GetTeachersByExperienceInfo(int minExperience)
        {
            var filteredTeachers = teachers.Where(t => t.Experience >= minExperience).ToList();

            if (filteredTeachers.Count == 0)
            {
                return new List<string> { "Преподаватели не найдены" };
            }

            return filteredTeachers
                .Select(t => $"{t.Name} - {t.Subject} ({t.Experience} лет)")
                .ToList();
        }

        /// <summary>
        /// Проверяет наличие преподавателей в системе
        /// </summary>
        /// <returns>True если есть хотя бы один преподаватель</returns>
        public bool HasTeachers()
        {
            return teachers.Count > 0;
        }
    }
}