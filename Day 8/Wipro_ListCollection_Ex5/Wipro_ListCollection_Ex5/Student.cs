using System.Collections.Generic;

namespace Wipro_ListCollection_Ex5
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentAddress { get; set; }
        public string StudentEmail { get; set; }
        public string StudentPhone { get; set; }

        public List<Teacher> lstTeacher { get; set; }
    }
}
