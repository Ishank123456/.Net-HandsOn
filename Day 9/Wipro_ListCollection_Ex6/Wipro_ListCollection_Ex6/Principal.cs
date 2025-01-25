using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_ListCollection_Ex6
{
    public class Principal
    {
        public int PrincipalId { get; set; }
        public string PrincipalName { get; set; }

        public List<Student> lstStudent {  get; set; }

        public List<Teacher> lstTeacher { get; set; }
    }
}
