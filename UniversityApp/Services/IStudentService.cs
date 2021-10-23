using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApp.Services
{
    public interface IStudentService
    {
        public void Add(StudentModel student);

        public void Update(StudentModel student);

        public void Delete(int id);

        StudentModel Get(int id);

        List<StudentModel> GetAll();

    }
}
