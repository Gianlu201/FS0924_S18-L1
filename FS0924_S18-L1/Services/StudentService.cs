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

        private async Task<bool> TrySaveAsync()
        {
            try
            {
                return await _context.SaveChangesAsync() > 0;
            }
            catch
            {
                return false;
            }
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

        public async Task<bool> AddStudentAsync(AddStudentViewModel addStudentViewModel)
        {
            try
            {
                var student = new Student()
                {
                    Id = Guid.NewGuid(),
                    Name = addStudentViewModel.Name,
                    Surname = addStudentViewModel.Surname,
                    BirthdayDate = addStudentViewModel.BirthdayDate,
                    Email = addStudentViewModel.Email,
                };

                var result = _context.Add(student);

                return await TrySaveAsync();
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> UpdateStudentAsync(EditStudentViewModel editStudentViewModel)
        {
            try
            {
                var result = await _context.Students.FindAsync(editStudentViewModel.Id);

                if (result == null)
                {
                    return false;
                }

                result.Name = editStudentViewModel.Name;
                result.Surname = editStudentViewModel.Surname;
                result.BirthdayDate = editStudentViewModel.BirthdayDate;
                result.Email = editStudentViewModel.Email;

                return await TrySaveAsync();
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> DeleteStudentByIdAsync(Guid id)
        {
            try
            {
                var student = await _context.Students.FindAsync(id);

                if (student == null)
                {
                    return false;
                }

                _context.Students.Remove(student);

                return await TrySaveAsync();
            }
            catch
            {
                return false;
            }
        }
    }
}
