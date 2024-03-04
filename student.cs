using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new2
{
    internal class student : teacher
    {
        public void knowJava()  //overridden method
        {
            Console.WriteLine("student know java and advance java");
        }
        public void knowDotnet()  // specialized method
        {
            Console.WriteLine("student know concept of dotnet");
        }
    }
}
