using Interfaces;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services
{
    public class StudentService : ICrudService<Student>
    {
        private readonly IApplicationContext _context;

        public StudentService(IApplicationContext context)
        {
            this._context = context;
        }

        public async Task<IEnumerable<Student>> List(Func<Student, bool> filterFunction)
        {
            if (filterFunction != null)
                return this._context.Student.Where(filterFunction);
            return await this._context.Student.ToListAsync();
        }

        public async Task<Student> Create(Student student)
        {
            this._context.Student.Add(student);
            var success = await this._context.Instance.SaveChangesAsync() > 0;

            if(success)
                return student;
         
            throw new Exception("Could not create the student");
        }

        public async Task<Student> Update(Guid id, Student student)
        {
            var studentInDb = await this._context.Student.FindAsync(id);

            if (studentInDb == null)
                throw new Exception($"Could not find the student with Id {id}");

            studentInDb.FirstName = student.FirstName;
            studentInDb.LastName = student.LastName;
            studentInDb.RollNo = student.RollNo;

            var result = await this._context.Instance.SaveChangesAsync() > 0;
            if (result)
                return studentInDb;

            throw new Exception($"Error updating the student with Id {id}");
        }

        public async Task<Student> Delete(Guid id)
        {
            var studentInDb = await this._context.Student.FindAsync(id);

            if (studentInDb == null)
                throw new Exception($"Could not find the student with Id {id}");

           _context.Student.Remove(studentInDb);
            await _context.Instance.SaveChangesAsync();
            return studentInDb;
        }
    }
}
