namespace new2
{
    using Microsoft.VisualBasic;
    using System;
    using System.Collections;
    using System.Reflection;
    using System.Security.Principal;

    using System.Transactions;

    internal class Program
    {
        static void Main(string[] args)
        {
            

            /* 11. Design an object-oriented system for a virtual classroom.Consider classes like Student, Teacher, and Course.
            Implement features such as enrollment, grading, and communication between students and teachers.
            Utilize concepts like inheritance, encapsulation, and polymorphism to model the relationships and behaviors in this system.*/



            student student = new student();
            student.knowDotnet();
            student.knowJava();
            student.knowPython();
            Console.ReadLine();

            student2 st2 = new student2();
            course cs = new course("java","python","rubie","dotnet");
            Console.WriteLine("Course 1: " + cs.getCourse1());
            Console.WriteLine("Course 2: " + cs.getCourse2());
            Console.WriteLine("Course 3: " + cs.getCourse3());
            Console.WriteLine("Course 4: " + cs.getCourse4());



            Console.WriteLine("\n polimorphism");

            static void poly(teacher teacher)
            {
                teacher.knowPython();
            }
            poly(student);
            poly(st2);



           



        }
    }
}
