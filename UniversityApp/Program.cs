using System;
using System.Collections.Generic;
using UniversityApp.Services;

namespace UniversityApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ITeacherService teacherService = new TeacherService();
            IStudentService studentService = new StudentService();
            IUnivercityManager universityManager = new UniversityManager();

            List<TeacherModel> teachers = new List<TeacherModel>();

            for (int i = 0; i < 3; i++)
            {
                teacherService.Add(new TeacherModel(i, i + 25, $"Teacher {i + 1}"));
            }
            teachers = teacherService.GetAll();
            List<StudentModel> students = new List<StudentModel>();

            for (int i = 0; i < 9; i++)
            {
                studentService.Add(new StudentModel(i, i + 15, $"Student {i + 1}", $"Faculty {i}"));
            }
            students = studentService.GetAll();

            teachers = universityManager.Swap(students, teachers);

            students = universityManager.Swap(teachers, students);


        }
    }
}
