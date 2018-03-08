using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Training.CSharp.OOPS.Lessons
{
    public class Lesson7
    {
        public void PrintName()
        {
            Console.WriteLine("Lesson7.PrintName called.");
        }
    }

    public class Lesson7_New
    {
        public void PrintName()
        {
            Console.WriteLine("Lesson7_New.PrintName called.");
        }
    }

    public sealed class NotInheritable
    {
        // This class is not Inheritable.
        public void PrintName()
        {
            Console.WriteLine("NotInheritable.PrintName called.");
        }
    }

    public class ChildClass : Lesson7
    {
        NotInheritable NH = new NotInheritable();

        public void TestChildClass()
        {
            // #Q33. We can create object of Sealed class
            NH.PrintName();
        }
    }
}
