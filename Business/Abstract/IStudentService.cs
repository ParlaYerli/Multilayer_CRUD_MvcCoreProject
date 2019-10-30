using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IStudentService
    {
        List<Student> GetAll();
        Student GetStudentById(int id);
        void Add(Student student);
        void Delete(Student student);
        void Update(Student student);
    }
}
