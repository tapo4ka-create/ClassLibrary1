using System;
using Logic;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        private TeacherManager manager = new TeacherManager();
        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textName.Text) ||
                string.IsNullOrWhiteSpace(textSubject.Text))
            {
                MessageBox.Show("Заполните имя и предмет");
                return;
            }

            manager.AddTeacher(textName.Text, textSubject.Text, (int)numExperience.Value);
            MessageBox.Show("Преподаватель добавлен!");

            // Очищаем поля
            textName.Clear();
            textSubject.Clear();
            numExperience.Value = 0;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textID.Text, out int id))
            {
                if (manager.TeacherExists(id))
                {
                    if (manager.UpdateTeacher(id, textName.Text, textSubject.Text, (int)numExperience.Value))
                    {
                        MessageBox.Show("Данные обновлены");
                    }
                    else
                    {
                        MessageBox.Show("Ошибка обновления");
                    }
                }
                else
                {
                    MessageBox.Show("Преподаватель не найден");
                }
            }
            else
            {
                MessageBox.Show("Введите корректный ID");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textID.Text, out int id))
            {
                if (manager.RemoveTeacher(id))
                {
                    MessageBox.Show("Преподаватель удален");
                    textID.Clear();
                }
                else
                {
                    MessageBox.Show("Преподаватель не найден");
                }
            }
            else
            {
                MessageBox.Show("Введите корректный ID");
            }
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            listOutput.Items.Clear();

            if (int.TryParse(textminExperience.Text, out int minExp))
            {
                var teachers = manager.GetTeachersByExperienceInfo(minExp);
                foreach (var teacher in teachers)
                {
                    listOutput.Items.Add(teacher);
                }
            }
            else
            {
                MessageBox.Show("Введите корректный стаж");
            }
        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            listOutput.Items.Clear();

            if (!manager.HasTeachers())
            {
                listOutput.Items.Add("Нет преподавателей");
                return;
            }

            var teachers = manager.GetAllTeachersInfo();
            foreach (var teacher in teachers)
            {
                listOutput.Items.Add(teacher);
            }
        }

        private void buttonGroup_Click(object sender, EventArgs e)
        {
            listOutput.Items.Clear();

            if (!manager.HasTeachers())
            {
                listOutput.Items.Add("Нет преподавателей");
                return;
            }

            var groups = manager.GetGroupedBySubjectInfo();
            foreach (var group in groups)
            {
                listOutput.Items.Add(group);
            }
        }


    }
}
