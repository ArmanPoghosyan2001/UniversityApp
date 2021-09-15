using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApp
{
    public class TeacherModel
    {
        public TeacherModel(int id, int age, string name)
        {
            _id = id;
            _age = age;
            _name = name;
            _students = new List<StudentModel>();
        }
        public int _id;
        public int _age;
        public string _name;
        public List<StudentModel> _students;
    }
}
