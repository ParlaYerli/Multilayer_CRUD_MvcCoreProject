using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IStudent
    {
        List<Student> GetAll();
        Student GetStudentById(int id);
        void Add(Student student);
        void Delete(Student student);
        void Update(Student student);
     
    }
}
