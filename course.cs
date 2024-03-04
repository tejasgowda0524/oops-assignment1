using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new2
{
    internal class course : teacher
    {
        private string course1;
        private string course2;
        private string course3;
        private string course4;
        public void knowPython()
        {
            Console.WriteLine(" course know the concept of  python");
        }

        public course(string course1, string course2, string course3, string course4)
        {
            this.course1 = course1;
            this.course2 = course2; 
            this.course3 = course3;
            this.course4 = course4;
        }
        public string getCourse1()
        {
            return course1;
        }
        public string getCourse2()
        {
            return course2;
        }
        public string getCourse3()
        {
            return course3;
        }
        public string getCourse4()
        {
            return course4;
        }
    }
}
