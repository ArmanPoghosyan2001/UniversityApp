using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityApp.Services;

namespace UniversityApp
{
    class UniversityManager : IUnivercityManager
    {
        public void Show(List<StudentModel> students)
        {
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine("--------------------");
                Console.WriteLine($"_id-{students[i]._id} _name-{students[i]._name} _age-{students[i]._age} _faculty-{students[i]._faculty}");
                Console.WriteLine("Student's teacher");
                if (students[i]._teacher != null)
                {
                    Console.WriteLine($"_id-{students[i]._teacher._id} _name-{students[i]._teacher._name} _age-{students[i]._teacher._age}");

                }
            }
        }
        public void Show(List<TeacherModel> teachers)
        {
            for (int i = 0; i < teachers.Count; i++)
            {
                Console.WriteLine("--------------------");
                Console.WriteLine($"_id-{teachers[i]._id} _name-{teachers[i]._name} _age-{teachers[i]._age}");
                Console.WriteLine("Teacher's students");
                if (teachers[i]._students != null)
                {
                    for (int j = 0; j < teachers[i]._students.Count; j++)
                    {
                        Console.WriteLine($"_id-{teachers[i]._students[j]._id} _name-{teachers[i]._students[j]._name} _age-{teachers[i]._students[j]._age} _faculty-{teachers[i]._students[j]._faculty}");
                    }
                }
            }
        }
        public List<TeacherModel> Swap(List<StudentModel> students, List<TeacherModel> teachers)
        {
            int studentsCountForTeacher = students.Count / teachers.Count;

            if (students.Count % teachers.Count == 0)
            {
                int counter = 0;
                for (int i = 0; i < teachers.Count; i++)
                {
                    for (int j = counter; j < studentsCountForTeacher + counter; j++)
                    {
                        teachers[i]._students.Add(students[j]);
                    }
                    counter += studentsCountForTeacher;
                }
            }
            else
            {
                int studentsCountForLastTeacher = (students.Count / teachers.Count) + (students.Count % teachers.Count);
                int counter = 0;
                for (int i = 0; i < teachers.Count; i++)
                {
                    if (i == teachers.Count - 1)
                    {
                        for (int j = counter; j < studentsCountForLastTeacher + counter; j++)
                        {
                            teachers[i]._students.Add(students[j]);
                        }
                    }
                    else
                    {
                        for (int j = counter; j < studentsCountForTeacher + counter; j++)
                        {
                            teachers[i]._students.Add(students[j]);
                        }
                        counter += studentsCountForTeacher;
                    }
                }
            }
            return teachers;
        }
        public List<StudentModel> Swap(List<TeacherModel> teachers, List<StudentModel> students)
        {
            int counter = 0;
            int studentsCountForTeacher = students.Count / teachers.Count;
            if (students.Count % teachers.Count == 0)
            {
                for (int i = 0; i < teachers.Count; i++)
                {
                    for (int j = counter; j < studentsCountForTeacher + counter; j++)
                    {
                        students[j]._teacher = teachers[i];
                    }
                    counter += studentsCountForTeacher;
                }
            }
            else
            {
                int studentsCountForLastTeacher = (students.Count / teachers.Count) + (students.Count % teachers.Count);
                for (int i = 0; i < teachers.Count; i++)
                {
                    if (i == teachers.Count - 1)
                    {
                        for (int j = counter; j < studentsCountForLastTeacher + counter; j++)
                        {
                            students[j]._teacher = teachers[i];
                        }
                    }
                    else
                    {
                        for (int j = counter; j < studentsCountForTeacher + counter; j++)
                        {
                            students[j]._teacher = teachers[i];
                        }
                        counter += studentsCountForTeacher;
                    }
                }
            }
            return students;
        }
    }
}
