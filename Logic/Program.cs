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
    public class TeacherManager
    {
        private List<Teacher> teachers = new List<Teacher>();
        private int nextId = 1;

        // Создание
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

        // Чтение
        public List<string> GetAllTeachersInfo()
        {
            return teachers.Select(t => $"ID: {t.Id}, {t.Name}, {t.Subject}, {t.Experience} лет").ToList();
        }

        public bool TeacherExists(int id)
        {
            return teachers.Any(t => t.Id == id);
        }

        // Удаление
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

        // Изменение
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

    }
}