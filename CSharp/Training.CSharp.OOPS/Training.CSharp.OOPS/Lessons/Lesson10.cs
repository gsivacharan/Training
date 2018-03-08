using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Training.CSharp.OOPS.Lessons
{
    public class Lesson10
    {

    }
    internal interface ILesson10
    {
        /*
            1. No Constractor declare in interface
            2. No AccessModifier for any members in Interface
            3. All Members all Public Default
            4. Interface default Internal can be declare Public Only.
            5. Can declare properties,methods,events and Indexers in Interface.
            6. Can not declare variables in Interface.
            7. We can create instance of Interface.
            8. Interface can inherit another Interface.
            9. Interface can not inherit class.
            10. Multiple Interface will be inherited to a class.
            11. When Two Interface has same method we use Explicit Implementation like InterfaceName.MemberName
             */

        void GetName();

        string sType { get; set; }
    }

    internal interface ITestInterface1
    {
        void SameMethod();

    }

    internal interface ITestInterface2
    {
        void SameMethod();
        void UniqueMethod();
    }

    // Testing Explicit Implementation
    class ExplicitImpleMentation : ITestInterface1, ITestInterface2
    {

        // This is explicit implementatin InterfaceName.MethodName
        void ITestInterface1.SameMethod()
        {
            Console.WriteLine("ExplicitImpleMentation.ITestInterface1.SameMethod called");
        }

        void ITestInterface2.SameMethod()
        {
            Console.WriteLine("ExplicitImpleMentation.ITestInterface2.SameMethod called");
        }

        //Once you choose Explicit Implementation you need to declare all methods explicit only, Implicit not working
        void ITestInterface2.UniqueMethod()
        {
            Console.WriteLine("ExplicitImpleMentation.ITestInterface2.UniqueMethod called");
        }

    }

    // Testing Implecit Implementation
    class ImplecitImplementation : ITestInterface1
    {
        public void SameMethod()
        {
            Console.WriteLine("ImplecitImplementation.SameMethod called");
        }
    }

    public class Lesson10Test
    {
        public void Test()
        {
            // This is Explicit Implemented class methods calling procedure
            // you can only call specific Interface method by intanceating the interface.
            ITestInterface1 ITest1 = new ExplicitImpleMentation();
            ITestInterface2 ITest2 = new ExplicitImpleMentation();
            ITest1.SameMethod();
            ITest2.SameMethod();
            ITest2.UniqueMethod();


            //Implecit Implementation Interface calling Procedure
            //You can simple instaceate the Class and call the Interface members
            ImplecitImplementation Imp = new ImplecitImplementation();
            Imp.SameMethod();
        }
    }
}
