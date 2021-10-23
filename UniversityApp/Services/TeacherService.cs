using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UniversityApp.Services;

namespace UniversityApp
{
    public class TeacherService : ITeacherService
    {
        private List<TeacherModel> _teachers;
        public TeacherService()
        {
            _teachers = new List<TeacherModel>();
        }
        public void Add(TeacherModel teacher)
        {
            _teachers.Add(teacher);
        }
        public void Update(TeacherModel teacher)
        {
            TeacherModel wrongTeacher = null;
            for (int i = 0; i < _teachers.Count; i++)
            {
                if (_teachers[i]._id == teacher._id)
                {
                    wrongTeacher = _teachers[i];
                    break;
                }
            }
            int wrongTeacherIdx = _teachers.IndexOf(wrongTeacher);
            _teachers[wrongTeacherIdx] = teacher;
        }
        public void Delete(int id)
        {
            TeacherModel teacherForDelete = null;
            for (int i = 0; i < _teachers.Count; i++)
            {
                if (_teachers[i]._id == id)
                {
                    teacherForDelete = _teachers[i];
                    break;
                }
            }
            _teachers.Remove(teacherForDelete);

        }
        public TeacherModel Get(int id)
        {
            TeacherModel teacher = null;
            for (int i = 0; i < _teachers.Count; i++)
            {
                if (_teachers[i]._id == id)
                {
                    teacher = _teachers[i];
                    break;
                }
            }
            return teacher;
        }
        public List<TeacherModel> GetAll()
        {
            return _teachers;
        }
    }
}
