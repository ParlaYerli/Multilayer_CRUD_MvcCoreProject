using Business.Abstract;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class StudentManager : IStudentService
    {
        private readonly IStudent studentRepository;
        public StudentManager(IStudent _student)
        {
            studentRepository = _student;
        }
        public void Delete(Student student)
        {
            studentRepository.Delete(student);
        }

        public List<Student> GetAll()
        {
            return studentRepository.GetAll().ToList();
        }

        public Student GetStudentById(int id)
        {
             return studentRepository.GetStudentById(id);
        }

        public void Add(Student student)
        {
            studentRepository.Add(student);
        }

        public void Update(Student student)
        {
            studentRepository.Update(student);
        }

    }
}
