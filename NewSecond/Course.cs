using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSecond
{
    public class Course
    {
        public string Name { get; set; }    
        public int Hours { get; set; }
        public Subject Subject { get; set; }
        public Department Department { get; set; }

    }
}
