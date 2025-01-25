using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_ListCollection_Ex6
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public string TeacherAddress { get; set; }
        public string TeacherEmail { get; set; }
        public string TeacherContact { get; set; }

        public List<Student> lstStudent {  get; set; }
    }
}
