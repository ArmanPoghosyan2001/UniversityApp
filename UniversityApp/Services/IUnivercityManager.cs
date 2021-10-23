using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApp.Services
{
    public interface IUnivercityManager
    {
        public void Show(List<StudentModel> students);
      
        public void Show(List<TeacherModel> teachers);
      
        public List<TeacherModel> Swap(List<StudentModel> students, List<TeacherModel> teachers);
     
        public List<StudentModel> Swap(List<TeacherModel> teachers, List<StudentModel> students);
    }
}
