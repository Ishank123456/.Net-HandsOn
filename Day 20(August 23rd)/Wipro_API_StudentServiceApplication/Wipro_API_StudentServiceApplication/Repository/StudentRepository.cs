using Wipro_API_StudentServiceApplication.EntityFramework;
using Wipro_API_StudentServiceApplication.Model;

namespace Wipro_API_StudentServiceApplication.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentDbContext studentDbContext;
        public StudentRepository(StudentDbContext _studentDbContext)
        {
            studentDbContext = _studentDbContext;
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return studentDbContext.Students.ToList();
        }

        public Student SelectStudentById(int stuId)
        {
            return studentDbContext.Students.SingleOrDefault(t => t.StudentId == stuId);
        }

        public int CreateStudentInfo(Student student)
        {
            studentDbContext.Students.Add(student);
            return studentDbContext.SaveChanges();
        }
        public int UpdateStudentInfo(Student student)
        {
            if(student == null)
            {
                throw new ArgumentNullException("Entity Missing");
            }
            studentDbContext.Students.Update(student);
            return studentDbContext.SaveChanges();
        }

        public int DeleteStudentInfo(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Entity Missing");
            }
            studentDbContext.Students.Remove(student);
            return studentDbContext.SaveChanges();
        }
    }
}
