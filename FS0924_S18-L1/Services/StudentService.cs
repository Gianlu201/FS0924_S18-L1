using FS0924_S18_L1.Data;
using FS0924_S18_L1.Models;
using FS0924_S18_L1.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace FS0924_S18_L1.Services
{
    public class StudentService
    {
        private readonly ApplicationDbContext _context;

        public StudentService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<StudentsListViewModel> GetAllStudentsAsync()
        {
            try
            {
                var studentsList = new StudentsListViewModel();

                studentsList.Students = await _context.Students.ToListAsync();

                return studentsList;
            }
            catch
            {
                return new StudentsListViewModel() { Students = new List<Student>() };
            }
        }

        public async Task<Student> GetStudentByIdAsync(Guid id)
        {
            try
            {
                var student = await _context.Students.FindAsync(id);

                if (student == null)
                {
                    return new Student();
                }

                var foundStudent = new Student()
                {
                    Id = student.Id,
                    Name = student.Name,
                    Surname = student.Surname,
                    BirthdayDate = student.BirthdayDate,
                    Email = student.Email,
                };

                return foundStudent;
            }
            catch
            {
                return new Student();
            }
        }
    }
}
