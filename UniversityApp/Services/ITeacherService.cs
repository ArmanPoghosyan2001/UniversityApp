using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApp.Services
{
    public interface ITeacherService
    {
        public void Add(TeacherModel teacher);
        public void Update(TeacherModel teacher);
        public void Delete(int id);
        public TeacherModel Get(int id);
        public List<TeacherModel> GetAll();
    }
}
