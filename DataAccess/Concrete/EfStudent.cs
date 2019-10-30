using DataAccess.Abstract;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class EfStudent : IStudent
    {
        public void Delete(Student student)
        {
            using (var context = new ContextContext())
            {
                 context.Set<Student>().Remove(student);
                 context.SaveChanges();
            }
        }

        public List<Student> GetAll()
        {
            using (var context = new ContextContext())
            {
                return context.Set<Student>().ToList();
               
            }
        }

        public Student GetStudentById(int id)
        {
            using (var context = new ContextContext())
            {
               return  context.Set<Student>().Find(id);
            }
        }

        public void Add(Student student)
        {
            using (var context = new ContextContext())
            {
                context.Set<Student>().Add(student);
                context.SaveChanges();
            }
        }

        public void Update(Student student)
        {
            using (var context = new ContextContext())
            {
                context.Entry(student).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
