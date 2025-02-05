using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Teacher
    {
        static AppDBContext _context = new();
        public int Id { get; set; }
        public string PersonalCode { get; set; }
        public string NationalCode { get; set; }
        public static List<Student> GetStudentsList()
        {
            var students = _context.Students.ToList();
            for (int i = 0; i < students.Count; i++)
            {
                students[i].RowNumber = i + 1;
            }
            return students;
        }
        public static void AddStudent(string fname, string lname, bool isPeresent)
        {

            var student = new Student()
            {
                Fname = fname,
                Lname = lname,
                IsPersent = isPeresent
            };
            _context.Students.Add(student);
            _context.SaveChanges();
        }
        public static void StudentPresenceStatus(int id, bool isPeresent)
        {
            var student = _context.Students.First(s => s.Id == id);
            student.IsPersent = isPeresent;
            _context.Students.Update(student);
            _context.SaveChanges();
        }
        public static bool IsTeacherValid(string username, string password)
        {
            return _context.Teachers.Any(t => t.NationalCode == password && t.PersonalCode == username);
        }
        public static void DeleteStudent(int id)
        {
            var student = _context.Students.FirstOrDefault(s => s.Id == id);
            _context.Students.Remove(student);
            _context.SaveChanges();

        }
        public static void Edit(int id,string fname,string lname)
        {
            var student = _context.Students.First(s => s.Id == id);
            student.Fname = fname;
            student.Lname = lname;
            _context.SaveChanges();
        }
    }
}
