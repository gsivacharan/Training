using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.CSharp.OOPS.Lessons
{
    /*
        *  When base class is not public then we can not inherit to derived class.
     
    */
    class Lesson8
    {
        public void GetName()
        {
            Console.WriteLine("Lesson8.GetName");
        }

        // #35. We can not have Sealed methods. Reason unable to overwrite.
        //public sealed void SealedMethod()
        //{
        //    Console.WriteLine("Lesson8.SealedMethod called.");

        //}
    }

    // #34. No we cannot inherit the not public base class

    //public class DerivedClass : Lesson8
    //{

    //}

    // #31. No we cannot inherit the not sealed class

    //public class DerivedClass : SealedClass
    //{

    //}

    public sealed  class SealedClass
    {
        public SealedClass()
        {
            Console.WriteLine("SealedClass Constructor");
        }

        public void GetSealedClassName()
        {
            Console.WriteLine("GetSealedClassName Called");
        }
    }

    public class SealedClassTest 
    {
        public void GetSealedClassTest()
        {
            //#33 We can not create Inherit of sealed class but we can create object.
            SealedClass sealedClass = new SealedClass();
            sealedClass.GetSealedClassName();

            Console.WriteLine("GetSealedClassTest Called");
        }
    }

    public class Lesson8Test
    {
        public void Test()
        {
            
        }
    }

}
