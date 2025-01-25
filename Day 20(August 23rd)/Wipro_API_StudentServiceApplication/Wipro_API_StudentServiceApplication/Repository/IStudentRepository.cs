using Wipro_API_StudentServiceApplication.Model;

namespace Wipro_API_StudentServiceApplication.Repository
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAllStudents();

        Student SelectStudentById(int stuId);

        int CreateStudentInfo(Student student);
        int UpdateStudentInfo(Student student);
        int DeleteStudentInfo(Student student);
    }
}
