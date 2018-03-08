using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.CSharp.OOPS.Lessons
{
    public class Lesson4
    {

        private void GetPrivateMethod()
        {
            Console.WriteLine("GetPrivateMethod called");
        }

        public void GetPublicMethod()
        {
            Console.WriteLine("GetPublicMethod called");
        }
        protected void GetProtectedMethod()
        {
            Console.WriteLine("GetProtectedMethod called");
        }

        internal void GetInternaldMethod()
        {
            Console.WriteLine("GetInternaldMethod called");
        }

        protected internal void GetProtectedInternaldMethod()
        {
            Console.WriteLine("GetProtectedInternaldMethod called");
        }
    }

    public class Lesson4Test
    {
        public void TestLesson4()
        {
            /*
             * No Inheritence
             * 
            Protected : not accessable
            Internal : called from instance object
            protected Internal : called from instance object

            */

            Lesson4 l4 = new Lesson4();
            l4.GetPublicMethod();
            l4.GetInternaldMethod();
            l4.GetProtectedInternaldMethod();
        }
    }
    public class Lesson4TestDerived : Lesson4
    {
        public void TestLesson4()
        {
            /*
             * With Inheritence
             * 
             Protected : called directly but not from instance object will work from other project too
             Internal : called from instance object
             protected Internal : called from instance object
             
             */
            GetPublicMethod();
            GetInternaldMethod();
            GetProtectedMethod();
            GetProtectedInternaldMethod();

            Lesson4 l4 = new Lesson4();
            l4.GetPublicMethod();
            l4.GetInternaldMethod();
            l4.GetProtectedInternaldMethod();

        }
    }
}
