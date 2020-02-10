using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class Classroom
    {
        public string  Level { get; set; }
        public List<Student> Students { get; set; }
        public Classroom(string lv)
        {
            Level = lv;
            Students = new List<Student>();
        }
    }
}
