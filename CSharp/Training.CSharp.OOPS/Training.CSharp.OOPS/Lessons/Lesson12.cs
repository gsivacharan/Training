using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.CSharp.OOPS.Lessons
{
    public class Lesson12
    {
        public Lesson12()
        {
            Console.WriteLine("Lesson12 Constructor called.");
        }

        ~Lesson12()
        {
            Console.WriteLine("Lesson12 Disstructor called.");
        }

        #region #84 No
        /*
         * We can not have access modifiers 
         * Trow Compile time errro
        public ~Lesson12()
        {
            Console.WriteLine("Lesson12 Public Disstructor called.");
        }
        */
        #endregion

        #region #85 No Parameters
        /*
         * We can not have parameters in deistroctors 
         * Trow Compile time errro
         * 
        ~Lesson12(string a)
        {
            Console.WriteLine("Lesson12 Public Disstructor called.");
        }
        */
        #endregion
    }

    #region #91 GC.Collect();

    public class Base12
    {
        public Base12()
        {
            Console.WriteLine("Lesson12.Base12 Constructor Called.");
        }

        ~Base12()
        {
            Console.WriteLine("Lesson12.Base12 Distrutor Called.");
        }
    }

    public class Child12
    {
        public Child12()
        {
            Console.WriteLine("Lesson12.Child12 Constructor Called.");
        }

        ~Child12()
        {
            Console.WriteLine("Lesson12.Child12 Distrutor Called.");
        }

        public void SomeMethod()
        {
            Console.WriteLine("Some method is called.");
        }
    }

    #endregion

    public class Lesson12Test
    {
        public void Test()
        {
            Lesson12 l12 = new Lesson12();

            Console.WriteLine("#91");
            Child12 c12 =new Child12();
            c12.SomeMethod();
            c12 = null;
            GC.Collect();
        }
    }
}
